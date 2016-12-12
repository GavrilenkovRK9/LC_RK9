using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace LC_RK9.BL.MacroEditing
{
    public class MacroCreator
    {
        public MacroCreator(string[] parameterNames, string FeaFile)
        {
            feaFile = FeaFile;
            names = parameterNames;
            templateMacro = File.ReadAllLines(feaFile);
            findDesignVariables();

        }

        /// <summary>
        /// Создает группу макросов в той указанной директории.
        /// Макросы называются solution_{i}.mac
        /// </summary>
        public void CreateMacrosInSeparateFiles(string directory, double[][] parameterValues)
        {
            int i = 0;
            foreach (var vector in parameterValues)
            {
                updateChandingVariables(vector);
                File.WriteAllLines(directory + string.Format("\\solution_{0}.mac", i), templateMacro);
                addSolutionIDtoResultFile(i, directory + string.Format("\\solution_{0}.mac", i));
                i++;
            }
        }

        void addSolutionIDtoResultFile(int id, string fileName)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine();
                writer.WriteLine("*cfopen,winners,txt,,append");
                writer.WriteLine("*cfwrite,,{0}", id);
                writer.WriteLine("*cfclos");
            }

        }


        private void findDesignVariables()
        {
            var SetVarEx = new Regex(@"\*set,.+,.+", RegexOptions.IgnoreCase);
            variableLocationInMacro = new int[names.Length];
            int i = 0;
            foreach (var line in templateMacro)
            {
                if (SetVarEx.IsMatch(line))
                {
                    var nameSection = line.Replace(" ", string.Empty).Split(',')[1];
                    foreach (var name in names)
                        if (nameSection.Equals(name))
                        {
                            int k = Array.IndexOf(names, name);
                            variableLocationInMacro[k] = i;
                            break;
                        }

                }
                i++;
            }


        }

        void updateChandingVariables(double[] values)
        {
            for (int i = 0; i < values.Length; i++)
                templateMacro[variableLocationInMacro[i]] = string.Format("*set,{0},{1}", names[i], values[i]);
        }


        int[] variableLocationInMacro;
        string[] templateMacro;
        string[] names;
        string feaFile;
        string feaFileBackUp;
    }
}
