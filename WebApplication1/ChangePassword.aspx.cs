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
    public partial class ChangePassword : System.Web.UI.Page
    {

        private int user_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Global.UserData userdata = Session["userData"] as Global.UserData;

            user_id = userdata.user_id;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string password0 = this.password0.Text;
            string password = this.password1.Text;
            string password1 = this.password2.Text;

            if (password != password1)
            {
                Response.Write("<script   language='javascript'>alert('Please type the same new passwords in two boxes!');</script>");

                return;
            }

            if ((password0 == "") || (password == "") || (password1 == ""))
            {
                Response.Write("<script   language='javascript'>alert('Please fill all the boxes!');</script>");

                return;
            }

            string type = "updatePassword";
            string url = Global.host_url + type;//地址

            string paramStr = "{\"oldPass\":\"" + password0 + "\"," +
                                "\"newPass\":\"" + password1 + "\"," +
                                  "\"user_id\":\"" + user_id + "\"}";



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
                Response.Write("<script   language='javascript'>alert('Change Success!');</script>");
                


            }
        }
    }
}