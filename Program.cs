using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
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
            // Creates LivestockManager
            LivestockManager lm = new LivestockManager();
            PrivateFontCollection pfc = InitCustomLabelFont();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new HomeForm(lm,pfc));
            }
            catch (Exception)
            {
                Console.WriteLine("Either Isaac broke it or you got scared of popups XD");
            }
        }

        // Creates a font library
        // pfc.Families[0] = Cabin
        // pfc.Families[1] = Cabin Medium
        // pfc.Families[2] = Cabin SemiBold
        // Following code is from:
        // https://stackoverflow.com/questions/1297264/using-custom-fonts-on-a-label-on-winforms
        // (I mostly understand it lol)
        static PrivateFontCollection InitCustomLabelFont()
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Selects font from the resources.
            int fontLength = Properties.Resources.Cabin_VariableFont_wdth_wght.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Cabin_VariableFont_wdth_wght;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            return pfc;
        }
    }
}
