<%@ Page Language="C#" AutoEventWireup="true" masterpagefile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Import Namespace="System.Web.Security" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-top: 5%">

        <div class="col-md-10 col-md-offset-1 jumbotron">
            <div class="panel panel-primary" id="homee" runat="server">
                <div class="panel-heading" id="logstat" runat="server">
                    Login
                </div>
                <div class="panel-body" id="logview" runat="server">
                    <form runat="server">
                        <label for="username" id="unamel"></label>
                        <asp:TextBox id="username" CssClass="form-control" runat="server" required="required"></asp:TextBox>
                        <br />
                        <label for="password" id="upassl"></label>
                        <asp:TextBox ID="password" CssClass="form-control" runat="server" type="password" required="required"></asp:TextBox>
                        <br />
                        <asp:Button runat="server" CssClass="btn-danger" Text="Login" OnClick="Unnamed_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>