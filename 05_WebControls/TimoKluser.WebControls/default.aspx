<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TimoKluser.WebControls._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>💳 Get your CreditCard today.</h1>

        <div>
            <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Oops, the following errors occured: " runat="server" DisplayMode="BulletList" Font-Bold="False" />
        </div>

        <div>
            <asp:Label ID="lblFirstname" runat="server" Text="Label">Firstname</asp:Label>
            <input id="inpFirstname" type="text" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your firstname" ControlToValidate="inpFirstname" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Label ID="lblLastname" runat="server" Text="Label">Lastname</asp:Label>
            <input id="inpLastname" type="text" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your lastname" ControlToValidate="inpLastname" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Label ID="lblAge" runat="server" Text="Label">Age</asp:Label>
            <input id="inpAge" type="number" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter your age" ControlToValidate="inpAge" Display="None"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Sorry, you must be 18 to apply for a credit card" MinimumValue="18" MaximumValue="100" Type="Integer" ControlToValidate="inpAge" Display="None"></asp:RangeValidator>
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Text="E-Mail"></asp:Label>
            <input id="inpEmail" type="email" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter your E-Mail" ControlToValidate="inpEmail" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Label ID="lblEmailConfirm" runat="server" Text="Confirm E-Mail"></asp:Label>
            <input id="inpEmailConfirm" type="email" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please confirm your E-Mail" ControlToValidate="inpEmailConfirm" Display="None"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Sorry, your E-Mails don't match" ControlToValidate="inpEmail" ControlToCompare="inpEmailConfirm" Display="None"></asp:CompareValidator>
        </div>

        <div>
            <asp:Label ID="lblAcceptedTerms" Text="I accept the terms of condition" runat="server" />
            <asp:CheckBox ID="chkAcceptedTerms" runat="server" />

            <%--custom validator has no ControlToValidate attribute--%>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Please accept the terms of condition" OnServerValidate="AcceptedTerms_Validator" Display="None"></asp:CustomValidator>
        </div>

        <div>
            <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
            <asp:ListBox ID="drpCountry" SelectionMode="Single" runat="server">
                <asp:ListItem Text="Switzerland" Value="switzerland" />
                <asp:ListItem Text="USA" Value="usa" />
                <asp:ListItem Text="Other" Value="other" />
            </asp:ListBox>

            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Sorry, we cannot provide credit cards outside of the USA & Switzerland" OnServerValidate="Country_Validator"></asp:CustomValidator>
        </div>

        <input type="submit" name="" value="Get your card!" style="margin-top: 2.5rem" />

    </form>
</body>
</html>
