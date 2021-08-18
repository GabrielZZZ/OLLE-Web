using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public partial class TopicDetailsPage : System.Web.UI.Page
    {

        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();
        string[] files_url_split;
        public int topic_id;

        public string rtf_file_url;

        public bool pageOrNot = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            //change author image
            try
            {
                author_image1.ImageUrl = Request.QueryString["AuthorImage"];

            }
            catch (Exception ex)
            {
                //显示本地默认图片
                author_image1.ImageUrl = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/OLLE.png";
                //author_image1.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }

            author_name1.Text = Request.QueryString["AuthorName"];

            topic_date1.Text = Request.QueryString["Date"];

            topic_date1.Text = Request.QueryString["Date"];
            topic_title1.Text = Request.QueryString["Topic_Title"];
            topic_details.Text = Session["TopicDetail"].ToString();

            Session["TopicDetail"] = null;//release Session


            getPostedReply();


        }

        public class PostedReplyData
        {
            public string post_id { get; set; }
            public string topic_id { get; set; }
            public string username { get; set; }
            public string user_post { get; set; }
            public string post_date { get; set; }
            public string parent_id { get; set; }
            public string language { get; set; }
            public string profile_photo { get; set; }
            public string top { get; set; }
        }

        public class Root
        {
            public List<PostedReplyData> PostedReplyData { get; set; }
        }

        private void getPostedReply()
        {
            string parent_id = "0";
            //get replies
            string type = "getPostedReply";
            string url = Global.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"parent_id\":\"" + parent_id + "\"," +
                                  "\"topic_id\":\"" + topic_id + "\"}";

            string result = Global.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Global.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Global.Reverse(errorMessage);

                //errorMessage.Remove()
                
                Response.Write("<script   language='javascript'>alert(errorMessage);</script>");
                return;
            }
            else
            {
                if (result != "{\"PostedReplyData\": \"\"}")
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();

                    Root myDeserializedClass = js.Deserialize<Root>(result);

                    if (myDeserializedClass != null)
                    {
                        //create topics panel
                        for (int i = 0; i < myDeserializedClass.PostedReplyData.Count; i++)
                        {
                            //UserControl1 test = new UserControl1();
                            
                            Reply test = (Reply)Page.LoadControl("Reply.ascx");
                            //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);
                            test.ChangeAuthorImage(myDeserializedClass.PostedReplyData[i].profile_photo);
                            test.TopicAuthor = myDeserializedClass.PostedReplyData[i].username;

                            test.TopicDetails = myDeserializedClass.PostedReplyData[i].user_post;
                            test.TopicDate = myDeserializedClass.PostedReplyData[i].post_date;

                            this.reply_place.Controls.Add(test);
                        }
                    }
                }
                else
                {
                    Label label1 = new Label();
                    label1.Text = "There is nothing here";
                    //label1.AutoSize = true;
                    this.reply_place.Controls.Add(label1);
                }


                return;
            }
        } 
    }
}