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

namespace WebApplication1
{
    public partial class SignUp : System.Web.UI.Page
    {
        List<string> src_path_total = new List<string>();
        List<string> file_path_total = new List<string>();
        string profile_photo = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //sign up button
            string name = this.TextBox1.Text;
            string surname = this.TextBox2.Text;
            string username = this.TextBox3.Text;
            string email = this.TextBox4.Text;
            string password = this.TextBox5.Text;
            string language = this.CheckBoxList1.Text;

            getFileNameAndSource();

            if ((name == "") || (surname == "") || (username == "") || (email == "") || (password == "") || (language == ""))
            {
                Response.Write("<script   language='javascript'>alert('Please fill all the fields.');</script>");
                return;
            }

            string type = "signup";
            string url = Global.host_url + type;//地址

            
            if (profile_photo == "")
            {
                Response.Write("<script   language='javascript'>alert('Please select the profile photo.');</script>");
                return;
            }
            else
            {
                TransferUploadObjectModel m = new TransferUploadObjectModel();
                m.TransferBatchUploadObjects(file_path_total, src_path_total);
            }
           

            string paramStr = "{\"username\":\"" + username + "\"," +
                                "\"name\":\"" + name + "\"," +
                                 "\"surname\":\"" + surname + "\"," +
                                  "\"email\":\"" + email + "\"," +
                                  "\"language\":\"" + language + "\"," +
                                  "\"profile_photo\":\"" + profile_photo + "\"," +
                                  "\"password\":\"" + password + "\"}";



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
                Response.Redirect("Verification.aspx?url=" + Request.CurrentExecutionFilePath);



            }

        }

        private void getFileNameAndSource()
        {
            // Retrieve the name of the file that is posted.
            string strFileName = oFile.PostedFile.FileName;
            string strFilePath = Path.GetFullPath(strFileName);
            strFileName = Path.GetFileName(strFileName);


            string file_address = "https://olle2019-1257377975.cos.ap-chengdu.myqcloud.com/" + strFileName + ";";
            profile_photo = file_address;
            src_path_total.Add(strFilePath);
        }

        
    }
}