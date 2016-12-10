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
using Experiment = LC_RK9.BL.Experiments.Experiment;

namespace LC_RK9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
            experiment = new Experiment();
            criterionsForm = new CriterionsDef();
            constraints_Form = new FuncConstrDef();
            tensionGaugeForm = new StrainGaugeDef("ТР растяжения");
            compressionGaugeForm = new StrainGaugeDef("ТР сжатия");
            nickelGaugeForm = new StrainGaugeDef("ТР-никель");
            parameterSpaceForm = new ParameterSpaceDef();
            DOE_Form = new DOE_Def();

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
                    experiment.DesignSpace = parameterSpaceForm.ParameterSpace;
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
                case "ndFuncConstr_Def":
                    constraints_Form.updateForm(parameterSpaceForm.ParameterSpace);
                    displayAnotherForm(constraints_Form);
                    experiment.FixedConstraints = constraints_Form.Constraints;
                    break;
                case "ndCriterionsDef":
                    displayAnotherForm(criterionsForm);
                    experiment.Criterions = criterionsForm.Criterions;
                    break;
                case "ndDOE_Def":
                    displayAnotherForm(DOE_Form);
                    experiment.PointCount = DOE_Form.PointCount;
                    break;
                case "ndResultsViewer":
                    
                    break;
                case "ndSelectSurfaces":
                    var selector = new BL.StrainGaugeLocation.SelectSurfaces();
                    selector.Select(experiment.DesignSpace.macroFilePath);
                    experiment.surfaces = selector.Surfaces;
                    break;
            }
        }


        private void displayAnotherForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
            experiment.NickelGauge = nickelGaugeForm.Gauge;
            experiment.TensionGauge = tensionGaugeForm.Gauge;
            experiment.CompressionGauge = compressionGaugeForm.Gauge;
        }

        
        CriterionsDef criterionsForm;
        FuncConstrDef constraints_Form;
        StrainGaugeDef tensionGaugeForm;
        StrainGaugeDef compressionGaugeForm;
        StrainGaugeDef nickelGaugeForm;
        ParameterSpaceDef parameterSpaceForm;
        DOE_Def DOE_Form;
        Experiment experiment;
    }
}
