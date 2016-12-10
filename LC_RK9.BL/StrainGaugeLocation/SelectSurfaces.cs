using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LC_RK9.BL.Utilities;

namespace LC_RK9.BL.StrainGaugeLocation
{
    public class SelectSurfaces
    {
        public SelectSurfaces()
        {
            Surfaces = new List<Surface>();
        }

        public void Select(string feaFilePath)
        {
            
            string folder = AppDomain.CurrentDomain.BaseDirectory + "temp\\";
            Utils.CleanFolder(folder);
            string pickerMacro = AppDomain.CurrentDomain.BaseDirectory + "scripts\\linePicker.mac";
            string mainMacro = folder + "solution_0.mac";
            //создать аббревиатуру:
            var writer = new StreamWriter(folder + "start140.ans");
            writer.WriteLine("*abbr, vibrat_resultat, solution_0.mac");
            writer.Close();
            //скопировать основной макрос
            File.Copy(feaFilePath, mainMacro);
            var auxMacro = File.ReadAllLines(pickerMacro);
            writer = new StreamWriter(mainMacro, true);
            writer.WriteLine();
            foreach (var line in auxMacro)
                writer.WriteLine(line);
            writer.Close();

            var manager = new BatchManager();
            manager.RunOnceGUI();

            var lines = File.ReadAllLines(folder + "lineList.txt");
            foreach (var line in lines)
            {
                Surfaces.Add(new Surface());
                
                Surfaces.Last().ID = int.Parse(line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0]);
                int kek = int.Parse(line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1]);
                if (kek == 0)
                    Surfaces.Last().Horizontal = true;
                else
                    Surfaces.Last().Horizontal = false;
            }

        }

        public List<Surface> Surfaces;
    }
}
