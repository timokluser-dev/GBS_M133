<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormCoockies._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cookie setzen</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>

    <p>
    Cookiewert 
    <asp:TextBox id="TBCookie" runat="server"></asp:TextBox> 
    </p>

    <p>
    Ablauf in xxx Tagen 
    <asp:TextBox id="TBAblauf" runat="server"></asp:TextBox>
    </p>

    <p>
    user 
    <asp:TextBox id="User" runat="server"></asp:TextBox> 
    </p>

    <p>
    Passwort 
    <asp:TextBox id="Passwort" textmode="Password" runat="server"></asp:TextBox>
    </p>

    <asp:Button id="Cookie_setzen" runat="server" Text="Cookies setzen"  OnClick="Cookie_setzen_Click" />
        
    </div>
    </form>
</body>
</html>
