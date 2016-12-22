<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>License Hôtel</title>
    <link href='css/bootstrap.min.css' rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <nav class="navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                glyphicon glyphicon-star-empty
                <a class="navbar-brand" href="./">Licence Hôtel - <span class="glyphicon glyphicon-star-empty"></span>
                    <span class="glyphicon glyphicon-star-empty"></span>
                    <span class="glyphicon glyphicon-star-empty"></span>
                    <span class="glyphicon glyphicon-star-empty"></span>
                </a>
            </div>
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li id="homem" class="active">
                        <a href="./">accueil</a>
                    </li>
                    <li class="active">
                        <a href="reservations.aspx">reservations</a>
                    </li>
                    <li class="active">
                        <a href="enregistrement.aspx">Enregistrement</a>
                    </li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li class="active">
                        <a href="logout.aspx">checkout</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container" style="padding-top: 5%">

        <div class="col-md-10 col-md-offset-1 jumbotron">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    Bonjour
                </div>
                <div class="panel-body">
                    C'est la page d'accueil.
                </div>
            </div>
        </div>
    </div>
</body>
</html>
