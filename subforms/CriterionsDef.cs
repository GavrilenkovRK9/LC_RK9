using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LC_RK9.BL;
using LC_RK9.BL.Utilities;


namespace LC_RK9.subforms
{
    public partial class CriterionsDef : Form
    {
        public CriterionsDef()
        {
            InitializeComponent();
            Criterions = new List<Criterion>();

        }

        private void CriterionsDef_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            for (int i = 0; i < tblCriterionDefinition.RowCount-1; i++)
            {
                Criterions[i].isMinimized = (bool)tblCriterionDefinition.Rows[i].Cells[1].Value;
            }
            Hide();
            e.Cancel = true;
        }

        

        
        public List<Criterion> Criterions { get; set; }
       

        private void tblCriterionDefinition_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
            var cell = tblCriterionDefinition.CurrentCell;
            if (cell is DataGridViewTextBoxCell)
            {
                var contents = (string)cell.Value;
                if (contents == null)
                    return;
                if (contents.Length == 0 )
                    return;
                contents.Replace(' ', '_');
                if (!char.IsLetter(contents[0]))
                {
                    MessageService.ShowError("Пошел ты нахер, козел!");
                    cell.Value = "";
                }
                else
                {
                    var duplicate = Criterions.Find(f => f.Name == contents);
                    if(duplicate == null)//no duplicates
                    {
                        cell.Value = contents;
                        Criterions.Add(new Criterion(contents, true));
                        cell.OwningRow.Cells[1].Value = true;
                    }
                    else
                    {
                        MessageService.ShowError("Дубликат, низзя!");
                        cell.Value = "";
                    }
                    
                }

            }
        }

        private void tblCriterionDefinition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var cell = tblCriterionDefinition.CurrentCell;
            if (cell.Value == null && cell is DataGridViewTextBoxCell)
                return;
            else
            {
                switch(cell.ColumnIndex)
                {
                    case 1:
                        senderGrid.Rows[e.RowIndex].Cells[1].Value = !(bool)senderGrid.Rows[e.RowIndex].Cells[1].Value;
                        break;
                    case 2:
                        senderGrid.Rows.RemoveAt(e.RowIndex);
                        Criterions.RemoveAll(f => f.Name == (string)cell.OwningRow.Cells[0].Value);
                        break;
                }
            }
            
        }
    }
}
