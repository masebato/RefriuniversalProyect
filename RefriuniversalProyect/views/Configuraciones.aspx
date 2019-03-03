<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="Configuraciones.aspx.cs" Inherits="RefriuniversalProyect.views.Configuraciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>Datos de la empresa</h6>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>Nombre Empresa</label>
                                    <asp:TextBox runat="server" ID="nombreEmpresa" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>Nit</label>
                                    <asp:TextBox runat="server" ID="Nit" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="">
                                    <label>Cargar logo</label>

                                    <asp:FileUpload ID="cargarlogo" runat="server" CssClass="custom-file" />

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-2">
                                <asp:Button ID="UploadButton" Text="ACTUALIZAR" runat="server" CssClass="btn btn-info" OnClick="UploadButton_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <asp:ScriptManager ID="ScriptManager1"  runat="server" />
                <asp:UpdatePanel runat="server">
                  <Triggers>
                      <asp:AsyncPostBackTrigger ControlID="crearTipo" />
                  </Triggers>
                    <ContentTemplate>
                        <div class="card card-user">
                            <div class="card-header">
                                <h6>TIPO ARTICULO</h6>
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <label>Nombre Tipo Articulo</label>
                                            <asp:TextBox runat="server" id="nombreTipoArticulo" CssClass="form-control" />
                                             <asp:LinkButton Text="CREAR" CssClass="btn btn-success" runat="server" ID="crearTipo" OnClick="Unnamed_Click"/>
                                        </div>
                                    </div>
                                  
                                </div>
                            </div>
                            <div class="card-body">
                                <table class="table table-responsive-md">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE</th>
                                            <th>ESTADO</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:ListView runat="server" ID="ListaTipoArticulo" DataKeyNames="idTIPO_ARTICULO" OnItemEditing="ListaTipoArticulo_ItemEditing" > 
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombreTIPOARTICULO")%>' ID="nombre" runat="server" />
                                                        <asp:Label Text='<%#Eval("idTIPO_ARTICULO")%>' ID="id" runat="server" Visible="false" />
                                                    </td>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("estadoTIPOARTICULO")%>' ID="estado" runat="server" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-gear" runat="server" CommandName="edit"/>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
          <div class="modal fade" id="tipo" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabe2" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabe2">Modificar Tipo Articulo</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>NOMBRE</label>
                                    <asp:TextBox runat="server" ID="nombreArticulo" CssClass="form-control" required />
                                    <asp:Label Text="" ID="ID" Visible="false" runat="server" />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>ESTADO</label>
                                    <asp:DropDownList runat="server" ID="estadoTipoArti" CssClass="form-control">
                                        <asp:ListItem Text="ACTIVO" Selected="True"/>
                                        <asp:ListItem Text="INACTIVO" />
                                    </asp:DropDownList>
                                </div>
                            </div>                            
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button Text="ACTUALIZAR" runat="server" CssClass="btn btn-success" OnClick="ActualizarTipo" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">CERRAR</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
