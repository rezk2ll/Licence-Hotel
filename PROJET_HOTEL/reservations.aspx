<%@ Page Language="C#" AutoEventWireup="true"  masterpagefile="~/MasterPage.master" CodeFile="reservations.aspx.cs" Inherits="reservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top: 6%">
        <div style="position: fixed; top: 50%; left: 10%;">
            <a href="#"><span class="glyphicon glyphicon-chevron-left" style="font-size: 50px;" onclick="window.location.href = window.history.back(1);"></span></a>
        </div>
        <div class="col-md-10 col-md-offset-1 jumbotron">
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
    </asp:Content>