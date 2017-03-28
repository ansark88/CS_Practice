using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TesterSample;

namespace WindowsFormsApplication1
{
    
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(Deploy.getInstance());
        }

        static public Ivi.Visa.Interop.ResourceManager RM = new Ivi.Visa.Interop.ResourceManager(); 

        static public Measure DMM = new Measure(Measure.USB_DMM1);
        
    }
}
