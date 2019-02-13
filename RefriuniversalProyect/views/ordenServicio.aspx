<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ordenServicio.aspx.cs" Inherits="RefriuniversalProyect.views.ordenServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-8">
                    <div class="card card-user">
                        <div class="card-header">
                            <h5 class="card-header">CREAR ORDEN DE SERVICIO</h5>
                        </div>
                        <br />
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <label>CODIGO</label>
                                        <asp:TextBox runat="server" id="codigoformulario" CssClass="form-control" required />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>FECHA</label>
                                        <asp:TextBox runat="server" id="fechaformulario" CssClass="form-control" type="date" required />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>ESTADO</label>
                                        <asp:TextBox runat="server" id="estadoformulario" placeholder="ACTIVO" Enabled="false" CssClass="form-control" />
                                    </div>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>CLIENTE</label>
                                        <asp:TextBox runat="server" ID="clienteFormulario" Enabled="false" CssClass="form-control" required/>
                                        <asp:Label Text="" ID="idclientelabel" Visible="false" runat="server" />
                                    </div>
                                </div>
                                <div class="col-md-1">
                                    <br />
                                    <asp:Button Text="+" runat="server" class="form-control btn-info" OnClick="CargarClientes" />
                                </div>
                                <div class="col-md-5">
                                    <div class="form-group">
                                        <label>TECNICO</label>
                                        <asp:TextBox runat="server" id="tecnicoformulario" Enabled="false" CssClass="form-control" required/>
                                        <asp:Label id="idtecnicolabel" runat="server" visible="false"/>
                                    </div>
                                </div>
                                <div class="col-md-1">
                                    <br />
                                    <asp:Button Text="+" runat="server" class="form-control btn-info" OnClick="CargarTecnicos" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label>DESCRIPCION</label>
                                        <textarea runat="server" id="descripcionformulario" class="form-control" rows="4 " required ></textarea>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center">
                                <asp:Button Text="Guardar" CssClass="btn btn-info btn-fill btn-wd" runat="server" OnClick="GuardarRegistro" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>




        <%--MODAL CLIENTES--%>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Listado de clientes</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <table id="example" class="display" style="width: 100%">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Nombre</th>
                                    <th>Apellido</th>
                                    <th>Documento</th>
                                    <th>Direccion</th>
                                    <th>Correo</th>
                                    <th>telefono</th>
                                    <th>Agregar</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="clientes" OnItemEditing="clientes_ItemEditing" DataKeyNames="idCLIENTE">
                                    <ItemTemplate>  
                                        <tr>
                                            <td>
                                                <asp:Label id="idcliente" Text='<%#Eval("idCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="nombrecliente" Text='<%#Eval("nombCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="apellidocliente" Text='<%#Eval("apellCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="documentocliente" Text='<%#Eval("docuCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="direccioncliente" Text='<%#Eval("direCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="correocliente" Text='<%#Eval("corrCLIENTE")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="telefonocliente" Text='<%#Eval("teleCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                 <asp:LinkButton class="icono-plusCircle" style="color:cornflowerblue" runat="server" CommandName="edit" />
                                               
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:ListView>
                            </tbody>
                          
                        </table>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        
                    </div>
                </div>
            </div>
        </div>

       <%-- MODAL TECNICOS--%>
         <div class="modal fade" id="tenicos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabe2" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabe2">Listado de tecnicos</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <table id="example2" class="display" style="width: 100%">
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Nombre</th>
                                    <th>Apellido</th>                                   
                                    <th>Agregar</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="Tecnicos" OnItemEditing="Tecnicos_ItemEditing" DataKeyNames="idtecnico">
                                    <ItemTemplate>  
                                        <tr>
                                            <td>
                                                <asp:Label id="idtecnico" Text='<%#Eval("idTECNICO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="nombretecnico" Text='<%#Eval("nombTECNICO")%>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label id="apellidotecnico" Text='<%#Eval("apelTECNICO")%>' runat="server" />
                                            </td>                                          
                                            <td>
                                                <asp:LinkButton runat="server" class="icono-plusCircle" style="color:cornflowerblue" CommandName="edit" />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:ListView>
                            </tbody>
                          
                        </table>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                     
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#example').dataTable({
                "language": {
                    "url": "dataTables.german.lang"
                }
            });
        });
          $(document).ready(function () {

            $('#example2').dataTable({
                "language": {
                    "url": "dataTables.german.lang"
                }
            });
        });
    </script>

 
</asp:Content>
