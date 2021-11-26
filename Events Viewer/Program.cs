using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Events_Viewer
{

     public class EventAdapter {

        private EventLog eventLog = new EventLog();

        public EventAdapter() {
            this.eventLog.Log = "System";
        }

        public EventLogEntryCollection getEvents() {
            return this.eventLog.Entries; 
        }

        public int getCount() {
            return this.eventLog.Entries.Count;
        }
    }


    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
