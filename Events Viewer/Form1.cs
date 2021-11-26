using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


public class EventAdapter
{

    private EventLog eventLog = new EventLog();

    public EventAdapter()
    {
        this.eventLog.Log = "System";
    }

    public EventLogEntryCollection getEvents()
    {
        return this.eventLog.Entries;
    }

    public int getCount()
    {
        return this.eventLog.Entries.Count;
    }
}


namespace Events_Viewer
{
    public partial class Form1 : Form
    {

        private EventAdapter eventAdapter = new EventAdapter();

        public Form1()
        {
            InitializeComponent();

            this.initColumns();
            this.initRows();
            this.eventsCount.Text = Convert.ToString(eventAdapter.getCount());
        }

        private void initColumns() {

            string[][] columns = { 
                new string[] { "index",         "Index" },
                new string[] { "id",            "Id" },
                new string[] { "timeGenerated", "Time Generated" },
                new string[] { "type",          "Type" },
            };

            foreach (string[] name in columns){
                this.eventsView.Columns.Add(name[0], name[1]);
            }
        }

        private void initRows() {

            EventLogEntryCollection events = this.eventAdapter.getEvents();

            for(int i = 0; i < 2000; i++) {
                this.eventsView.Rows.Add(i, events[i].InstanceId, events[i].TimeGenerated, events[i].EntryType);
            }
        }

    }
}
