using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinect
{
    static class Program
    {

        
        private static Form balint = new Kinect.balint.Main();
        private static Form viktor = new Kinect.viktor.Main();
        private static Form bence = new Kinect.bence.Main();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);     // nem tudom milyen exception van, ha ez nincs kikommentezve
            Application.Run( balint );
        }
    }
}
