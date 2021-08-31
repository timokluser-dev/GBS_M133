<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMyCookie.aspx.cs" Inherits="TimoKluser.SessionHandling.WebFormMyCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCookieValue" runat="server" />
            <asp:Button Text="Create Cookie" ID="btnCreateCookie" runat="server" OnClick="btnCreateCookie_Click" />
        </div>

        <div style="margin-top: 1rem">
            <asp:Label Text="Cookie Value: " runat="server" />
            <asp:Label Text="" ID="lblStatus" runat="server" />
        </div>
    </form>
</body>
</html>
