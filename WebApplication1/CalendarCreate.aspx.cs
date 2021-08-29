using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CalendarCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string title = title_box.Text;
            string description = description_box.Text;

            DateTime startDate = DateTime.Parse(start_time_picker.Text);


            DateTime endDate = DateTime.Parse(end_time_picker.Text);


            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            //string startTime = startDate.ToString("yyyy-MM-dd");
            string startTime = startDate.ToString("yyyy-MM-dd") + " " + startDate.ToLongTimeString();

            string endTime = endDate.ToString("yyyy-MM-dd") + " " + endDate.ToLongTimeString();



            string type = "storeCalendarEvent";
            string url = Global.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"title\":\"" + title + "\"," +
                                "\"startTime\":\"" + startTime + "\"," +
                                "\"endTime\":\"" + endTime + "\"," +
                                  "\"description\":\"" + description + "\"}";

            string result = Global.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Global.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Global.Reverse(errorMessage);

                //errorMessage.Remove()
                //MessageBox.Show(errorMessage);
                return;
            }
            {
                //Program.userData = Program.TransferJson(result);

                Response.Write("<script   language='javascript'>alert('Publish Success!');</script>");


                return;
            }
        }
    }
}