using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Global.UserData userdata = Session["userData"] as Global.UserData;

            profile_photo.ImageUrl = userdata.profile_photo;

            username.Text = userdata.username;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx?url=" + Request.CurrentExecutionFilePath);

        }
    }
}