using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public partial class PageItem : System.Web.UI.UserControl
    {
        public string files_url = "";

        public string pageDetails = "";
        public string date = "";

        public string profile_photo = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string PageTitle
        {
            get { return mainPageTitle.Text; }
            set { mainPageTitle.Text = value; }
        }

        public string getWeekNum
        {
            get { return weekNum.Text; }
            set { weekNum.Text = value; }
        }


        
        protected void detail_Click(object sender, EventArgs e)
        {
            Session["TopicDetail"] = Global.changeCharacterBack(pageDetails);
            Response.Redirect("TopicDetailsPage.aspx?url=" + Request.CurrentExecutionFilePath + "&pageOrNot=" + 1 + "&files_url=" + files_url + "&WeekNum=" +  weekNum + "&AuthorImage=" + profile_photo + "&Date=" + date + "&Topic_Title=" + mainPageTitle.Text);

        }
    }
}