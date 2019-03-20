<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Exam.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        账号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        密码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="loginevent" Text="提交" />
    </form>
    
</body>
</html>
