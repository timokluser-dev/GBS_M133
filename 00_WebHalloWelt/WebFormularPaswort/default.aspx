<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormularPaswort._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Passwort Formular</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Anmelden</h1>
        <p> 
            Benutzer: <input type="text" id="user" runat="server" />
        </p>
        <p> 
            Passwort: <input type="password" id="password" runat="server" />
            <asp:Checkbox ID="show" runat="server" AutoPostBack="true" OnCheckedChanged="show_CheckedChanged" /> "Zeige Passwort  "
            <asp:Label ID="hint" runat="server"></asp:Label>
         </p>
    </div>
    <input type="submit" value="Send" runat="server" />
    </form>



    <p id ="anmeldung" runat="server"> </p>

</body>
</html>
