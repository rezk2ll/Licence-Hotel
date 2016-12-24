<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="reservations.aspx.cs" Inherits="reservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container" style="padding-top: 2%">
        <div style="position: fixed; top: 50%; left: 10%;">
            <a href="#"><span class="glyphicon glyphicon-chevron-left" style="font-size: 50px;" onclick="window.location.href = window.history.back(1);"></span></a>
        </div>
        <div class="col-md-16 col-md-offset-0 jumbotron">
            <form id="form1" method="post" runat="server">
                <asp:Table ID="Table1" runat="server" Width="647px" Height="155px" HorizontalAlign="Center">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell HorizontalAlign="Center"> Numéro de la carte d'identité </asp:TableHeaderCell>
                        <asp:TableHeaderCell HorizontalAlign="Center"> et  </asp:TableHeaderCell>
                        <asp:TableHeaderCell HorizontalAlign="Center"> Date de reservation (facultative) </asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell HorizontalAlign="Center">
                            <asp:TextBox type="number" required="required" ID="cin" name="cin" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableHeaderCell HorizontalAlign="Center"> </asp:TableHeaderCell>
                        <asp:TableCell HorizontalAlign="Center">
                            <input type="date" id="DateArrivee" name="DateArrivee" runat="server" class="form-control" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="3" HorizontalAlign="Center">
                            <asp:Button ID="bcherche" type="submit" CssClass="btn-danger" runat="server" Text="chercher" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </form>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    liste des reservations
                    <a href="new_reservation.aspx">
                        <span class="glyphicon glyphicon-pencil pull-right">Ajouter
                        </span>
                    </a>
                </div>
                <div class="panel-body">
                    <asp:Table ID="listreserv" runat="server" CssClass="table">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                supprimer
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                nom
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                prenom
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                cin
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                date reservation
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                date d'arrivée
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                nombre de personnes
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                formule
                            </asp:TableHeaderCell>
                            <asp:TableHeaderCell>
                                nombre de nuits
                            </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
