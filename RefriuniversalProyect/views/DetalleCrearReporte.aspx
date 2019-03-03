<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="DetalleCrearReporte.aspx.cs" Inherits="RefriuniversalProyect.views.DetalleCrearReporte" %>

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
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>Reporte</h6>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>CODIGO</label>
                                    <asp:TextBox runat="server" ID="codigo" Enabled="false" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>FECHA</label>
                                    <asp:TextBox runat="server" ID="fecha" CssClass="form-control" type="date" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>DESCRIPCION</label>
                                    <textarea runat="server" id="descr" class="form-control" cols="40" rows="5" style="resize: both;"></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>Informacion Articulo</h6>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>TIPO ARTICULO</label>
                                    <asp:DropDownList runat="server" ID="tipoArticulo" CssClass="form-control" AppendDataBoundItems="true">
                                        <asp:ListItem Text="Seleccione" Value="0" Selected="True" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>REFERENCIA ARTICULO</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="referencia" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:ScriptManager ID="ScriptManager1"  runat="server" />
                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="busquedalink" />
                    </Triggers>
                    <ContentTemplate>
                <div class="card card-user">
                    <div class="card-header">
                        <h6>Agregar Repuesto</h6>
                    </div>                                      
                            <div class="card-body">
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <label>Busqueda</label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="busqueda" />
                                            <asp:LinkButton Text="BUSCAR" OnClick="Busqueda" runat="server"  id="busquedalink" CssClass="btn btn-info"/>
                                            <asp:LinkButton Text="CREAR" runat="server" OnClick="abrirmodal" CssClass="btn btn-default" />                                         
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <table class="table table-responsive-lg">
                                            <thead>
                                                <tr>
                                                    <th>NOMBRE</th>
                                                    <th>AGREGAR</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:ListView runat="server" ID="listarespuestos" OnItemEditing="listarespuestos_ItemEditing">
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <asp:Label Text='<%#Eval("nombPRODUCTO")%>' ID="nombre" runat="server" />
                                                                <asp:Label Text='<%#Eval("idPRODUCTO")%>' ID="id" runat="server" Visible="false" />
                                                            </td>
                                                            <td>
                                                                <asp:LinkButton CssClass="icono-plusCircle" CommandName="edit" runat="server" />
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                      
                </div>
                        </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="col-md-6">
                <div class="card card-user">
                    <div class="card-header">
                        <h6>Lista repuestos</h6>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <table>
                                    <thead>
                                    </thead>
                                    <tbody>
                                        <asp:ListView runat="server" ID="repuestosOrden" OnItemEditing="listarespuestos_ItemEditing">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombPRODUCTO")%>' ID="nombre" runat="server" />
                                                        <asp:Label Text='<%#Eval("idPRODUCTO")%>' ID="id" runat="server" Visible="false" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-crossCircle" CommandName="edit" runat="server" />
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>

                                </table>
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal fade" id="tenicos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabe2" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabe2">Crear Repuestos</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>NOMBRE</label>
                                    <asp:TextBox runat="server" ID="nombreProducto" CssClass="form-control" required />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>MARCA</label>
                                    <asp:TextBox runat="server" ID="marcaProducto" CssClass="form-control" required />
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>REFERENCIA</label>
                                    <asp:TextBox runat="server" ID="referenciaProducto" CssClass="form-control" required />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button Text="CREAR" runat="server" CssClass="btn btn-success" OnClick="CrearRepuesto" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">CERRAR</button>
                    </div>
                </div>
            </div>
        </div>
   </div>
    
</asp:Content>
