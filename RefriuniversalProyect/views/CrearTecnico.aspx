<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearTecnico.aspx.cs" Inherits="RefriuniversalProyect.views.CrearTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-8">
                    <div class="card card-user">
                        <div class="card-header">
                            <h5 class="card-header">CREAR TECNICO</h5>
                        </div>
                        <br />
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>NOMBRE</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>APELLIDO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" t />
                                    </div>
                                </div>  
                              
                            </div>
                             <div class="row">
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>CEDULA</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>TELEFONO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" t />
                                    </div>
                                </div>  
                              
                            </div>
                    
                            </div>                                                                                           
                            <div class="text-center">
                                <asp:Button Text="Guardar" CssClass="btn btn-info btn-fill btn-wd" runat="server" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
</asp:Content>
