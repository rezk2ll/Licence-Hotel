<%@ Page Language="C#" AutoEventWireup="true"  masterpagefile="~/MasterPage.master" CodeFile="Enregistrement.aspx.cs" Inherits="Enregistrement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="container" style="padding-top: 6%">
        <div class="col-md-10 col-md-offset-1 jumbotron">
            <br />
            <div class="panel panel-primary">
                <div class="panel-heading">
                                Informations de la réservation                           <span class="badge">     <asp:Label ID="datereservation" runat="server">       </asp:Label></span>              
                </div>
                <div id="infos" class="panel-body" runat="server">
                   <asp:Label ID="Label1" runat="server" Text="Label">Nom</asp:Label><asp:TextBox ID="nom" runat="server" required="requied" CssClass="form-control"></asp:TextBox>
                   <asp:Label ID="Label2" runat="server" Text="Label">Prenom</asp:Label> <asp:TextBox ID="prenom" required="requied" CssClass="form-control" runat="server" ></asp:TextBox>
                   <asp:Label ID="Label3" runat="server" Text="Label">Cin</asp:Label> <asp:TextBox ID="cin" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                   <asp:Label ID="Label5" runat="server" Text="Label">Date Arrivée</asp:Label> <asp:TextBox type="date" ID="datearrivee" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                   <asp:Label ID="Label6" runat="server" Text="Label">Nombre de personnes</asp:Label> <asp:TextBox ID="nbrpersonnes" type="number" required="requied" CssClass="form-control" runat="server" max="4" min="1" ></asp:TextBox>
                   <asp:Label ID="Label7" runat="server" Text="Label">Formule</asp:Label> <asp:DropDownList CssClass="form-control" ID="formule" runat="server" >
                   <asp:ListItem Value="pd">Petit Déjeuner</asp:ListItem>
                   <asp:ListItem Value="dp">Demi-Pension</asp:ListItem>
                   <asp:ListItem Value="pc">Pension Complète</asp:ListItem>
                   </asp:DropDownList>
                   <asp:Label ID="Label8" runat="server" Text="Label">Nombre de nuitées</asp:Label> <asp:TextBox ID="nbrnuit" type="number" max="14" min="1" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                    
                    <br />
                    <asp:Button ID="Sauvegarder" type="submit" OnClick="Sauvegarder_Click" CssClass="btn-danger" runat="server" Text="Sauvegarder les changements" />
                </div>
            </div>
        </div>
    </div>
    </form>
    </asp:Content>