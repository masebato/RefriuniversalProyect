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
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>NOMBRE</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" id="nombreTecnico" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>APELLIDO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" id="ApellidoTecnico"/>
                                    </div>
                                </div>  
                              <div class="col-md-4">
                                    <div class="form-group">
                                        <label>TELEFONO</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" id="telefonoTecnico" />
                                    </div>
                                </div>  
                            </div>
                             <div class="row">
                                   <div class="col-md-5">
                                   <div class="form-group">
                                        <label>TIPO DOCUMENTO</label>
                                        <asp:DropDownList runat="server" CssClass="form-control" required ID="dropdowntipo" AppendDataBoundItems="true">
                                            <asp:ListItem Text="SELECCIONE" Selected="True" Value="0" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>Documento</label>
                                        <asp:TextBox runat="server" required CssClass="form-control" ID="DocumentoTecnico" />
                                    </div>
                                </div>                                                              
                            </div>                    
                            </div>                                                                                           
                            <div class="text-center">
                                <asp:Button Text="Guardar" CssClass="btn btn-info btn-fill btn-wd" runat="server" OnClick="Unnamed_Click" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
</asp:Content>
