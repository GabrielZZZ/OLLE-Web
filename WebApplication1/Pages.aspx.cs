using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public partial class Pages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadMainPages();

        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class PageData
        {
            public string page_title { get; set; }
            public string page_id { get; set; }
            public string page_detail { get; set; }
            public string post_username { get; set; }
            public string page_date { get; set; }
            public string imageUrl { get; set; }
            public string imageUrl2 { get; set; }
            public string imageUrl3 { get; set; }
            public string user_id { get; set; }
            public string videoUrl { get; set; }
            public string fileUrl { get; set; }
            public string profile_photo { get; set; }
            public string files_url { get; set; }
            public string page_week { get; set; }
        }

        public class Root
        {
            public List<PageData> pageData { get; set; }
        }


        private void loadMainPages()
        {
            //Fetch Form Data
            string url = Global.host_url + "getPages";

            string result = Global.PostToServer(url, "", "GET");

            JavaScriptSerializer js = new JavaScriptSerializer();

            Root myDeserializedClass = js.Deserialize<Root>(result);


            //create topics panel
            for (int i = 0; i < myDeserializedClass.pageData.Count; i++)
            {
                //UserControl1 test = new UserControl1();
                PageItem test = (PageItem)Page.LoadControl("PageItem.ascx");

                test.profile_photo = myDeserializedClass.pageData[i].profile_photo;


                test.PageTitle = myDeserializedClass.pageData[i].page_title;
                test.getWeekNum = myDeserializedClass.pageData[i].page_week;
                test.pageDetails = Global.changeCharacterBack(myDeserializedClass.pageData[i].page_detail);
                test.date = myDeserializedClass.pageData[i].page_date;
                test.files_url = myDeserializedClass.pageData[i].files_url;


                this.PageList.Controls.Add(test);
            }

        }

        protected void newTopic_Click(object sender, EventArgs e)
        {


            Response.Redirect("NewTopic.aspx?url=" + Request.CurrentExecutionFilePath + "&TopicType=" + 0 + "&PostType=" + 1);
        }

        


    }
}
