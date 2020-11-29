<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Donation.aspx.cs" Inherits="SolidareWeb.Feature.Donation.DonationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solidare</title>

    <link rel="stylesheet" type="text/css" href="../../Styles.css" />
</head>
<body>
    <form id="donationForm" runat="server">
        <div class="holder" runat="server">
            <div class="holderContent" runat="server">
                <asp:Label ID="TxtIndexTitle" CssClass="title" Text="Doação" runat="server"/> <br />

                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell> <asp:Label CssClass="label" Text="Doações aceitas:" runat="server" /> </asp:TableCell>
                        <asp:TableCell> <asp:DropDownList ID="DrpAvailableItems" CssClass="defaultInput defaultTableCell" OnSelectedIndexChanged="DrpAvailableItems_SelectedIndexChanged" runat="server" /> </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell> <asp:Label CssClass="label" Text="Qtde.:" runat="server" /> </asp:TableCell>
                        <asp:TableCell> <asp:TextBox ID="TxtQuantity" TextMode="Number" CssClass="defaultInput" runat="server" /> </asp:TableCell>
                        <asp:TableCell> <asp:Label ID="LblUnit" CssClass="label" Text="Kg." runat="server" /> </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2"> <asp:Button ID="BtnSelect" CssClass="defaultButton" Text="Selecionar" OnClick="BtnSelect_Click" runat="server" /> </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell> <asp:Label CssClass="label" Text="Total doado:" runat="server" /> </asp:TableCell>
                        <asp:TableCell> <asp:DropDownList ID="DrpSelectedItems" CssClass="defaultInput defaultTableCell" runat="server" /> </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2"> <asp:Button ID="BtnDonate" CssClass="defaultButton" Text="Concluir doação" OnClick="BtnDonate_Click" runat="server" /> </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>
            </div>
        </div>
    </form>
</body>
</html>
