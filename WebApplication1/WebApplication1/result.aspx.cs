using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("您选择的答案是：");
            Response.Write("1：" + Request.Form["change1"] + " ");
            Response.Write("2：" + Request.Form["change2"] + " ");
            Response.Write("3：" + Request.Form["change3"] + " ");
            Response.Write("4：" + Request.Form["change4"] + " ");
            Response.Write("5：" + Request.Form["change5"] + " ");
        }
    }
}