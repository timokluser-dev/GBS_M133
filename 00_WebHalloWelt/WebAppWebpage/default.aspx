<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebAppWebpage._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><input type="text" id="zahl1" runat="server" /></p>   
        <p><input type="submit" value="Senden" runat="server" /></p>
        <p id="ergebnis" runat="server"></p> 
    </div>
    </form>
</body>
</html>
