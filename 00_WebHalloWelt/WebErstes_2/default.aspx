<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Web Fromatierung</title>
	<meta charset="utf-8" />
    <%@ page Language="C#" %>

    <!-- eingebettetes Script -->
    <script runat="server">
        private void page_load()
        {
          int x, y, z;
          x = 5;
          y = 12;
          z = x + y;
          ergebnis.Text = "Ergebnis: " + z;
          ergebnis.Font.Size = 24;
          ergebnis.Font.Bold = true;
          ergebnis.Font.Underline = true;
        }
    </script>
</head>

<body>
    <!-- ASP-Control -->
    <asp:Label ID="ergebnis" runat="server" />
</body>
</html>
