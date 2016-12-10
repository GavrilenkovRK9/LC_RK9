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
using FuncConstr = LC_RK9.BL.FunConstraint;

namespace LC_RK9.subforms
{
    public partial class FuncConstrDef : Form
    {
        public FuncConstrDef()
        {
            InitializeComponent();
            Constraints = new List<FuncConstr>();
            
        }

        ParameterSpace parameterSpace { get; set; }
        public List<FuncConstr> Constraints { get; set; }
        

        private List<Variable> decisionVariables;
        private List<string> decisionVariableName;
        private List<double> decisionVariableValue;

        public void updateForm(ParameterSpace ParameterSpace)
        {
            parameterSpace = ParameterSpace;
            decisionVariables = ParameterSpace.Variables.Where(f => f.IsDecisionVariable == true).ToList();
            decisionVariableName = decisionVariables.Select(f => f.Name).ToList();
            decisionVariableValue = decisionVariables.Select(f => f.InitValue).ToList();
            fldDecisionVariableStatus.Text = string.Join("; ", decisionVariableName.Zip(decisionVariableValue,
                (x, y) =>string.Format("{0}={1}", x, y)).ToArray());

        }

        
        private void tblConstraints_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (tblConstraints.CurrentCell.Value == null)
                return;
            string contents = (string)tblConstraints.CurrentCell.Value;
            var temp = new FuncConstr(contents);
            if (!temp.ConstrainDefinitionValid(decisionVariableName))
            {
                MessageService.ShowError("Ограничение задано с ошибкой!");
                tblConstraints.CurrentCell.Value = null;
            }
        }

        private void FuncConstrDOE_Def_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewRow row in tblConstraints.Rows)
                if (row.Cells[0].Value != null)
                    Constraints.Add(new FuncConstr((string)row.Cells[0].Value));
        }

        private void FuncConstrDef_Load(object sender, EventArgs e)
        {
            
        }

        private void butDeleteConstraint_Click(object sender, EventArgs e)
        {
            tblConstraints.Rows.RemoveAt(tblConstraints.CurrentCell.RowIndex);

        }
    }
}
