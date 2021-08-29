using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CalendarEvent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string EventTitle
        {
            get { return event_name.Text; }
            set { event_name.Text = value; }

        }

        public string EventTime
        {
            get { return remaining_time.Text; }
            set { remaining_time.Text = value; }

        }

        public string EventStartTime
        {
            get { return start_time.Text; }
            set { start_time.Text = value; }

        }

        public string EventEndTime
        {
            get { return end_time.Text; }
            set { end_time.Text = value; }

        }
    }
}