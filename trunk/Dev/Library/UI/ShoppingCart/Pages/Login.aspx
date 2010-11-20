<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login"  MasterPageFile ="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
<form id="Form1"  action="Login.aspx" runat="server">
<asp:Table runat="server" BorderWidth="1">
<asp:TableRow>
<asp:TableCell HorizontalAlign="center">
    <asp:Label ID="lbLogin" runat="server" Text="Login" Font-Size="X-Large" ></asp:Label>
</asp:TableCell>
</asp:TableRow>
<asp:TableRow>
<asp:TableCell HorizontalAlign="center"><asp:Label ID="lbUserName" runat="server" Text="Username"></asp:Label></asp:TableCell>
<asp:TableCell HorizontalAlign="center"><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></asp:TableCell>
</asp:TableRow>
<asp:TableRow>
<asp:TableCell><asp:Label ID="lbPassword" runat="server" Text="Password"></asp:Label></asp:TableCell> 
<asp:TableCell><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell>    
</asp:TableRow>
<asp:TableRow>
<asp:TableCell ><asp:Button ID="btnOK" runat="server" Text="OK" Width="60" /></asp:TableCell>
<asp:TableCell><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="60" /></asp:TableCell>
</asp:TableRow>
</asp:Table>
</form>
</center>
</asp:Content>