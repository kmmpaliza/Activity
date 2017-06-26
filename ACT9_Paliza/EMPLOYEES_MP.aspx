<%@ Page Title=" EMPLOYEES" Language="C#" MasterPageFile="~/MASTERPAGE.Master" AutoEventWireup="true" CodeBehind="EMPLOYEES_MP.aspx.cs" Inherits="ACT9_Paliza.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title_of_Page" runat="server">
    EMPLOYEES
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Laman_ng_Page" runat="server">
    <asp:GridView ID="grdEmployee" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        AllowPaging="True" onpageindexchanging="grdEmployee_PageIndexChanging" 
        onselectedindexchanging="grdEmployee_SelectedIndexChanging" PageSize="15" 
        Width="518px" DataKeyNames="Employee_id" 
        onrowediting="grdEmployee_RowEditing" 
        onrowdeleted="grdEmployee_RowDeleted" onrowdeleting="grdEmployee_RowDeleting">
        <Columns>
            <asp:CommandField SelectText="New" ShowSelectButton="True" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
</asp:Content>
