using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace Events_Viewer
{
    public class EventAdapter
    {

        private EventLog eventLog = new EventLog();

        public EventAdapter()
        {
            this.eventLog.Log = "System";
        }

        public EventAdapter(string type)
        {
            eventLog.Log = type;
        }

        public EventLogEntryCollection getEvents()
        {
            return this.eventLog.Entries;
        }

        public int getCount()
        {
            return this.eventLog.Entries.Count;
        }

        public void setLogType(string type)
        {
            eventLog.Log = type;
        }
    }
}
