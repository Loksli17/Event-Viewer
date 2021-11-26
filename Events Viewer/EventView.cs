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

            this.Message.Text = this.eventAdapter.getEvents()[Form1.globalEventIndex].Message;
        }

    }
}
