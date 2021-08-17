<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="utf-8" />

    <%@ Page Language="C#" %>

    <!-- eingebettetes Script -->
    <script runat="server"> 
        //Eventhandler für OnPageLoad 
        private void page_load()
        {
            //code to run at page load 
            //use InnerHtml of HTML-Control: wird als HTML interpretiert 

            titel.InnerHtml = "Ein <b>neuer</b> Rechner ";
        }
    </script>
</head>

<body>
    <!-- HTML-Controls: HTML-elemente mit Attribut id und runat -->
    <p id="titel" runat="server">Hier kommt der Titel </p>
</body>
</html>
