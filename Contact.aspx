<%@ Page Title="Contact" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content" style="min-height: 536px">
        <div style="float: left; height: 536px; margin-bottom: 43px; margin-left: 139px; margin-top: 166px; width: 451px;">
            <div class="BE-A-PART-OF-THE-FUT">CONTACT FOR QUESTIONS</div>
            <div class="signupImage">
            </div>
        </div>
        <div style="float: left; height: 536px; margin-left: 198px; margin-top: 186px;">
            <div class="NAME" style="margin-top: 26px;">NAME</div>
            <div class="EMAIL" style="margin-top: 76px;">EMAIL</div>
            <div class="PASSWORD" style="margin-top: 79px;">SUBJECT</div>
            <div class="PASSWORD" style="margin-top: 120px;">MESSAGE</div>
        </div>
        <div style="float: left; margin-left: 21px; margin-top: 186px; min-height: 536px;">
            <div style="margin-bottom: 35px;">
                <asp:TextBox ID="txtName" type="text" runat="server" CssClass="Textfield"/>
            </div>
            <div style="margin-bottom: 35px;">
                <asp:TextBox ID="txtEmail" type="text" runat="server" CssClass="Textfield"/>
            </div>
            <div>
                <asp:TextBox ID="txtSubject" type="text" runat="server" CssClass="Textfield" TextMode="Password"/>
            </div>
            <div style="margin-top: 35px;">
                <asp:TextBox ID="txtMsg" runat="server" CssClass="Textfield" Height="157px" TextMode="MultiLine" Width=""></asp:TextBox>
            </div>

            <div style="margin-bottom: 37px; margin-left: 212px; margin-top: 33px;">
                <asp:Button ID="btnSend" runat="server" Text="SEND" CssClass="Signup" BorderStyle="None" OnClick="btnSend_Click" Font-Names="OratorStd" Font-Size="Large" ForeColor="White"/>
            </div>
            <asp:Literal runat="server" ID="litError"></asp:Literal>
        </div>
    </div>
    <div class="blackcontentBox" style="background-color: #d8d8d8; height: 348px;"></div>
</asp:Content>