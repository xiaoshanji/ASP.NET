using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Exam
{
    public partial class examindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/App_Data/ExamFile.txt");
            string[] examstrs = File.ReadAllLines(path);
            for(int i = 0;i < examstrs.Length; i++)
            {
                string result = "";
                int str1 = examstrs[i].IndexOf("A");
                int str2 = examstrs[i].IndexOf("B");
                int str3 = examstrs[i].IndexOf("C");
                int str4 = examstrs[i].IndexOf("D");
                if (examstrs[i].Contains("A"))
                {
                    result += "<asp:RadioButton ID='RadioButton" + i + "' runat='server' GroupName='change" + i + "' value='A' />";
                    result += examstrs[i].Substring(str1,str2 - str1);
                }
                if (examstrs[i].Contains("B"))
                {
                    result += "<asp:RadioButton ID='RadioButton" + i + "' runat='server' GroupName='change" + i + "' value='B' />";
                    result += examstrs[i].Substring(str2, str3 - str2);
                }
                if (examstrs[i].Contains("C"))
                {
                    result += "<asp:RadioButton ID='RadioButton" + i + "' runat='server' GroupName='change" + i + "' value='C' />";
                    result += examstrs[i].Substring(str3, str4 - str3);
                }
                if (examstrs[i].Contains("D"))
                {
                    result += "<asp:RadioButton ID='RadioButton" + i + "' runat='server' GroupName='change" + i + "' value='D' />";
                    result += examstrs[i].Substring(str4);
                }
                if(!result.Equals(""))
                {
                    Response.Write(result + "< br />");
                }
                else
                {
                    Response.Write(examstrs[i] + "< br />");
                }
            }     
        }
    }
}