using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class loginindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["use"];
            if(cookie != null)
            {
                Response.Write("账号：" +cookie.Values.Get("usename") + "<br />");
                Response.Write("密码：" + cookie.Values.Get("password") + "<br />");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}