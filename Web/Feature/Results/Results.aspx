<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="SolidareWeb.Feature.Results.ResultsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solidare</title>

    <link rel="stylesheet" type="text/css" href="../../Styles.css" />
</head>
<body>
    <form id="resultsForm" runat="server">
        <div class="holder" runat="server">
            <div class="holderContent" runat="server">
                <asp:Label CssClass="title" Text="Resultados" runat="server"/> <br />

                <asp:DropDownList ID="DrpResults" CssClass="defaultInput" OnSelectedIndexChanged="DrpResults_SelectedIndexChanged" runat="server" /> <br />

                <asp:Button ID="BtnDonate" CssClass="defaultButton" Text="Doar" OnClick="BtnDonate_Click" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
