<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="work.aspx.cs" Inherits="WebApplication1.work" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" action="result.aspx" runat="server" method="post">

        <p>1、不允许作为类及类成员的访问控制符的是(  ).</p>        
        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="change1" value="A" />A)public
        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="change1" value="B" />B)private
        <asp:RadioButton ID="RadioButton7" runat="server" GroupName="change1" value="C" />C)static
        <asp:RadioButton ID="RadioButton8" runat="server" GroupName="change1" value="D" />D)protected<br />

        <p>2、下列语句序列执行后，k 的值是(  ).</p>
        <p>int m=3, n=6, k=0;</p>
        <p>while( (m++) < ( - - n) ) ++k;</p>
        <asp:RadioButton ID="RadioButton9" runat="server" GroupName="change2" value="A" />A)0
        <asp:RadioButton ID="RadioButton10" runat="server" GroupName="change2" value="B" />B)1
        <asp:RadioButton ID="RadioButton11" runat="server" GroupName="change2" value="C" />C)2
        <asp:RadioButton ID="RadioButton12" runat="server" GroupName="change2" value="D" />D)3<br />


        <p>3、设有定义 int i = 6 ;，则执行以下语句后，i 的值为(   ).</p>
        <p>i += i - 1;</p>
        <asp:RadioButton ID="RadioButton13" runat="server" GroupName="change3" value="A" />A)10
        <asp:RadioButton ID="RadioButton14" runat="server" GroupName="change3" value="B" />B)121
        <asp:RadioButton ID="RadioButton15" runat="server" GroupName="change3" value="C" />C)11
        <asp:RadioButton ID="RadioButton16" runat="server" GroupName="change3" value="D" />D)100<br />

        <p>4、下列选项中，用于在定义子类时声明父类名的关键字是(   ).</p>
        <asp:RadioButton ID="RadioButton17" runat="server" GroupName="change4" value="A" />A)interface     
        <asp:RadioButton ID="RadioButton18" runat="server" GroupName="change4" value="B" />B)package     
        <asp:RadioButton ID="RadioButton19" runat="server" GroupName="change4" value="C" />C)extends     
        <asp:RadioButton ID="RadioButton20" runat="server" GroupName="change4" value="D" />D)class<br />

        <p>5、下列语句序列执行后，i的值是(  ).</p>
        <p>int i = 8,j = 16;</p>
        <p>if(i - 1 > j) i--; else j--</p>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="change5" value="A" />A)15
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="change5" value="B" />B)16
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="change5" value="C" />C)7
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="change5" value="D" />D)8<br />
        <input type="submit"  value="提交" /><br />       
    </form>
</body>
</html>
