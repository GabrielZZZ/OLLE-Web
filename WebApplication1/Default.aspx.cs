using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            //just for developing!!!!//////////////////
            username = "admin";
            password = "admin123";
            ///////////////////////////////////////////


            if ((username != "") && (password != ""))
            {
                string login_result = login_user_info_new(username, password);//post login data

                if (login_result.Equals("Wrong Password"))
                {
                    //MessageBox.Show("Wrong username or password. Please try again.", "Login Result");
                    Response.Write("<script   language='javascript'>alert('Wrong username or password. Please try again');</script>");
                }
                else
                {
                    //this.Hide();
                    //Forum forum = new Forum();
                    //forum.ShowDialog();

                    MenuPage menuPage = new MenuPage();
                    Response.Redirect("MenuPage.aspx?url=" + Request.CurrentExecutionFilePath);

                    //forum.Show();
                    //this.Close();
                }
            }
        }

        private string login_user_info_new(string username, string password)
        {
            string type = "login";
            string url = Global.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"username\":\"" + username + "\"," +
                                  "\"password\":\"" + password + "\"}";

            string result = Global.PostToServer(url, paramStr, "POST");



            if (result.Contains("error"))
            {
                string errorMessage = result.Substring(19);
                errorMessage = Global.Reverse(errorMessage);
                errorMessage = errorMessage.Substring(4);
                errorMessage = Global.Reverse(errorMessage);

                //errorMessage.Remove()
                //MessageBox.Show(errorMessage);
                return "Wrong Password";
            }
            {
                Global.userData = Global.TransferJson(result);

                return result;
            }



            //need to workout how to transform the data into the corresponding structs 
            //see here: https://www.jb51.net/article/48027.htm


        }

        /**
        private void Login_Load(object sender, EventArgs e)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string name = "OLLE";
            foreach (string d in Directory.GetFileSystemEntries(dirPath))
            {
                if (File.Exists(dirPath + @"\" + name))
                {
                    MessageBox.Show("创建文件夹 " + name + " 失败,文件夹已经存在");

                }
            }//end of for
            DirectoryInfo info = new DirectoryInfo(dirPath);
            info.CreateSubdirectory(name);
            //info.Parent.CreateSubdirectory(name);//可以在父目录生成文件夹，很方便

        }

        
        private void register_button_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPasswordPage = new ForgetPassword();
            forgetPasswordPage.ShowDialog();
        }
    **/
    }
}