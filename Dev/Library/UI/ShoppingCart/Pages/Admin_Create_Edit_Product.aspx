<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Create_Edit_Product.aspx.cs" Inherits="Pages_Admin_Create_Edit_Product"  MasterPageFile="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<form id="Form1" runat="server" action="Admin_Create_Edit_Product.aspx" >
<asp:Panel ID="Panel1" runat="server" Height="200" Width="500"><center><h1 >Product Information</h1></center>
   <center><asp:Table ID="Table1" runat="server">
   <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="100" Font-Size="11">
       <asp:Label ID="lbProductName" runat="server" Text="Product Name" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="100">
       <asp:TextBox ID="txtProductName" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbPrice" runat="server" Text="Price"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtPrice" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbDescription" runat="server" Text="Description"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtDescription" runat="server" TextMode="multiline" Width="180" Rows="3"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbWarrantyDay" runat="server" Text="Warranty"></asp:Label>
   </asp:TableCell>
   <asp:TableCell HorizontalAlign="left">
       <asp:TextBox ID="txtWarrantyDay" runat="server" Width="140"></asp:TextBox><asp:Label runat="server">Day(s)</asp:Label>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbImage" runat="server" Text="Image"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
   <asp:FileUpload runat="server" Width="180"></asp:FileUpload>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbQuantity" runat="server" Text="Quantity"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtQuantity" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell>
       <asp:Button ID="btnCreate" runat="server" Text="Create" Width="60" />
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