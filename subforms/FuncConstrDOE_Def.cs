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

namespace LC_RK9.subforms
{
    public partial class FuncConstrDOE_Def : Form
    {
        public FuncConstrDOE_Def()
        {
            InitializeComponent();
        }

        public ParameterSpace ParameterSpace { get; set; }

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
    }
}
