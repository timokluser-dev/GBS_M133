<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="TimoKluser.NewsletterSubscription.confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>
                <h1>📨 Register for Newsletter - Confirm</h1>
            </div>

            <div>
                <p id="pConfirmText" runat="server"></p>
            </div>

            <div>
                <ul>
                    <li id="liNewsletter" runat="server"></li>
                </ul>
            </div>

            <div>
                <p id="pSaveError" runat="server"></p>
            </div>

            <div>
                <asp:Button Text="Go Back" ID="btnGoBack" OnClick="btnGoBack_Click" runat="server" />
                <asp:Button Text="Confirm Subscription" ID="btnConfirmSubscription" OnClick="btnConfirmSubscription_Click" runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
