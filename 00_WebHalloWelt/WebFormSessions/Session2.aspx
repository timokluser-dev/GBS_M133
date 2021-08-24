<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session2.aspx.cs" Inherits="WebFormSessions.Session2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Session ausgeben</title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <h2>Warenkorb </h2>
        <p>
            Artikel:
            <asp:Label id="artikel" runat="server" />
            Anzahl:
            <asp:Label id="anzahl" runat="server" />
        </p>

        <p>
            Sessionliste: <br />
            <asp:Label id="liste" runat="server" />
        </p>

        <a href="default.aspx">zurück</a>
    </div>
    </form>
</body>
</html>
