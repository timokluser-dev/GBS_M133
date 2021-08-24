<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormularKalender._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Web Formular Kalender</title>
</head>

<body>
    Kalender:
    <form id="form1" runat="server">
    <div>
        <!-- ASP control Calender mit Eventhandler und Eigenschaften-->
        <asp:Calendar id="kalender" runat="server"
            OnSelectionChanged ="kalender_SelectionChanged">
            <TodayDayStyle BackColor="Red" ForeColor="Yellow" />
            <WeekendDayStyle BackColor="Yellow" ForeColor="Red" />
        </asp:Calendar>
        <p>
            <!-- HTML Control CheckBox: State evaluated in PostBack on Server -->
            <input type="checkbox" id="sundayFirst" runat="server" /> Sunday first
        </p>
        <p>
            <!-- ASP-Control Checkbox: Event handled in PostBack on Server-->
            <asp:CheckBox id="tuesdayFirst" runat="server"
                OnCheckedChanged="tuesdayFirst_CheckedChanged" /> Tuesday first
        </p>
        <p>
            <!-- ASP-Control Checkbox: Event handles immediatly on Server -->
            <asp:CheckBox id="saturdayFirst" runat="server"
                OnCheckedChanged="saturdayFirst_CheckedChanged" 
                AutoPostBack="true"/> Saturday first
        </p>
    </div>
    <p>
        <input type="submit" value="Senden" runat="server" />
    </p>
    </form>

    <p>
        <asp:Label id="ausgabe" runat="server" />
    </p>
</body>
</html>
