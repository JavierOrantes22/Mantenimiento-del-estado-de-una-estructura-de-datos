<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstructuraDatos.aspx.cs" Inherits="EstructuraDatos6370812.EstructuraDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="USE CATEGORY ARRAY"></asp:Label>
        </div>
        <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnLookup" runat="server" OnClick="btnLookup_Click" Text="Lookup" />
            <asp:Label ID="lblCategory" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
