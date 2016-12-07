using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LC_RK9.subforms;
using LC_RK9.BL;

namespace LC_RK9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
            experiment = new Experiment();
            criterionsForm = new CriterionsDef();
            constraintsDOE_Form = new FuncConstrDOE_Def();
            tensionGaugeForm = new StrainGaugeDef("ТР растяжения");
            compressionGaugeForm = new StrainGaugeDef("ТР сжатия");
            nickelGaugeForm = new StrainGaugeDef("ТР-никель");
            parameterSpaceForm = new ParameterSpaceDef();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void designProcessTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
             switch(e.Node.Name)
            {
                case "ndParameterSpaceDef":
                    displayAnotherForm(parameterSpaceForm);
                    experiment.ParameterSpace = parameterSpaceForm.ParameterSpace;
                    break;
                case "ndTensionGauge":
                    displayAnotherForm(tensionGaugeForm);
                    break;
                case "ndCompressionGauge":
                    displayAnotherForm(compressionGaugeForm);
                    break;
                case "ndNickelGauge":
                    displayAnotherForm(nickelGaugeForm);
                    break;
                case "ndFuncConstrDOE_Def":
                    constraintsDOE_Form.updateForm(experiment.ParameterSpace);
                    displayAnotherForm(constraintsDOE_Form);
                    break;
                case "ndCriterionsDef":
                    displayAnotherForm(criterionsForm);
                    break;
                case "ndResultsViewer":

                    break;
            }
        }


        private void displayAnotherForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }

        Experiment experiment;
        CriterionsDef criterionsForm;
        FuncConstrDOE_Def constraintsDOE_Form;
        StrainGaugeDef tensionGaugeForm;
        StrainGaugeDef compressionGaugeForm;
        StrainGaugeDef nickelGaugeForm;
        ParameterSpaceDef parameterSpaceForm;
    }
}
