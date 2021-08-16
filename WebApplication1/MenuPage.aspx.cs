using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MenuPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Forum forum = new Forum(0, "Open Learning Log");
            Response.Redirect("Forum.aspx?url=" + Request.CurrentExecutionFilePath + "&forum_index=" + 0);
        }
    }
}