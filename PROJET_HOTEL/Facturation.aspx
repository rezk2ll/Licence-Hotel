<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Facturation.aspx.cs" Inherits="Facturation" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="container" style="padding-top: 6%">
        <div id="corps" class="col-md-10 col-md-offset-1 jumbotron" runat="server">
            <asp:Label ID="leau" runat="server" Text="Bouteille d'eau"></asp:Label>
            <asp:TextBox ID="eau" runat="server" type="number" min="0"></asp:TextBox>   
            <asp:Label ID="lboisson" runat="server" Text="Boisson gazeuse"></asp:Label>
            <asp:TextBox ID="boisson" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label2" runat="server" Text="Bierre"></asp:Label>
            <asp:TextBox ID="bierre" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label3" runat="server" Text="Cafe"></asp:Label>
            <asp:TextBox ID="cafe" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label4" runat="server" Text="Pizza"></asp:Label>
            <asp:TextBox ID="pizza" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label5" runat="server" Text="Hamburgueur"></asp:Label>
            <asp:TextBox ID="hamburgueur" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label6" runat="server" Text="Massage"></asp:Label>
            <asp:TextBox ID="massage" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label7" runat="server" Text="Spa"></asp:Label>
            <asp:TextBox ID="spa" runat="server" type="number" min="0"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Soin"></asp:Label>
            <asp:TextBox ID="soin" runat="server" type="number" min="0"></asp:TextBox> 
            <asp:Label ID="Label8" runat="server" Text="Balade en mer"></asp:Label>
            <asp:TextBox ID="balade" runat="server" type="number" min="0"></asp:TextBox>  
            <br />
                <asp:Button ID="Sauvegarder" type="submit" OnClick="Sauvegarder_Click" CssClass="btn-danger" runat="server" Text="Sauvegarder les changements" />
            <br />
        </div>
        
    </div>
    </form>
    </asp:Content>
