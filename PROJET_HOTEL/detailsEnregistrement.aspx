﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detailsEnregistrement.aspx.cs" Inherits="detailsEnregistrement" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="container" style="padding-top: 6%">
        <div class="col-md-10 col-md-offset-1 jumbotron">
            <br />
            <div class="panel panel-primary">
                <div class="panel-heading">
                                Informations de l'enregistrement              
                </div>
                <div id="infos" class="panel-body" runat="server"  >
                    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="342px" Width="498px" >
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label1" runat="server" Text="Label">Nom et prenom : <br /></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="nom" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label3" runat="server" Text="Label">Cin : <br /></asp:Label> 
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="cin" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label8" runat="server" Text="Label">Nombre de nuitées : <br /></asp:Label> 
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="nbrnuitees" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label5" runat="server" Text="Label">Date Arrivée : <br /></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="datearrivee" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                 <asp:Label ID="Label6" runat="server" Text="Label">Nombre de personnes : <br /></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="nbrpersonnes" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label7" runat="server" Text="Label">Formule : <br /></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="formule" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label2" runat="server" Text="Label">Chambre : <br /></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell></asp:TableCell><asp:TableCell></asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="chambre" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="4">
                                <asp:Button ID="Facture" type="submit" OnClick="Facture_Click" CssClass="btn-danger" runat="server" Text="Gérer la consommation" /><br />
                            </asp:TableCell>
                        </asp:TableRow>
                        
                        <asp:TableRow>
                            <asp:TableCell ColumnSpan="4" HorizontalAlign="Center"><asp:Button ID="Checkout" type="submit" OnClick="Checkout_Click" CssClass="btn-danger" runat="server" Text="Passer au Checkout" /></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                  
                   
                   <br />
                </div>
            </div>
        </div>
    </div>
    </form>
    </asp:Content>
