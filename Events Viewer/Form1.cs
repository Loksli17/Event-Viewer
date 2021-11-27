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

        private EventAdapter eventAdapter  = new EventAdapter();
        public static int globalEventIndex = 0;
        private int page                   = 1;
        private int take                   = 500;
        private int lastPage                = 0;
        private int skip                   = 0;
        private bool firstRefresh          = false;

        private List<string> eventJournalNames = new List<string> {
            "System",
            "Application",
            "Security",
        };

        public Form1()
        {
            InitializeComponent();
            this.countSkip();
            this.refreshMaxPage();

            this.initColumns();
            initDropDown();
            this.eventsCount.Text = Convert.ToString(eventAdapter.getCount());
        }


        private void refreshMaxPage() {
            this.lastPage = this.eventAdapter.getCount() / this.take + 1;
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


        private void countSkip(){
            this.skip = (this.page - 1) * this.take;
        }

        private void pushRowsInGridView(EventLogEntryCollection events) {

            int start = this.eventAdapter.getCount() - 1 - this.skip;
            int end   = this.eventAdapter.getCount() - 1 - this.take - this.skip;

            if (end < 0) end = 0;

            this.StartView.Text = start.ToString();
            this.EndView.Text   = end.ToString();

            for (int i = start; i > end; i--){
                this.eventsView.Rows.Add(i, events[i].InstanceId, events[i].TimeGenerated, events[i].EntryType);
            }
        }

        private void initDropDown()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = eventJournalNames;

            EventJournalName.DataSource = bindingSource;
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
            evtView.ShowDialog(this);
            evtView.Dispose();
        }

        private void refreshRows()
        {
            if(!this.firstRefresh)
            {
                this.page = 1;
                this.countSkip();
                this.firstRefresh = true;
            }

            eventsView.Rows.Clear();
            EventLogEntryCollection events = this.eventAdapter.getEvents();
            this.pushRowsInGridView(events);
            this.eventsCount.Text = this.eventAdapter.getCount().ToString();
        }

        private void EventJournalName_SelectedIndexChanged(object sender, EventArgs e)
        {        
            eventAdapter.setLogType(eventJournalNames[EventJournalName.SelectedIndex]);
            this.page = 1;
            this.PageNum.Text = this.page.ToString();
            this.countSkip();
            this.refreshMaxPage();
            refreshRows();
        }

        private void newEventBtn_Click(object sender, EventArgs e)
        {
            EventCreate evtCreate = new EventCreate();
            evtCreate.ShowDialog(this);
            evtCreate.Dispose();

            // ! update event list here
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (this.page == 1) return;
            this.page--;
            this.PageNum.Text = this.page.ToString();
            this.countSkip();
            this.refreshRows();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (this.page == this.lastPage) return;
            this.page++;
            this.PageNum.Text = this.page.ToString();
            this.countSkip();
            this.refreshRows();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.take = (int) this.TakeView.Value;
            this.countSkip();
            this.refreshMaxPage();
            this.refreshRows();
        }


    }
}
