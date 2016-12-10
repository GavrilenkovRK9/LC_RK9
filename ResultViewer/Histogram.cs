using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LC_RK9.ResultViewer
{
    public partial class Histogram : Form
    {
        public Histogram(string[] variableName, double[][] variableValues)
        {
            InitializeComponent();
            this.variableName = variableName;
            this.variableValues = variableValues;

            currentVariable = this.variableName[0];
            currentValues = this.variableValues[0];

            histMin = currentValues.Min();
            histMax = currentValues.Max();
            sliderHi.Value = sliderHi.Maximum;

            foreach (var variable in variableName)
                cmbVariables.Items.Add(variable);
            cmbVariables.SelectedIndex = 0;

            //настройки графика, чтобы было красиво
            chrtHistogram.ChartAreas.First().AxisY.MajorGrid.Enabled = false;
            chrtHistogram.ChartAreas.First().AxisX.MajorGrid.Enabled = false;
            chrtHistogram.Series.First().BorderWidth = 2;

            //
            int variableCount = variableName.Count();
            variableRangeIsAltered = new bool[variableCount];
            variableWithAlteredLo = new double[variableCount];
            variableWithAlteredHi = new double[variableCount];
            nameOfAlteredVariable = new string[variableCount];
        }

        public bool[] variableRangeIsAltered { get; set; }
        public double[] variableWithAlteredLo { get; set; }
        public double[] variableWithAlteredHi { get; set; }
        public string[] nameOfAlteredVariable { get; set; }

        string[] variableName;
        double[][] variableValues;

        string currentVariable;
        double[] currentValues;

        double histMin;
        double histMax;

        double variableMin;
        double variableMax;

        const int binCount = 10;

        void reChart()
        {
            chrtHistogram.Series.First().Points.Clear();
            chrtHistogram.ChartAreas.First().AxisX.Minimum = histMin;
            chrtHistogram.ChartAreas.First().AxisX.Maximum = histMax;

            double binWidth = (histMax - histMin) / binCount;
            double binLo, binHi;
            int binSolutionCount = 1;
            for (int i = 0; i < binCount; i++)
            {
                binLo = histMin + i * binWidth;
                binHi = binLo + binWidth;
                binSolutionCount = currentValues.Where(f => (f > binLo && f <= binHi)).Count();
                chrtHistogram.Series.First().Points.AddXY(binLo, binSolutionCount);


            }
            chrtHistogram.Series.First().Points.AddXY(histMax, binSolutionCount);

        }

        private void sliderLo_Scroll(object sender, EventArgs e)
        {
            changeVariableRange();
        }

        private void sliderHi_Scroll(object sender, EventArgs e)
        {
            changeVariableRange();
        }

        private void changeVariableRange()
        {

            if (sliderLo.Value >= sliderHi.Value)
            {
                resetSliders();
                MessageBox.Show("Ошибка!");
            }
            else
            {
                variableMin = histMin + ((double)sliderLo.Value) / ((double)sliderLo.Maximum);
                variableMax = histMin + (histMax - histMin) * ((double)sliderHi.Value) / ((double)sliderHi.Maximum);
            }

        }


        void resetSliders()
        {
            sliderLo.Value = 0;
            sliderHi.Value = 1000;
        }

        private void cmbVariables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butAlterRange_Click(object sender, EventArgs e)
        {

        }
    }
}
