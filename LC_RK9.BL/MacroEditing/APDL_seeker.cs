﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using NCalc;

namespace LC_RK9.BL.MacroEditing
{
    public static class APDL_seeker
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

        private static bool nameIsInTheList(IEnumerable<string> list, string name)
        {
            foreach (var item in list)
                if (item.Equals(name))
                    return true;
            return false;
        }
    }
}
