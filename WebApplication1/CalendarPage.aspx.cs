using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public partial class CalendarPage : System.Web.UI.Page
    {
        Root myDeserializedClass;

        protected void Page_Load(object sender, EventArgs e)
        {
            Global.UserData userdata = Session["userData"] as Global.UserData;

            if (userdata.user_account_status != "admin")
            {
                Button1.Visible = false;
            }

            loadCalendarEvents();

            this.eventPanel.Controls.Clear();
            // get the current date
            DateTime selected_time = monthCalendar1.TodaysDate.Date;

            getCalendarEvents(selected_time);
        }

        public class FData
        {
            public string event_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string startTime { get; set; }
            public string endTime { get; set; }
        }

        public class Root
        {
            public List<FData> fData { get; set; }
        }


        private void loadCalendarEvents()
        {
            //Fetch Form Data
            string url = Global.host_url + "getCalendarEvents";

            string result = Global.PostToServer(url, "", "POST");

            JavaScriptSerializer js = new JavaScriptSerializer();


            myDeserializedClass = js.Deserialize<Root>(result);



        }


        private void getCalendarEvents(DateTime selected_time)
        {


            int count = 0;

            //create topics panel
            for (int i = 0; i < myDeserializedClass.fData.Count; i++)
            {
                //UserControl1 test = new UserControl1();
                CalendarEvent test = (CalendarEvent)Page.LoadControl("CalendarEvent.ascx");
                
                //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);


                test.EventTitle = myDeserializedClass.fData[i].title;

                DateTime dt_start, dt_end;



                DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();

                dtFormat.ShortDatePattern = "yyyy/MM/dd hh:mm:ss";

                string test1 = myDeserializedClass.fData[i].startTime;



                dt_start = Convert.ToDateTime(myDeserializedClass.fData[i].startTime, dtFormat);
                //dt_start = DateTime.ParseExact(test1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                dt_end = Convert.ToDateTime(myDeserializedClass.fData[i].endTime, dtFormat);

                TimeSpan time_remaining = dt_end - dt_start;
                double total_hours = time_remaining.TotalHours;

                test.EventStartTime = dt_start.ToLongDateString() + " " + dt_start.ToShortTimeString();
                test.EventEndTime = dt_end.ToLongDateString() + " " + dt_end.ToShortTimeString();

                test.EventTime = total_hours.ToString() + " hours";

                if (dt_end > selected_time && dt_start.Date <= selected_time)
                {
                    count++;
                    this.eventPanel.Controls.Add(test);
                }

            }

            if (count == 0)
            {
                Label label1 = new Label();
                label1.Text = "No tasks today! Cheers!";
                //label1.Font = new Font("Arial", 10, FontStyle.Italic);
                //label1.AutoSize = true;
                this.eventPanel.Controls.Add(label1);

            }

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            loadCalendarEvents();
        }

        protected void monthCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            // clear the panel first
            this.eventPanel.Controls.Clear();
            // get the current date
            DateTime selected_time = monthCalendar1.SelectedDate.Date;

            getCalendarEvents(selected_time);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CalendarCreate.aspx?url=" + Request.CurrentExecutionFilePath);

        }



    }
}