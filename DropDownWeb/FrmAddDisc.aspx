<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAddDisc.aspx.cs" Inherits="DropDownWeb.FrmAddDisc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtId" Enabled="true" Text="Automatic" runat="server"></asp:TextBox>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DdlGenre" runat="server"></asp:DropDownList>
            <asp:Button ID="BtnAdd" OnClick="BtnAdd_Click" runat="server" Text="Add" />
        </div>
    </form>
</body>
</html>
