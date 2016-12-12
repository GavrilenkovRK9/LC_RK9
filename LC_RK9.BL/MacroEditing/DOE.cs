using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC_RK9.BL.Experiments;

namespace LC_RK9.BL.MacroEditing
{
    /// <summary>
    /// класс предназначен для определение требуемого количетсва точек в ЛПтау последовательности
    /// </summary>
    public class DOE
    {
        public DOE(Experiment experiment)
        {
            filePathFeaForDOE = APDL_editor.PreprocessMacroForDOE(experiment.FeaFilePath);
        }


        string filePathFeaForDOE;
    }
}
