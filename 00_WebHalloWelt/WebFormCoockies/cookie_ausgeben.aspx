<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie_ausgeben.aspx.cs" Inherits="WebFormCoockies.cookie_ausgeben" validateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cookie auslesen</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        MyCookie1 <br />
        <asp:Label ID="Ausgabe1" runat="server" />
        <br /><br />

        MyCookie2 <br />
        <asp:Label ID="Ausgabe2" runat="server" />
        <br /><br />

        MyCookie3 <br />
        <asp:Label ID="Ausgabe3" runat="server" />
        <br /><br />

        MyCookie4 <br />
        <asp:Label ID="Ausgabe4" runat="server" />
        <br /><br />

    </div>
    </form>
</body>
</html>
