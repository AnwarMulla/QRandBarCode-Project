<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BarandQRCode.aspx.cs" Inherits="QRandBarCode_Project.BarandQRCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            QRCode Print:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create BarCode" /><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create QrCode" />
            <br />
            <br />
            <asp:Image ID="Image1" Width="25%" Height="80px" BorderWidth="0" runat="server" />
            <br />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
