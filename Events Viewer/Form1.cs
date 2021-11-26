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



namespace Events_Viewer
{
    public partial class Form1 : Form
    {
        // ага
        // 
        // if .
        private EventAdapter eventAdapter = new EventAdapter();
        public static int globalEventIndex = 0;

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

            for(int i = 0; i < columns.Length; i++){
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name         = columns[i][0];
                col.HeaderText   = columns[i][1];
                col.CellTemplate = new DataGridViewTextBoxCell();
                this.eventsView.Columns.Insert(i, col);
            }
        }


        private void initRows() {

            EventLogEntryCollection events = this.eventAdapter.getEvents();

            Button btn = new Button();

            Console.WriteLine("click");

            for (int i = this.eventAdapter.getCount() - 1; i > this.eventAdapter.getCount() - 2000; i--) {
                this.eventsView.Rows.Add(i, events[i].InstanceId, events[i].TimeGenerated, events[i].EntryType);
            }
        }

        private void eventsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != this.eventsView.Columns.Count - 1) {
                return;
            }

            int rowInd     = e.RowIndex;
            int eventIndex = int.Parse(this.eventsView.Rows[rowInd].Cells[0].Value.ToString());

            // hope this works
            globalEventIndex = eventIndex;
            EventView evtView = new EventView();
            evtView.Show();

            //MessageBox.Show(
            //    this.eventsView.Rows[rowInd].Cells[0].Value.ToString(), 
            //    "AAAAAA", 
            //    MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Information, 
            //    MessageBoxDefaultButton.Button1, 
            //    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
