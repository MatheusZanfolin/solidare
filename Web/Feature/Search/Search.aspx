<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SolidareWeb.Feature.Search.SearchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solidare</title>

    <link rel="stylesheet" type="text/css" href="../../Styles.css" />
</head>
<body>
    <form id="searchForm" runat="server">
        <div class="holder" runat="server">
            <div class="holderContent" runat="server">
                <asp:Label CssClass="title" Text="Busca" runat="server"/>

                <asp:TextBox ID="TxtSearch" Placeholder="Insira a cidade desejada" CssClass="defaultInput" runat="server" /> <br />

                <asp:Button ID="BtnSearch" CssClass="defaultButton" Text="Buscar" OnClick="BtnSearch_Click" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
