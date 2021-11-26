using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Events_Viewer
{
    public partial class EventView : Form
    {

        private EventAdapter eventAdapter = new EventAdapter();

        public EventView()
        {
            InitializeComponent();

            this.Message.Text       = this.eventAdapter.getEvents()[Form1.globalEventIndex].Message;
            this.InstanceId.Text    = this.eventAdapter.getEvents()[Form1.globalEventIndex].InstanceId.ToString();
            this.Index.Text         = Form1.globalEventIndex.ToString();
            this.Type.Text          = this.eventAdapter.getEvents()[Form1.globalEventIndex].EntryType.ToString();
            this.GeneratedTime.Text = this.eventAdapter.getEvents()[Form1.globalEventIndex].TimeGenerated.ToString();
            this.Source.Text        = this.eventAdapter.getEvents()[Form1.globalEventIndex].Source;
        }

    }
}
