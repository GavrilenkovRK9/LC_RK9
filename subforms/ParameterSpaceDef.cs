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
using LC_RK9.BL.MacroEditing;
using LC_RK9.BL.Utilities;

namespace LC_RK9.subforms
{
    public partial class ParameterSpaceDef : Form
    {
        public ParameterSpaceDef()
        {
            InitializeComponent();
            tblParameters.RowCount = 1;
            tblParameters.AllowUserToAddRows = false;
            ParameterSpace = new ParameterSpace();
        }

        

        private void butSelectFEA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "макрос ANSYS (*.mac)|*.mac";
            if(dia.ShowDialog() == DialogResult.OK)
            {
                ParameterSpace.macroFilePath = dia.FileName;
                uploadInitialVariableData();
            }
               
            
        }

        private void uploadInitialVariableData()
        {
            var names = APDL_seeker.GetVariables(ParameterSpace.macroFilePath);
            var values = APDL_seeker.GetValuesOfVariables(ParameterSpace.macroFilePath, names);
            int j = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if(!double.IsNaN(values[i]))//если значение параметра нормальное числовое
                {
                    tblParameters.Rows.Add();
                    tblParameters.Rows[j].Cells[0].Value = names[i];
                    tblParameters.Rows[j].Cells[1].Value = values[i];
                    tblParameters.Rows[j].Cells[4].Value = "Нет";
                    j++;
                }

            }
        }

        public ParameterSpace ParameterSpace { get; set; }

        private void butDeleteVariable_Click(object sender, EventArgs e)
        {
            int index = tblParameters.CurrentCell.RowIndex;
            tblParameters.Rows.RemoveAt(index);
        }

        private void butFlipVariableStatus_Click(object sender, EventArgs e)
        {
            int index = tblParameters.CurrentCell.RowIndex;
            if (tblParameters.Rows[index].Cells[4].Value.Equals("Нет"))
                tblParameters.Rows[index].Cells[4].Value = "Да";
            else
                tblParameters.Rows[index].Cells[4].Value = "Нет";

        }

        private void tblParameters_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double parsingResult;
            if(tblParameters.CurrentCell.Value!=null && (e.ColumnIndex == _lo_value_column_index || e.ColumnIndex == _hi_value_column_index))
                if (!double.TryParse((string)tblParameters.CurrentCell.Value, out parsingResult))
                {
                    MessageService.ShowError("Я ломал стеклоууууу...не, х%йня. Число введи!");
                    tblParameters.CurrentCell.Value = null;
                }

            
            
        }

        private bool UnspecifiedValuesExist()
        {
            foreach (DataGridViewRow row in tblParameters.Rows)
               if ((row.Cells[_lo_value_column_index].Value == null ||
                    row.Cells[_hi_value_column_index].Value == null) && row.Cells[_is_decision_variable_column_index].Value.Equals("Да"))
                    return true;
            return false;
            
        }

        private const int _name_column_index = 0;
        private const int _init_value_column_index = 1;
        private const int _lo_value_column_index = 2;
        private const int _hi_value_column_index = 3;
        private const int _is_decision_variable_column_index = 4;

        private void ParameterSpaceDef_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UnspecifiedValuesExist())
            {
                MessageService.ShowAchtung("Внимание! Не всем управляющим парамтрам задано верхнее и/или нижнее значение!");
                e.Cancel = true;
            }
            else
            {
                ParameterSpace.Restart();
                foreach (DataGridViewRow row in tblParameters.Rows)
                {
                    ParameterSpace.Name.Add((string)row.Cells[_name_column_index].Value);
                    if (row.Cells[_is_decision_variable_column_index].Value.Equals("Да"))
                    {
                        ParameterSpace.isDesignParameter.Add(true);
                        ParameterSpace.Lo.Add(Convert.ToDouble(row.Cells[_lo_value_column_index].Value));
                        ParameterSpace.Hi.Add(Convert.ToDouble(row.Cells[_hi_value_column_index].Value));
                    }
                    else
                    {//If the paramter is not a decision parameter set hi and lo values equal to the 
                        //initial variable value
                        ParameterSpace.isDesignParameter.Add(false);
                        ParameterSpace.Lo.Add((double)row.Cells[_init_value_column_index].Value);
                        ParameterSpace.Hi.Add((double)row.Cells[_init_value_column_index].Value);
                    }

                    
                }
                Hide();
                e.Cancel = true;
            }
        }
    }
}
