using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppV2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LivestockManager lm = new LivestockManager();

            // https://stackoverflow.com/questions/1297264/using-custom-fonts-on-a-label-on-winforms
            InitCustomLabelFont()
            {
                //Create your private font collection object.
                PrivateFontCollection pfc = new PrivateFontCollection();

                //Select your font from the resources.
                //My font here is "Digireu.ttf"
                int fontLength = Properties.Resources.Cabin_VariableFont_wdth_wght.Length;

                // create a buffer to read in to
                byte[] fontdata = Properties.Resources.Cabin_VariableFont_wdth_wght;

                // create an unsafe memory block for the font data
                System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

                // copy the bytes to the unsafe memory block
                Marshal.Copy(fontdata, 0, data, fontLength);

                // pass the font to the font collection
                pfc.AddMemoryFont(data, fontLength);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm(lm));
        }
    }
}
