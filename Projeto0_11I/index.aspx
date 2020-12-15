<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projeto0_11I.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nº:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Nº:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Nº<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button OnClick="Button1_Click" ID="Button1" runat="server" Text="Maior" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <!--Isto é um comentário -->
        </div>
    </form>
</body>
</html>
