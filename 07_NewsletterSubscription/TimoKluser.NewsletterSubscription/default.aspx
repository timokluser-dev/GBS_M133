<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TimoKluser.NewsletterSubscription._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h1>📨 Register for Newsletter</h1>
        </div>

        <div style="margin-top: .5rem">
            <asp:Label Text="Firstname" ID="lblFirstname" runat="server" />
            <input type="text" name="inpFirstname" id="inpFirstname" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstname" runat="server" ErrorMessage="Please enter your firstname" ControlToValidate="inpFirstname"></asp:RequiredFieldValidator>
        </div>

        <div style="margin-top: .5rem">
            <asp:Label Text="Lastname" ID="lblLastname" runat="server" />
            <input type="text" name="inpLastname" id="inpLastname" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastname" runat="server" ErrorMessage="Please enter your lastname" ControlToValidate="inpLastname"></asp:RequiredFieldValidator>
        </div>

        <div style="margin-top: .5rem">
            <asp:Label Text="E-Mail" ID="lblEmail" runat="server" />
            <input type="email" name="inpEmail" id="inpEmail" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Please enter your email" ControlToValidate="inpEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Please enter a valid email" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ControlToValidate="inpEmail"></asp:RegularExpressionValidator>
        </div>

        <div style="margin-top: .5rem">
            <asp:Label Text="Birthdate" ID="lblBirthdate" runat="server" />
            <input type="date" name="bday" id="inpBirthdate" runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidatorBirthdate" runat="server" ErrorMessage="Please enter your birthdate" ControlToValidate="inpBirthdate"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidatorBirthdate" runat="server" ErrorMessage="Please enter a valid birthdate" OnServerValidate="CustomValidatorBirthdate_ServerValidate"></asp:CustomValidator>
        </div>

        <div style="margin-top: .5rem">
            <asp:Label Text="Interests" ID="lblInterests" runat="server" />
            <asp:RadioButtonList ID="rdoInterests" runat="server">
                <asp:ListItem Text="Cross Platform  Applications" Value="crossplatform" Selected="True" />
                <asp:ListItem Text="Desktop Applications" Value="desktop" />
                <asp:ListItem Text="Web Applications" Value="web" />
                <asp:ListItem Text="Mobile Applications" Value="mobile" />
            </asp:RadioButtonList>
        </div>

        <div style="margin-top: .5rem">
            <asp:CheckBox Text="I Accept the Terms of Service" ID="cbxAcceptedTermsOfService" runat="server" />

            <asp:CustomValidator ID="CustomValidatorMustAcceptTermsOfService" runat="server" ErrorMessage="Please accept the Terms of Service" OnServerValidate="CustomValidatorMustAcceptTermsOfService_ServerValidate"></asp:CustomValidator>
        </div>

        <div style="margin-top: 2rem">
            <input type="submit" value="Register for Newsletter" />
        </div>

    </form>
</body>
</html>
