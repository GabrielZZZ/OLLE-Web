using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Reply : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string TopicAuthor
        {
            get { return author_name1.Text; }
            set { author_name1.Text = value; }

        }


        public string TopicDetails
        {
            get { return topic_details.Text; }
            set { topic_details.Text = value; }

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
    }
}