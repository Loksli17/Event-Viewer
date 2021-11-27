using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Events_Viewer
{
    public partial class EventCreate : Form
    {
        public EventCreate()
        {
            InitializeComponent();
            initDropDown();
        }

        private void initDropDown()
        {
            List<EventType> eventTypes = new List<EventType>
            {
                new EventType { Name = "Information",   Value = (int)EventLogEntryType.Information },
                new EventType { Name = "Warning",       Value = (int)EventLogEntryType.Warning },
                new EventType { Name = "Error",         Value = (int)EventLogEntryType.Error },
                new EventType { Name = "Success Audit", Value = (int)EventLogEntryType.SuccessAudit },
                new EventType { Name = "Failure Audit", Value = (int)EventLogEntryType.FailureAudit }
            };

            var bindingSource = new BindingSource();
            bindingSource.DataSource = eventTypes;

            typeComboBox.DataSource    = bindingSource;
            typeComboBox.DisplayMember = "Name";
            typeComboBox.ValueMember   = "Value";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string source = sourceTextBox.Text;
            string message = messageTextBox.Text;
            var type = (EventType)typeComboBox.SelectedItem;

            // This should add an event
            EventAdapter.addEventLogEntry(source, message, (EventLogEntryType) type.Value);
            MessageBox.Show($"New with source: {source} was created! =)");

        }
    }
}
