<%@ Page Language="C#" AutoEventWireup="true"  masterpagefile="~/MasterPage.master" CodeFile="reservations.aspx.cs" Inherits="reservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="container" style="padding-top: 6%">
        <div style="position: fixed; top: 50%; left: 10%;">
            <a href="#"><span class="glyphicon glyphicon-chevron-left" style="font-size: 50px;" onclick="window.location.href = window.history.back(1);"></span></a>
        </div>
        <div class="col-md-10 col-md-offset-1 jumbotron">
            <br />
            <asp:Table ID="Table1" runat="server" Width="647px" Height="155px" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell HorizontalAlign="Center"> Nom ou Prenom </asp:TableHeaderCell>
                    <asp:TableHeaderCell HorizontalAlign="Center"> Formule </asp:TableHeaderCell>
                    <asp:TableHeaderCell HorizontalAlign="Center"> Date d'arrivée </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Center"> 
                        <asp:TextBox ID="nom" runat="server"></asp:TextBox> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center"> 
                        <asp:CheckBoxList ID="formule" runat="server"> 
                            <asp:ListItem Text="Petit Dejeuner" Value="pd"></asp:ListItem>
                            <asp:ListItem Text="Demi-Pension" Value="dp"></asp:ListItem>
                            <asp:ListItem Text="Pension Complète" Value="pc"></asp:ListItem>
                        </asp:CheckBoxList> 
                    </asp:TableCell>
                    <asp:TableCell HorizontalAlign="Center">
                        <input type="date" id="DateArrivee" class="form-control" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="3" HorizontalAlign="Center">
                        <asp:Button ID="bcherche" runat="server" Text="chercher" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            <br />
            <br />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    liste des reservation
                    <a href="new_reservation.aspx">
                        <span class="glyphicon glyphicon-pencil pull-right">Ajouter
                        </span>
                    </a>
                </div>
                <div class="panel-body">
                    <asp:Table ID="listreserv" runat="server" CssClass="table">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                Id
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
                                nombre de personnes
                            </asp:TableHeaderCell>
                                                        <asp:TableHeaderCell>
                                nombre de chambres
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
    </form>
    </asp:Content>