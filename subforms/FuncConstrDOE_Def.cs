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

        private List<string> decisionVariableName;
        private List<double> decisionVariableValue;

        public void updateForm(ParameterSpace ParameterSpace)
        {

        }

        private void displayNamesOfDecisionVariables()
        {
           
        }
    }
}
