<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SolidareWeb.Feature.Login.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solidare</title>

    <link rel="stylesheet" type="text/css" href="../../Styles.css" />
</head>
<body>
    <form id="indexForm" runat="server">
        <div class="holder" runat="server">
            <div class="holderContent" runat="server">
                <asp:Label CssClass="title" Text="Solidare" runat="server"/>

                <asp:TextBox ID="TxtUser" Placeholder="Usuário" CssClass="defaultInput" runat="server" /> <br />
                <asp:TextBox ID="TxtPassword" Placeholder="Senha" CssClass="defaultInput" runat="server" /> <br />

                <asp:Button ID="BtnLogin" CssClass="defaultButton" Text="Login" OnClick="BtnLogin_Click" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
