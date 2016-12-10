using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LC_RK9.BL.Utilities
{
    public static class MessageService
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "ЕГГОГ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowAchtung(string message)
        {
            MessageBox.Show(message, "ACHTUNG!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
       
    }

    public class BatchManager
    {
        public BatchManager()
        {
            readConfigurations();
        }

        public void RunOnceGUI()
        {
            var launchCommand = getLaunchSequenceGUI("solution_0.mac");
            File.WriteAllText("launcher.bat", launchCommand);
            run();
        }


        public void RunBatch(int solutionCount)
        {
            if (!Directory.Exists("temp\\"))
            {
                Directory.CreateDirectory("temp\\");
            }
            cleanTempDirectory();

            List<string> launchCommands = new List<string>();

            for (int i = 0; i < solutionCount; i++)
                launchCommands.Add(getLaunchSequence(string.Format("solution_{0}.mac", i)));

            File.WriteAllLines("launcher.bat", launchCommands);
            run();
        }

        void run()
        {
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "launcher.bat";
            process.Start();
            process.WaitForExit();
            File.Delete("launcher.bat");
        }

        private string getLaunchSequence(string input_file)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "temp";
            string cmd_line = string.Format(@"""{0}"" -b -i ""{1}"" -p {2} -np {3} -dir ""{4}"" -j ""{5}"" - s read -m {6} -db {7} - l en - us - t - d win32 -o ""{8}""", fea_executable_path,
                directory + string.Format("\\{0}", input_file), license_type, numberOfCores, directory, "makrel", memory_allocation, (int)(memory_allocation / 2), directory + "\\stanok.txt");
            return cmd_line;
        }

        private string getLaunchSequenceGUI(string input_file)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "temp";
            string cmd_line = string.Format(@"""{0}""  -g -p {1} -np {2} -dir ""{3}"" -j ""{4}"" -s read -l en-us -t -d win32",
                fea_executable_path, license_type, numberOfCores, directory,
                "makrel");
            return cmd_line;
        }


        private void readConfigurations()
        {
            if (File.Exists("configs.txt"))
            {
                string[] lines = File.ReadAllLines("configs.txt");
                try
                {
                    if (lines.Length != 4)
                        throw new Exception("Данные конфигурации введены неполностью или с ошибками");
                    fea_executable_path = lines.First();
                    license_type = lines[1];
                    numberOfCores = int.Parse(lines[2]);
                    memory_allocation = int.Parse(lines[3]);

                }
                catch
                {
                    throw new Exception("Данные конфигурации введены неполностью или с ошибками");
                }
            }
            else
                throw new Exception("Файла конфигурации configs.txt не существует.\n Его нужно создать.");
        }

        private void cleanTempDirectory()
        {
            DirectoryInfo tempFolder = new DirectoryInfo(@"temp\");
            foreach (FileInfo file in tempFolder.GetFiles())
            {
                try
                {
                    if (!file.Name.Contains(".mac"))
                        file.Delete();
                }
                catch
                {

                }
            }

        }



        private string fea_executable_path;
        private string license_type;
        private int numberOfCores;
        private int memory_allocation;
    }

    public static class Utils
    {
        public static void CleanFolder(string folderName)
        {
            DirectoryInfo tempFolder = new DirectoryInfo(folderName);
            foreach (FileInfo file in tempFolder.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                {

                }
            }
        }
    }
}
