<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Soma.aspx.cs" Inherits="Projeto0_11I.Soma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Página para somar dois números inteiros-->
            Nº<asp:TextBox ID="Tb1" runat="server" /><br />
            Nº<asp:TextBox ID="Tb2" runat="server" /><br />
            <asp:Button OnClick="Button1_Click" ID="Button1" runat="server" Text="Somar" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
