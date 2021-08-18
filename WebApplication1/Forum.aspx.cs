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
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace WebApplication1
{
    public partial class Forum : System.Web.UI.Page
    {
        private int forum_index; // the number decides the category of the forum -> refer to the item in the menu page

        

        protected void Page_Load(object sender, EventArgs e)
        {
            forum_index = int.Parse(Request.QueryString["forum_index"]);

            Label1.Text = Request.QueryString["label_name"]; // mark which category the forum shows, e.g. announcements, troubleshoot, etc.

            Global.UserData userdata = Session["userData"] as Global.UserData;

            if (userdata.user_account_status != "admin")
            {
                NewTopic.Visible = false;
            }


            loadNormalEvent();
        }

        public class Root
        {
            public List<TopicsData> TopicsData { get; set; }
        }



        public class TopicsData
        {
            //store the information that the server returns after successful login


            public int topic_type { get; set; }
            public int topic_id { get; set; }
            public string topic_title { get; set; }
            public string topic_detail { get; set; }
            public int topic_week { get; set; }
            public string topic_date { get; set; }
            public string post_username { get; set; }
            public int user_id { get; set; }
            public string imageUrl { get; set; }
            public string videoUrl { get; set; }
            public string fileUrl { get; set; }
            public int topic_tag { get; set; }
            public string profile_photo { get; set; }
            public string files_url { get; set; }
            public string rtf_file_url { get; set; }
        };

        /**
        private void newTopic_Click(object sender, EventArgs e)
        {
            newTopic new_topic = new newTopic(forum_index);
            DialogResult result = MessageBox.Show("Is it a NAA Topic?", "NAA Topic Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                new_topic.topic_tag = 1;
            }
            else
            {

                new_topic.topic_tag = 0;
            }


            new_topic.ShowDialog();
        }

        private void NAAenable_CheckedChanged(object sender, EventArgs e)
        {
            if (NAAenable.Checked == true)
            {
                loadNAAEvent();
            }
            else if (NAAenable.Checked == false)
            {
                this.flowLayoutPanel1.Controls.Clear();
                loadNormalEvent();

            }
        }
        **/

        private void loadNormalEvent()
        {
            //Fetch Form Data
            string url = Global.host_url + "getTopics";

            string paramStr = "{\"topic_type\":\"" + forum_index + "\"}";

            string result = Global.PostToServer(url, paramStr, "POST");

            //MessageBox.Show(result, "Result");

            //transfer json data to object
            //Very Useful Website!!!: https://json2csharp.com/

            if (result != "{\"TopicsData\": \"\"}") // this means there are topics in the category
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                Root myDeserializedClass = js.Deserialize<Root>(result);

                //prepare to download RTF files to local
                TransferUploadObjectModel m = new TransferUploadObjectModel();
                string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\OLLE\\";

                // store the information into session
                //Session["topic_lists"] = myDeserializedClass.TopicsData;

                //create topics panel
                for (int i = 0; i < myDeserializedClass.TopicsData.Count; i++)
                {

                    Topic test = (Topic)Page.LoadControl("Topic.ascx");


                    //UserControl1 test = new UserControl1();
                    //Topic test = new Topic();
                    //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);
                    test.topic_id = myDeserializedClass.TopicsData[i].topic_id;
                    test.ChangeAuthorImage(myDeserializedClass.TopicsData[i].profile_photo);
                    test.TopicAuthor = myDeserializedClass.TopicsData[i].post_username;
                    test.TopicTitle = myDeserializedClass.TopicsData[i].topic_title;
                    test.ChangeTopicDetails(Global.changeCharacterBack(myDeserializedClass.TopicsData[i].topic_detail));
                    //test.TopicDetails = Global.changeCharacterBack(myDeserializedClass.TopicsData[i].topic_detail);
                    test.TopicDate = myDeserializedClass.TopicsData[i].topic_date;
                    test.files_url = myDeserializedClass.TopicsData[i].files_url;
                    test.rtf_file_url = str + Path.GetFileName(myDeserializedClass.TopicsData[i].rtf_file_url);

                    if (myDeserializedClass.TopicsData[i].rtf_file_url != null)
                    {
                        m.downloadFile(myDeserializedClass.TopicsData[i].rtf_file_url, str);
                        this.ph1.Controls.Add(test);
                        
                    }

                }
            }

        }

        private void loadNAAEvent()
        {
            //Fetch Form Data
            string url = Global.host_url + "getNaaTopics";
            string paramStr = "{\"topic_type\":\"" + forum_index + "\"}";

            string result = Global.PostToServer(url, paramStr, "POST");

            //MessageBox.Show(result, "Result");

            //transfer json data to object
            //Very Useful Website!!!: https://json2csharp.com/

            if (result != "{\"TopicsData\": \"\"}") // this means there are topics in the category
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                Root myDeserializedClass = js.Deserialize<Root>(result);

                //prepare to download RTF files to local
                TransferUploadObjectModel m = new TransferUploadObjectModel();
                string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\OLLE\\";

                //create topics panel
                for (int i = 0; i < myDeserializedClass.TopicsData.Count; i++)
                {
                    //UserControl1 test = new UserControl1();
                    Topic test1 = (Topic)Page.LoadControl("Topic.ascx");
                    test1.topic_type = myDeserializedClass.TopicsData[i].topic_type;
                    //test.AuthorImage = Image.FromStream(myDeserializedClass.TopicsData[i].imageUrl);
                    test1.ChangeAuthorImage(myDeserializedClass.TopicsData[i].profile_photo);
                    test1.TopicAuthor = myDeserializedClass.TopicsData[i].post_username;
                    test1.TopicTitle = myDeserializedClass.TopicsData[i].topic_title;
                    test1.ChangeTopicDetails(Global.changeCharacterBack(myDeserializedClass.TopicsData[i].topic_detail));
                    test1.TopicDate = myDeserializedClass.TopicsData[i].topic_date;
                    test1.topic_id = myDeserializedClass.TopicsData[i].topic_id;
                    test1.rtf_file_url = str + Path.GetFileName(myDeserializedClass.TopicsData[i].rtf_file_url);

                    if (myDeserializedClass.TopicsData[i].rtf_file_url != null)
                    {
                        m.downloadFile(myDeserializedClass.TopicsData[i].rtf_file_url, str);
                        this.ph1.Controls.Add(test1);
                    }

                    this.ph1.Controls.Add(test1);
                }
            }
        }


        
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ph1.Controls.Clear();
            if (NAAenable.Checked == true)
            {
                loadNAAEvent();
            }
            else
            {
                loadNormalEvent();

            }
        }
        


        protected void Refresh_Click(object sender, EventArgs e)
        {
            this.ph1.Controls.Clear();
            if (NAAenable.Checked == true)
            {
                loadNAAEvent();
            }
            else
            {
                loadNormalEvent();

            }
        }
    }
}