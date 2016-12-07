using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace LC_RK9.BL
{
    public class Experiment
    {
        public Criterion[] Criterions { get; set; }
        public ParameterSpace ParameterSpace { get; set; }
    }

    public class LocalSearch: Experiment
    {
        public double DeviationFromStartingPoint { get; set; }
    }

    public class Solution
    {
        public bool Feasible { get; set; }
        public double[] CriterionValues { get; set; }
        public double[] ParameterValues { get; set; }
    }

    public class ParameterSpace
    {
        public ParameterSpace()
        {
            Restart();
        }

        public void Restart()
        {
            Variables = new List<Variable>();
        }

        public string macroFilePath { get; set; }
        public List<Variable> Variables { get; set; }
        
    }

    

    public class Constraint
    {
        public Constraint(string ConstraintEquation)
        {
            constraint = new Expression(ConstraintEquation);
        }

        /// <summary>
        /// Функция проверяет, правильно ли записано условие
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public bool ConstrainDefinitionValid(List<string> parameters)
        {
            Random rnd = new Random();

            foreach (var term in parameters)
            {
                constraint.Parameters[term] = rnd.NextDouble();
            }
            try
            {
                var result = (bool)constraint.Evaluate();
                //проверка во-первых, на синтаксическую правильность
                //во-вторых, на тип результата - должна быть булевская переменная
                //в-третьих, на то, что были заданы правильные параметры
                //любое нарушение вызовет исключение
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// проверка, выполнено ли ограничение
        /// </summary>
        /// <param name="names"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool ConstraintSatisfied(string [] names, double[] values)
        {
            for (int i = 0; i < values.Length; i++)
                 constraint.Parameters[names[i]] = values;
            return (bool)constraint.Evaluate();
        }

        private Expression constraint;
    }

    public class Criterion
    {
        public Criterion(string Name, bool isMinimized)
        {
            this.Name = Name;
            this.isMinimized = isMinimized;
        }
        public string Name { get; set; }
        public bool isMinimized { get; set; }
    }

    public class Variable
    {
        public double InitValue { get; set; }
        public double Hi { get; set; }
        public double Lo { get; set; }
        public string Name { get; set; }
        public bool IsDecisionVariable { get; set; }
    }
}
