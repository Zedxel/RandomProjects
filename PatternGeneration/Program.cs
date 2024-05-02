using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace PatternGeneration
{
    class Program
    {
        [SupportedOSPlatform("windows6.1")]
        public static void Main(string[] args)
        {
            Console.Title = "Fractal Generation";
            DrawingForm MainApp = new();

            Application.Run(MainApp);
            MainApp.BackColor = Color.Red;
            Application.DoEvents();
        }

    }
}