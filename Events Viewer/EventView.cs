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

            this.Message.Text = Form1.globalEvent.Message;
            this.InstanceId.Text = Form1.globalEvent.InstanceId.ToString();
            this.Index.Text = Form1.globalEventIndex.ToString();
            this.Type.Text = Form1.globalEvent.EntryType.ToString();
            this.GeneratedTime.Text = Form1.globalEvent.TimeGenerated.ToString();
            this.Source.Text = Form1.globalEvent.Source;
        }
    }
}
