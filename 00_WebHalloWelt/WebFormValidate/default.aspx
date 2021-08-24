<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormValidate._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Validation</title>
</head>

<body>
    <form id="form1" runat="server">

    <h1>Eingabe Validieren mit ASP-Validator</h1>

    <asp:ValidationSummary ID="validationSummery1" HeaderText="Folgende Fehler sind aufgetreten" runat="server" 
        ForeColor="Red" />

    <p>
    <!-- Required Field -->
    Ereignis*
    <asp:TextBox id="Ereignis" runat="server" />
    <asp:RequiredFieldValidator id="requiredFieldValidator1" ControlToValidate="Ereignis"
        ErrorMessage="Bitte Eingabefeld ausfüllen" runat="server"/>
    </p>

    <p>
    <!-- Range Validator -->
    Monat: (1...12)
    <asp:TextBox ID="Monat" runat="server" />
    <asp:RangeValidator ID="rangeFalidator1" ControlToValidate="Monat"
        ErrorMessage="Bitte Zahl zwischen 1 und 12 eingeben"
        Type="Integer"
        MinimumValue="1"
        MaximumValue="12"
        runat="server" />
    </p>

    <p>
    Passwort 1*
    <asp:TextBox ID="Passwort1" Textmode="Password" runat="server" /> 
    <asp:RequiredFieldValidator id="requiredFieldValidator2" ControlToValidate="Passwort1"
        ErrorMessage="Bitte Passwort 1 ausfüllen" runat="server"/>
    <br />
    Passwort 2*
    <asp:TextBox ID="Passwort2" Textmode="Password" runat="server" />
    <asp:RequiredFieldValidator id="requiredFieldValidator3" ControlToValidate="Passwort2"
        ErrorMessage="Bitte Passwort 2 ausfüllen" runat="server"/>

    <!-- Compare Validator -->
    <asp:CompareValidator ID="compareValidator1" ControlToValidate="Passwort2" ControlToCompare="Passwort1" 
        ErrorMessage="Passwort1 und Passwort2 stimmen nicht überein" 
        runat="server"/>
    </p>

    <p>
    <!-- Regex Validator -->
    ArtikelNr (00000.0)
    <asp:TextBox id="ArtikelNr" runat="server" />
    <asp:RegularExpressionValidator id="regexValidator1" ControlToValidate="ArtikelNr"
        ValidationExpression="\d{5}\.\d"
        ErrorMessage="Bitte Artikelnummer in korrektem Format ausfüllen" runat="server"/>
    </p>

    <p>
    <!-- Custom Validator -->
    Lagerfach (muss geradezahlig sein)
    <asp:TextBox id="Lagerfach" runat="server" />
    <asp:CustomValidator id="customValidator1" ControlToValidate="Lagerfach"
        OnServerValidate="customValidator1_ServerValidate"
        ErrorMessage="Lagerfach muss geradezahlig sein" runat="server"/>
    </p>
        
     <input type="submit" value="Senden" onserverclick="Versand" runat="server" />
     
    </form>

     <p ID="Resultat" runat="server" > </p>

</body>
</html>
