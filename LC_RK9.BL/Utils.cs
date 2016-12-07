using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
}
