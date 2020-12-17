<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="numero_secreto.aspx.cs" Inherits="Projeto0_11I.numero_secreto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tenta adivinhar o número secreto entre 1 e 10
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Adivinhar" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Jogar novamente" Visible="false" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
