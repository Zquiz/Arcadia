<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="SignUpData.aspx.cs" Inherits="Admin_SignUpData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />
    <asp:Button ID="btnDelete" runat="server" Text="Delete everything" OnClick="btnDelete_Click" />
</asp:Content>