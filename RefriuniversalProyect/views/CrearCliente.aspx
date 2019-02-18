
<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="RefriuniversalProyect.views.CrearCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-8">
                    <div class="card card-user">
                        <div class="card-header">
                            <h5 class="card-header">CREAR CLIENTE</h5>
                        </div>
                        <br />
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>NOMBRE</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" id="nombre"/>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>APELLIDO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" id="apellido" />
                                    </div>
                                </div>  
                                <div class="col-md-4">
                                    <div class="form-group">
                                         <label>CORREO</label>
                                         <asp:TextBox runat="server" required CssClass="form-control" type="email" ID="correo"/>                                       
                                    </div>
                                </div>        
                            </div>
                            <div class="row">
                                  <div class="col-md-4">
                                    <div class="form-group">
                                        <label>TIPO DOCUMENTO</label>
                                        <asp:DropDownList runat="server" CssClass="form-control" required>
                                            <asp:ListItem Text="SELECCIONE" Selected />
                                            <asp:ListItem Text="CEDULA" />
                                            <asp:ListItem Text="TARJETA IDENTIDAD" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>DOCUMENTO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" ID="documento"/>                                                                              
                                    </div>
                                </div>      
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>DIRECCION</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" ID="direccion"/>                                                                              
                                    </div>
                                </div>         
                            </div>
                            </div>                                                                                           
                            <div class="text-center">
                                <asp:Button Text="Guardar" CssClass="btn btn-info btn-fill btn-wd" runat="server" OnClick="GuardarCliente" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
  
</asp:Content>
