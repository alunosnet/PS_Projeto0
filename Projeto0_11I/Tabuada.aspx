<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="Projeto0_11I.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Qual a tabuada?<asp:TextBox id="tb" runat="server" /><br />
            <asp:Button ID="Button1" runat="server" Text="Tabuada" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" />
        </div>
    </form>
</body>
</html>
