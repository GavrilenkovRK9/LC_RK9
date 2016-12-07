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
using FuncConstr = LC_RK9.BL.Constraint;

namespace LC_RK9.subforms
{
    public partial class FuncConstrDOE_Def : Form
    {
        public FuncConstrDOE_Def()
        {
            InitializeComponent();
            FunctionalConstraints = new List<FuncConstr>();
        }

        public ParameterSpace ParameterSpace { get; set; }
        public List<FuncConstr> FunctionalConstraints { get; set; }

        private List<Variable> decisionVariables;
        private List<string> decisionVariableName;
        private List<double> decisionVariableValue;

        public void updateForm(ParameterSpace ParameterSpace)
        {
            decisionVariables = ParameterSpace.Variables.Where(f => f.IsDecisionVariable == true).ToList();
            decisionVariableName = decisionVariables.Select(f => f.Name).ToList();
            decisionVariableValue = decisionVariables.Select(f => f.InitValue).ToList();
            fldDecisionVariableStatus.Text = string.Join("; ", decisionVariableName.Zip(decisionVariableValue,
                (x, y) =>string.Format("{0}={1}", x, y)).ToArray());

        }

        private void displayNamesOfDecisionVariables()
        {
           
        }

        private void tblConstraints_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (tblConstraints.CurrentCell.Value == null)
                return;
            string contents = (string)tblConstraints.CurrentCell.Value;
            FunctionalConstraints.Add(new FuncConstr(contents));
            if(!FunctionalConstraints.Last().ConstrainDefinitionValid(decisionVariableName))
            {
                MessageService.ShowError("Ограничение задано с ошибкой(((");
                tblConstraints.CurrentCell.Value = null;
                FunctionalConstraints.RemoveAt(FunctionalConstraints.Count - 1);
            }
        }

        private void FuncConstrDOE_Def_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
