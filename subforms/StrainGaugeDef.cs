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
    public partial class StrainGaugeDef : Form
    {
        public StrainGaugeDef(string formTitle)
        {
            InitializeComponent();
            Text = formTitle;

            Gauge = new StrainGauge(_defaultLength, _defaultWidth, _defaultGridLength,
                _defaultGridWidth, _defaultBaseLength, _defaultGridFrequency);
            
        }

        public StrainGauge Gauge { get; set; }

        #region default_sg_paramters
        private const double _defaultLength = 7;
        private const double _defaultWidth = 5;
        private const double _defaultGridLength = 3;
        private const double _defaultGridWidth = 3;
        private const double _defaultBaseLength = 1;
        private const int _defaultGridFrequency = 30;
        #endregion

        private void StrainGaugeDef_Load(object sender, EventArgs e)
        {

        }
    }
}
