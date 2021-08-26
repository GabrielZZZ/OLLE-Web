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

namespace WebApplication1
{
    public partial class Verification : System.Web.UI.Page
    {
        public string email = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string verify_code = this.TextBox1.Text;

            string type = "verifyAccount";
            string url = Global.host_url + type;//地址

            //string paramStr = "{\"username\":\"admin\"," + "\"password\":\"admin123\"}";

            string paramStr = "{\"valCode\":\"" + verify_code + "\"," +
                                  "\"email\":\"" + email + "\"}";

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
                // sign up successfully, the verification email has sent
                Response.Write("<script   language='javascript'>alert('Verification Success!');</script>");

                Response.Redirect("Default.aspx?url=" + Request.CurrentExecutionFilePath);


            }
        }
    }
}