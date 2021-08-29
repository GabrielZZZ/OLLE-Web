using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Topic : System.Web.UI.UserControl
    {
        public string files_url = "";
        public int topic_id;
        public int topic_type;
        public string rtf_file_url = "";

        private string topic_details_simple = "";//if the detail is too large, replace the rest with ...

        public string TopicAuthor
        {
            get { return author_name1.Text; }
            set { author_name1.Text = value; }

        }

        public string TopicTitle
        {
            get { return topic_title1.Text; }
            set { topic_title1.Text = value; }

        }

        public string TopicDetails
        {
            get { return topic_details.Text; }
            set { topic_details.Text = value; }

        }

        public void ChangeTopicDetails(string value)
        {
            int max_length = 150; // max length - 50 characters
            topic_details_simple = value;

            if (value.Length >= max_length)
            {
                topic_details.Text = value.Substring(0, max_length) + "...";
            }

        }

        public string TopicDate
        {
            get { return topic_date1.Text; }
            set { topic_date1.Text = value; }

        }



        //change pictureBox picture
        public void ChangeAuthorImage(string url)
        {
            try
            {
                author_image1.ImageUrl = url;
                
            }
            catch (Exception ex)
            {
                //显示本地默认图片
                author_image1.ImageUrl = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/OLLE.png";
                //author_image1.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }


        
        protected void view_details_Click(object sender, EventArgs e)
        {
            Session["TopicDetail"] = Global.changeCharacterBack(topic_details_simple);
            Response.Redirect("TopicDetailsPage.aspx?url=" + Request.CurrentExecutionFilePath + "&pageOrNot=" + 0 + "&AuthorImage=" + author_image1.ImageUrl + "&files_url=" + files_url +  "&AuthorName=" + author_name1.Text + "&Date=" + topic_date1.Text + "&Topic_Title=" + topic_title1.Text + "&TopicID=" + topic_id + "&RTF_URL=" + rtf_file_url);
            /**
            TopicDetailsPage Detail_page = new TopicDetailsPage();

            //pass image to TopicDetailPage
            Detail_page.AuthorImage = author_image1.Image;

            //pass author name to TopicDetailPage
            Detail_page.TopicAuthor = author_name1.Text;

            //pass topic title to TopicDetailPage
            Detail_page.TopicTitle = topic_title1.Text;

            //pass topic details to TopicDetailPage
            Detail_page.TopicDetails = Program.changeCharacterBack(topic_details.Text);

            //pass topic date to TopicDetailPage
            Detail_page.TopicDate = topic_date1.Text;

            //pass topic id
            Detail_page.topic_id = topic_id;

            //add file panel
            Detail_page.AddFilePanel(files_url);

            //pass rtf_file_name
            Detail_page.rtf_file_url = rtf_file_url;

          

            //show TopicDetailPage
            Detail_page.ShowDialog();
    **/
        }
    

    }
}