using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(IsPostBack)
            {
                return;
            }

            HttpCookie cookie = Request.Cookies["use"];
            if(cookie != null)
            {
                TextBox1.Text = cookie.Values.Get("usename");
            }
        }
        protected void loginevent(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("use");
            cookie.Values.Add("usename",TextBox1.Text);
            cookie.Values.Add("password", TextBox2.Text);
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            Response.Redirect("loginindex.aspx");
        }
    }
}