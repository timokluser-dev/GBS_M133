<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Web Erstes</title>
	<meta charset="utf-8" />

    <%@ page language="C#" %>

    <!-- eingebettetes Script -->
    <script runat="server">
    
    //Eventhandler für OnPageLoad
    private void page_load()
    {
        int x, y, z;
        x = 5;
        y = 12;
        z = x + y;

        //use InnerHtml of HTML-Control: wird als HTML interpretiert
        titel.InnerHtml = "Ein <b>neuer</b> Rechner";

        //use InnerText of HTML-Control: wird nicht interpretiert
        ergebnis.InnerText = "<b>Ergebnis=</b> " + z;

        //erstelle dynamische Tabelle serverseitig
        string s = "";
        s += "<table border='1'>";
        s += "<tr> <th>" + "Wert" + "</th> <th>" + "Reihenwert" + "</th> </tr>";
        for (int i = 0; i < 10; i++)
        {
          s += "<tr> <td>" + i.ToString() + "</td> <td>" + (2 * i).ToString() + "</td> </tr>";
        }
        s += "</table>";

        reihe.InnerHtml = s;
    } 

    </script>

</head>

<body>
    <!-- HTML-Controls: HTML-elemente mit Attribut id und runat -->
    <p id="titel" runat="server">Hier kommt der Titel </p>
    <p id="ergebnis" runat="server">Hier kommt das Resultat</p>
    <a id="reihe" runat="server">Hier kommt die Reihe</a>
</body>

</html>
