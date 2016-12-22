﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="new_reservation.aspx.cs" Inherits="reservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href='css/bootstrap.min.css' rel="stylesheet" />
    <script src = "js/jquery.min.js"></script>
    <script src = "js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container" style="padding-top: 1%">
        <div style="position:fixed;top:50%;left:10%;">
           <a href="#"><span class="glyphicon glyphicon-chevron-left" style="font-size: 50px;" onclick="window.location.href = window.history.back(1);" ></span></a> 
        </div>
        <div class="col-md-10 col-md-offset-1 jumbotron">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    Effectuer une reservation
                </div>
                <div class="panel-body">
                    <form runat="server">
                        <div class="form-group">
                            <asp:Label CssClass="control-label" runat="server">Nom client</asp:Label>
                            <asp:TextBox id="nom" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="nom" runat="server" ErrorMessage="Nom invalide" ValidationExpression="^[a-zA-Z]{3,}"></asp:RegularExpressionValidator>
                            <br />
                            <asp:Label CssClass="control-label" runat="server">prenom client</asp:Label>
                            <asp:TextBox ID="prenom" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="prenom" runat="server" ErrorMessage="Nom invalide" ValidationExpression="^[a-zA-Z]{3,}"></asp:RegularExpressionValidator>
                            <br />
                            <asp:Label ID="Label1" CssClass="control-label" runat="server">cin client</asp:Label>
                            <asp:TextBox ID="cin" required="requied" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="cin" runat="server" ErrorMessage="Nom invalide" ValidationExpression="^[0-9]{8}"></asp:RegularExpressionValidator>
                            <br />
                            <asp:Label ID="Label2" CssClass="control-label" runat="server">nombre de personnes</asp:Label>
                            <input type="number" class="form-control" id="nbpers" runat="server" max="4" min="1" />
                            <asp:Label ID="Label3" CssClass="control-label" runat="server">date d'arrivée</asp:Label>
                            <input type="date" required="required" id="date_reservation" class="form-control" runat="server" />
                            <br />
                            <asp:Button CssClass="btn btn-danger" runat="server" Text="Réserver" OnClick="reserver" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
