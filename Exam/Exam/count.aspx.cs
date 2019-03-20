using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam
{
    public partial class count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            if(Application["count"] == null)
            {
                Application["count"] = 1;
            }
            else
            {
                Application["count"] = Convert.ToInt32(Application["count"]) + 1;
            }
            Application.UnLock();
            Response.Write("你是第" + Application["count"] + "位访客");
        }
    }
}