using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterSample
{
    class Measure
    {
        public const string USB_DMM1 = "34410A";
        public const string USB_OSC1 = "DSOX3104A";

        public enum DMM_Mode_Num{
            emDCV,
            emACV,
            emDCI,
            emACI,
            emResist,
            emNothing
        };

        private Ivi.Visa.Interop.FormattedIO488 entity;
        private string read_data;
        //constructer
        public Measure(string name)
        {
            this.entity = new Ivi.Visa.Interop.FormattedIO488();

            try
            {
                this.entity.IO = (Ivi.Visa.Interop.IMessage)WindowsFormsApplication1.Program.RM.Open(name);
            }
            catch(System.Runtime.InteropServices.COMException e) { MessageBox.Show(e.ToString()); }
        }

        public string readValue()
        {
            this.entity.WriteString("READ?");
            this.read_data = this.entity.ReadString();

            return this.read_data;
        }
    }
}
