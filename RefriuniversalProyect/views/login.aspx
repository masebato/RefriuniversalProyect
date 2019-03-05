<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="RefriuniversalProyect.views.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" rel="stylesheet" />
    <!-- CSS Files -->
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/paper-dashboard.css?v=2.0.0" rel="stylesheet" />
    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href="assets/demo/demo.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/7.28.5/sweetalert2.all.js"></script>
    <form runat="server">
        <div class="wrapper" style="background-image:url('assets/img/fondo_login.jpg'); background-size:100%";>
            <div>
                <div class="content">
                    <div class="row">                       
                        <div class="col-md-6 offset-md-3">
                            <div class="card card-user">
                                <div class="card-header">
                                    <h5>INICIAR SESION</h5>
                                    <div class="row justify-content-end">
                                        <div class="col-md-4">
                                            <div class="logo">
                                                <a href="#" class="simple-text logo-mini">
                                                    <div class="logo-image-small">
                                                        <img src="assets/img/logoru.png" alt="10%">
                                                    </div>
                                                </a>
                                            </div>
                                        </div>
                                     
                                         <div class="col-sm-4">
                                            <div class="form-group">
                                                <label>Usuario</label>
                                                <asp:TextBox runat="server" ID="users" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>                                       
                                             <div class="col-sm-4">
                                            <div class="form-group">
                                                <label>Contraseña</label>
                                                <input type="password" runat="server" id="pass" class="form-control" />
                                            </div>
                                        </div>     
                                        <div class="col-md-4">
                                             <asp:Button runat="server" CssClass="btn btn-border" Text="INGRESAR" OnClick="Unnamed_Click" />                    
                                        </div>
                                    </div>
                                </div>                                                               
                                              
                            </div>
                        </div>
                    </div>

                </div>

            </div>

        </div>
    </form>
</body>

</html>
