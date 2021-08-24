using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebApplication1
{
    public partial class FileIcon : System.Web.UI.UserControl
    {
        private string file_name_simple = "";

        public string file_path = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Global.LTooltip(fileName, 10);

            // change file name
        }

        public void ChangeFileName(string value)
        {
            int max_length = 10; // max length - 50 characters
            file_name_simple = value;

            if (value.Length >= max_length)
            {
                fileName.Text = value.Substring(0, max_length) + "...";
            }

        }

        public string FileName
        {
            get { return fileName.Text; }
            set { fileName.Text = value; }

        }

        public void ChangeFileIconImage(string fileType)
        {
            try
            {
                switch (fileType)
                {
                    case ".docx":
                        fileImage.ImageUrl = "~/Images/word.png";
                        break;
                    case ".xlsx":
                        fileImage.ImageUrl = "~/Images/excel.png";
                        break;
                    case ".pdf":
                        fileImage.ImageUrl = "~/Images/pdf.png";
                        break;
                    case ".mp4":
                        fileImage.ImageUrl = "~/Images/video.png";
                        break;
                    case ".pptx":
                        fileImage.ImageUrl = "~/Images/PPT.png";
                        break;
                    default:
                        fileImage.ImageUrl = "~/Images/file.png";
                        break;

                }

            }
            catch (Exception ex)
            {
                //显示本地默认图片
                fileImage.ImageUrl = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/OLLE.png";
                //author_image1.Image = Image.FromFile(@"C:\Users\A\Desktop\OLLE\testImage.jpg");
            }
        }

        protected void fileImage_Click(object sender, ImageClickEventArgs e)
        {
            using (WebClient web1 = new WebClient())
                web1.DownloadFile(file_path, fileName.Text);
        }
    
    }

    

   

    

}