<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormSessions._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Session starten</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <h2>Artikel auswählen</h2>
        <h3 runat="server" id="h2SessionId"></h3>

        <p>
        Artikel:
        <asp:TextBox id="artikelName" runat="server" />
        </p>
        
        <p>
        Anzahl:
        <asp:TextBox id="artikelAnzahl" runat="server" />
        </p>
        
        <asp:Button id="Session_speichern" runat="server" Text="zum Warenkorb"  OnClick="Session_speichern_Click" />

    </div>
    </form>
</body>
</html>
