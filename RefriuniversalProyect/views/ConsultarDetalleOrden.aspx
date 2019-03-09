<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarDetalleOrden.aspx.cs" Inherits="RefriuniversalProyect.views.ConsultarDetalleOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>DETALLE ORDEN</h6>
                        <div class="row">
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label>CODIGO</label>
                                    <asp:TextBox runat="server" ID="CodigOrden" CssClass="form-control" Enabled="false" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>NOMBRE CLIENTE</label>
                                    <asp:TextBox runat="server" ID="NombreCliente" Enabled="false" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>FECHA CREACION</label>
                                    <asp:TextBox runat="server" ID="FechaCreacion" Enabled="false" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>ESTADO ORDEN</label>
                                    <asp:TextBox runat="server" ID="EstadoOrden" Enabled="false" CssClass="form-control" />
                                </div>
                            </div>
                            <div>
                                <asp:LinkButton Text="CREAR ORDEN" CssClass="btn btn-default" OnClick="Unnamed_Click" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>REPORTES REALIZADOS</h6>
                    </div>
                    <div class="card-body">
                        <asp:ListView runat="server" ID="ReportesList" OnItemEditing="ReportesList_ItemEditing">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <label>CODIGO REPORTE</label>
                                            <asp:TextBox runat="server" Text='<%#Eval("codiREPORTE") %>' CssClass="form-control" ID="Codigo" Enabled="false" />
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label>FECHA DEL REPORTE</label>
                                            <asp:TextBox runat="server" Text='<%#Eval("fechaREPORTE") %>' CssClass="form-control" ID="FechaReporte" Enabled="false" />
                                        </div>
                                    </div>
                                    <div class="col">
                                        <asp:LinkButton Text="" CssClass="icono-eye" runat="server" CommandName="edit" />
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>ARTICULO</h6>
                    </div>
                    <div class="card-body">
                        <asp:ListView runat="server" ID="ArticulosList">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <label>Tipo Articulo</label>
                                            <asp:TextBox runat="server" Text='<%#Eval("nombreTIPOARTICULO") %>' CssClass="form-control" ID="tipoArticulo" Enabled="false" />
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label>Referencia</label>
                                            <asp:TextBox runat="server" Text='<%#Eval("refeARTICULO") %>' CssClass="form-control" ID="referenciaarticulo" Enabled="false" />
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal fade" id="cantidadProducto" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabe3" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabe3">Insertar Repuesto</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>DESCRIPCION</label>
                                    <textarea id="descripcionarea" runat="server" enableviewstate="false" class="form-control">
                                        
                                    </textarea>
                                </div>
                            </div>
                        </div>
                        <label>REPUESTOS</label>
                        <asp:ListView runat="server" ID="repuestosReporte">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col">
                                        <asp:Label Text='<%#Eval("NombPRODUCTO") %>' CssClass="form-control" runat="server" Enabled="false" />

                                        <div class="col">
                                            <asp:Label Text='<%#Eval("cantidadREPORTE_PRODUCTO") %>' runat="server" CssClass="form-control" Enabled="false" />
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>

                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">CERRAR</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
