using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Events_Viewer
{
    public partial class Form1 : Form
    {

        private EventAdapter eventAdapter = new EventAdapter();

        public Form1()
        {
            InitializeComponent();

            this.eventsCount.Text = Convert.ToString(eventAdapter.getCount());
        }
    }
}
