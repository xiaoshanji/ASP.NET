using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("将要跳转到indexjump.aspx页面");
            //Server.Transfer("indexjump.aspx");

            Response.Redirect("indexjump.aspx");
        }
    }
}