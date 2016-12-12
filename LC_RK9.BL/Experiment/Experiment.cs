using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LC_RK9.BL.UniformSequence;

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
            var decisionVariables = DesignSpace.Variables.Where(f => f.IsDecisionVariable).ToArray();
            var LP_TAU = new SobolAB(PointCount, decisionVariables.Count(), decisionVariables.Select(f => f.Lo).ToArray(),
                decisionVariables.Select(f => f.Hi).ToArray());
            var names = decisionVariables.Select(f => f.Name).ToArray();
            //проверка на выполнимость всех функциональных ограничений.
            
            for (int i = 0; i < PointCount; i++)
            {
                var parSet = LP_TAU.getNextSobolAB().Select(f => Math.Round(f, 4));
                bool fixedConstraintSatisfied = true;
                foreach (var constraint in FixedConstraints)
                {
                    if (!constraint.ConstraintSatisfied(names, parSet.ToArray()))
                    {
                        fixedConstraintSatisfied = false;
                        break;
                    }
                }
                if (fixedConstraintSatisfied)
                    solutions.Add(new Solution());
            }
        }

        protected virtual void GenerateAndRunMacros()
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
