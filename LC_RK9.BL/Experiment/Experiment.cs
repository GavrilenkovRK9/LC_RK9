using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LC_RK9.BL.Experiments
{
    public class Experiment
    {
        public Experiment()
        {
            //TensionGauge = new StrainGauge(7, 5, 3, 3, 1, 30);
            //CompressionGauge = new StrainGauge(7, 5, 3, 3, 1, 30);
            //NickelGauge = new StrainGauge(7, 5, 3, 3, 1, 30);
            

        } 
        
        protected virtual void GenerateSolutions()
        {

        }      
          
        protected bool isDataInput { get; set; }

        public List<Criterion> Criterions { get; set; }
        public List<Solution> FeasibleSolutions { get; set; }
        public List<Solution> ParetoSolutions { get; set; }

        protected virtual void RecalculateFeasibleAndPareto()
        {
            if (isDataInput)
                return;//это этап выставления данных, еще нет никаких результатов
        }

        #region Структурные элементы эксперимента
        public int PointCount { get; set; }
        public string FeaFilePath { get; set; }
        public List<Surface> surfaces{ get; set; }
        public ParameterSpace DesignSpace { get; set; }
        /// <summary>
        /// жесткие функциональные ограничения
        /// </summary>
        public List<FunConstraint> FixedConstraints { get; set; }
        /// <summary>
        /// Мягкие критериальные ограничения
        /// </summary>
        public List<FunConstraint> CriterionConstrains
        {
            get
            {
                return criterionConstrains;
            }
            set
            {
                criterionConstrains = value;
                RecalculateFeasibleAndPareto();
            }
        }
        /// <summary>
        /// мягкие ограничения на параметры
        /// </summary>
        public List<FunConstraint> SoftConstraintsOnParameters
        {
            get
            {
                return criterionConstrains;
            }
            set
            {
                criterionConstrains = value;
                RecalculateFeasibleAndPareto();
            }
        }

        public StrainGauge TensionGauge { get; set; }
        public StrainGauge CompressionGauge { get; set; }
        public StrainGauge NickelGauge { get; set; }

        #endregion

        private List<FunConstraint> criterionConstrains;
        private List<FunConstraint> softConstraintsOnParameters;
        private List<Solution> solutions;
        
        
     }

    public class ExperimentForDOE
    {
        public ExperimentForDOE()
        {

        }
    }
}
