<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearReporte.aspx.cs" Inherits="RefriuniversalProyect.views.CrearReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-10">
                    <div class="card card-user">
                        <div class="card-header">
                            <h6>CONSULTAR ORDEN</h6>
                        </div>
                        <br />
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6 offset-md-3">
                                    <div class="text-center">                                        
                                        <asp:TextBox runat="server" CssClass="form-control" ID="codigoOrden"  placeholder="Ingrese codigo orden servicio" />
                                          <asp:Button Text="buscar" CssClass="btn btn-default" runat="server" OnClick="ConsultarOrden"/>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                           <table id="example" class="table table-bordered" style="width: 100%">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>codigo</th>
                                    <th>Descripcion</th>
                                    <th>fecha</th>
                                    <th>estado</th>                                    
                                    <th>Cliente</th>
                                    <th>Tecnico</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="reportes" OnItemEditing="reportes_ItemEditing" DataKeyNames="idORDENSERVICIO" >
                                    <ItemTemplate>  
                                        <tr>
                                            <td>
                                                <asp:Label id="idorden" Text='<%#Eval("idORDENSERVICIO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="codigoorden" Text='<%#Eval("codiORDENSERVICIO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="descorden" Text='<%#Eval("descORDENSERVICIO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="fechaorden" Text='<%#Eval("fechaORDENSERVICIO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="estadoorden" Text='<%#Eval("estadoORDENSERVICIO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="nombrecliente" Text='<%#Eval("nombrecliente")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="nombretecnico" Text='<%#Eval("nombretecnico")%>' runat="server" />
                                            </td>
                                            <td>
                                                 <asp:LinkButton class="icono-eye" style="color:cornflowerblue" runat="server" CommandName="edit" />                                               
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
         <div class="modal fade" id="CrearReporte" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Crear Reporte</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label> Codigo reporte </label>
                                    <asp:TextBox runat="server" id="codigoreporte" CssClass="form-control" Enabled="false"/>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Fecha</label>
                                    <asp:TextBox runat="server" type="date" ID="fechaReporte" CssClass="form-control"/>
                                </div>
                            </div>
                            <div class="col-md.4">
                                 <div class="form-group">
                                    <label>Codigo Orden</label>
                                    <asp:TextBox runat="server"  ID="CodigoOrdenmodal" CssClass="form-control" Enabled="false"/>
                                       <asp:TextBox runat="server"  ID="idordenmodal" CssClass="form-control" Enabled="false" Visible="false"/>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Nombre Articulo</label>
                                    <asp:TextBox runat="server" ID="nombreArticulo" CssClass="form-control"/>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Referencia Articulo</label>
                                    <asp:TextBox runat="server" id="ReferenciaArticulo" CssClass="form-control"/>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>tipo Articulo</label>
                                     <asp:DropDownList runat="server" id="tipoarticulo" CssClass="form-control">
                                    <asp:ListItem Text="Seleccione" Selected="True" />
                                    <asp:ListItem Text="Nevera" />
                                    <asp:ListItem Text="Lavadora" />
                                    <asp:ListItem Text="A/C" />
                                    <asp:ListItem Text="Cuarto frio" />
                                    <asp:ListItem Text="Tanque enfriamiento" />
                                </asp:DropDownList>
                                </div>                                
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label>Marca Articulo</label>
                                    <asp:TextBox runat="server" id="marcaArticulo" CssClass="form-control"/>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-12">
                                   <div class="form-group">
                                <label>Descripcion</label>
                                <textarea runat="server" id="descripcionReporte" class="form-control" rows="6" CssClass="form-control"></textarea>
                            </div>
                            </div>
                         
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        <asp:Button Text="Guardar"  CssClass="btn btn-success" runat="server" OnClick="GuardarReporte" />
                    </div>
                </div>
            </div>
        </div>          
    </div>    
</asp:Content>
