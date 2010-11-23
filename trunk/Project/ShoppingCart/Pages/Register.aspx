<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Register"  MasterPageFile="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server" action="Register.aspx"  >
<asp:Panel runat="server" Height="200" Width="500"><center><h1 >Register</h1></center>
   <center><asp:Table runat="server">
   <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="120" Font-Size="11">
       <asp:Label ID="lbUsername" runat="server" Text="Username" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="100">
       <asp:TextBox ID="txtUsername" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbPassword" runat="server" Text="Password"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtPassword" runat="server" TextMode="password" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbFullname" runat="server" Text="Fullname"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtFullname" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbGender" runat="server" Text="Gender"></asp:Label>
   </asp:TableCell>
   <asp:TableCell HorizontalAlign="left">
       <asp:DropDownList ID="ddlGender" runat="server" Width="80" >
       <asp:ListItem>Male</asp:ListItem>
       <asp:ListItem>Female</asp:ListItem>
       <asp:ListItem>Unidentified</asp:ListItem>
       </asp:DropDownList>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbAddress" runat="server" Text="Address"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtEmail" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbPhone" runat="server" Text="Phone Number"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtPhone" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell>
       <asp:Button ID="btnOK" runat="server" Text="OK" Width="60" />
   </asp:TableCell>
   <asp:TableCell>
       <asp:Button ID="btnReset" runat="server" Text="Reset" Width="60" />
   </asp:TableCell>
   <asp:TableCell>
       <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="60" />
   </asp:TableCell>
   </asp:TableRow>
   </asp:Table> 
   </center>
    </asp:Panel>
</form>
</asp:Content>