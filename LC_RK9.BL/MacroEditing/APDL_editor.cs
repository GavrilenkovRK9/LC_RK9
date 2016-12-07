using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using NCalc;

namespace LC_RK9.BL.MacroEditing
{
    public static class APDL_editor
    {
        public static string[] GetVariables(string filePath)
        {
            var variables = new List<string>();
            var SetVarRegex = new Regex(@"\*set,.+,.+", RegexOptions.IgnoreCase);
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (SetVarRegex.IsMatch(line))
                    variables.Add(line.Split(',')[1]);
            }
            return variables.ToArray();
        }

        public static double[] GetValuesOfVariables(string filePath, string[] variableNames)
        {
            //функция возвращает значения указанных переменных в данном файле
            variableNames = variableNames.Select(f => f.Replace(" ", string.Empty)).ToArray();
            var SetVarEx = new Regex(@"\*set,.+,.+", RegexOptions.IgnoreCase);
            double[] values = new double[variableNames.Count()];
            var feaScript = File.ReadAllLines(filePath);

            foreach (var line in feaScript)
            {
                if (SetVarEx.IsMatch(line))
                {
                    var nameSection = line.Replace(" ", string.Empty).Split(',')[1];
                    var expressionSection = line.Replace(" ", string.Empty).Split(',')[2];
                    if (nameIsInTheList(variableNames, nameSection))
                    {
                        int indexOf = Array.IndexOf(variableNames.ToArray(), nameSection);
                        Expression exp = new Expression(expressionSection);
                        try
                        {
                            values[indexOf] = (double)exp.Evaluate();
                        }
                        catch
                        {
                            values[indexOf] = double.NaN;//expression is not arithmetical
                        }
                        

                    }
                }
            }
            return values;
        }

        /// <summary>
        /// create an auxiliary macro in the same directory as the input file
        /// THe macro is modified for Design Of Experiment subroutine
        /// the function return filepath to the modified macro
        /// </summary> 
        /// <param name="filePath"></param>
        public static string PreproceeMacroForDOE(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            var directory = Path.GetDirectoryName(filePath);

            var outputFileName = "DOE_aux_" + fileName;

            var inputText = File.ReadAllLines(filePath).ToList();
            //уничтожение всего, что идет после solve или lssolve
            var solveRegEx = new Regex(@"(solve|lssolve)", RegexOptions.IgnoreCase);

            int indexForRemoving = inputText.FindIndex(f => solveRegEx.IsMatch(f) == true);
            inputText = inputText.Take(indexForRemoving).ToList();
            //добавление в список параметров фиктивного параметра - номера решения
            inputText.Add("*set,sol_id,0");
            //Уничтожение команд, которые имеют отношение к сетке
            var meshRegEx = new Regex(@"(lmesh|amesh|vmesh|esurf)", RegexOptions.IgnoreCase);
            for (int i = 0; i < inputText.Count; i++)
                if (meshRegEx.IsMatch(inputText[i]))
                    inputText[i] = "";
            inputText.Add("allsel"); inputText.Add("*get, kpCountBeforeIntersect,KP,0,count");
            inputText.Add("linp,all"); inputText.Add("*get, kpCountAfterIntersect,KP,0,count");
            inputText.Add("*if,kpCountBeforeIntersect,eq,kpCountAfterIntersect,then"); inputText.Add("*cfopen, results,txt,,append");
            inputText.Add("*cfwrite,,solution_ID"); inputText.Add("*cfclos"); inputText.Add("*endif");

            File.WriteAllLines(outputFileName, inputText);
            return filePath;

        }

        

        private static bool nameIsInTheList(IEnumerable<string> list, string name)
        {
            foreach (var item in list)
                if (item.Equals(name))
                    return true;
            return false;
        }
    }
}
