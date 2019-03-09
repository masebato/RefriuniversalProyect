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
                           <table id="example" class="table table-responsive-lg" style="width: 100%">
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
       
    </div>    

  
</asp:Content>
