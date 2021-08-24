<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormularElemente._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebFormularElemente</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <!-- HTML-Control ComboBox -->
            <select id="ziel" runat="server" >
                <option value="Stadt" >Land</option>
            </select>
            <p>
                <!-- HTML-Control CheckBox -->
                <input type="checkbox" id="allinc" runat="server"  /> All inclusive
                <p>
                    <!-- HTML-Control Radiobutton -->
                    <input type="radio" id="bett2" name="bett" checked="True" runat="server"  /> 2-Bett
                    <input type="radio" id="bett3" name="bett" runat="server"  /> 3-Bett
                </p>
                <p>
                    <!-- HTML-Control Button Submit -->
                    <input type="submit" value="Senden" runat="server" />
                </p>
            </p>
        </p>
        <p>
            <!-- ASP-Control Label-->
            <asp:Label id="ausgabe" runat="server"/>
        </p>
    </div>
    </form>
</body>
</html>
