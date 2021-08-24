<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Web Formular</title>
	<meta charset="utf-8" />
    <%@ page Language="C#" %>

    <!-- eingebettetes Script -->
    <script runat="server">
        private void page_load()
        {
          double z1, z2, z;
          if (IsPostBack)
          {
            try { z1 = Convert.ToDouble(zahl1.Value);}
            catch { z1 = 0;}
            try { z2 = Convert.ToDouble(zahl2.Value);}
            catch { z2 = 0;}
            z = z1 + z2;
            ergebnis.Text = "Ergebnis = " + z;
          }
        }
    </script>
</head>

<body>
    <p>Addieren</p>
    <form runat="server">
        <!-- HTML-Formularelemente -->
        <p><input type="text" id="zahl1" runat="server" /></p>
        <p><input type="text" id="zahl2" runat="server" /></p>
        <p><input type="submit" value="Senden" runat="server" /></p>
    </form>

    <!-- ASP-Control -->
    <p><asp:Label id="ergebnis" runat="server" /></p>
</body>
</html>
