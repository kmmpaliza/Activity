<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGE.Master" AutoEventWireup="true" CodeBehind="DELETE_EMPLOYEE.aspx.cs" Inherits="ACT9_Paliza.DELETE_EMPLOYEE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Title_of_Page" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Laman_ng_Page" runat="server">
<table>
        <tr>
            <td class="style4">
                EMPLOYEE ID</td>
            <td class="style5">
                <asp:TextBox ID="txtEmployeeId" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                FIRST NAME</td>
            <td class="style5">
                <asp:TextBox ID="txtFirstName" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                LAST NAME</td>
            <td class="style5">
                <asp:TextBox ID="txtLname" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                EMAIL</td>
            <td class="style5">
                <asp:TextBox ID="txtEmail" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                PHONE NUMBER</td>
            <td class="style5">
                <asp:TextBox ID="txtPhoneNum" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                HIRE DATE</td>
            <td class="style5">
                <asp:TextBox ID="txtHireDate" runat="server" Width="248px">MM/DD/YYYY</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                JOB ID</td>
            <td class="style5">
                <asp:TextBox ID="txtJobID" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                SALARY</td>
            <td class="style5">
                <asp:TextBox ID="txtSalary" runat="server" Width="248px">0.00</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                COMMISSION PCT</td>
            <td class="style5">
                <asp:TextBox ID="txtCommission" runat="server" Width="248px">0.00</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                MANAGER ID</td>
            <td class="style5">
                <asp:DropDownList ID="drpMngrId" runat="server" AutoPostBack="True" 
                    Height="26px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    Width="248px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style9">
                DEPARTMENT ID</td>
            <td class="style7">
                <asp:TextBox ID="txtDeptId" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Button ID="Button1" runat="server" CssClass="style8" Height="31px" 
                    onclick="Button1_Click" Text="DELETE" Width="143px" />
            </td>
            <td class="style7">
                <asp:Button ID="Button2" runat="server" Height="31px" onclick="Button2_Click" 
                    Text="CANCEL" Width="143px" />
            </td>
        </tr>
    </table>
</asp:Content>
