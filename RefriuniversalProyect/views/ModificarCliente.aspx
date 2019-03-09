<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="RefriuniversalProyect.views.ModificarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user text-center">
                    <div class="card-header">
                        <h6>CONSULTAR CLIENTES</h6>
                        <div class="row">
                            <div class="col-md-4 offset-4">
                                <div class="form-group">
                                    <label>DOCUMENTO</label>
                                    <asp:TextBox runat="server" ID="documentoCliente" placeholder="Documento cliente" CssClass="form-control" />
                                </div>
                                <asp:LinkButton Text="CONSULTAR" CssClass="btn btn-secondary" runat="server" OnClick="CargarClientes" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="card card-user">
                    <div class="card-body">


                        <table class="table table-responsive-lg">
                            <thead>
                                <tr>
                                    <th>NOMBRE</th>
                                    <th>APELLIDO</th>
                                    <th>DOCUMENTO</th>
                                    <th>DIRECCION</th>
                                    <th>CORREO</th>
                                    <th>TELEFONO</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="clientesList" OnItemEditing="clientesList_ItemEditing" DataKeyNames="idCLIENTE">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label Text='<%#Eval("nombCLIENTE")%>' runat="server" />
                                                <asp:Label Text='<%#Eval("idCLIENTE")%>' runat="server" Visible="false" id="idcliente"/>
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("apellCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("docuCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("direCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("corrCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("teleCLIENTE")%>' runat="server" />
                                            </td>
                                            <td>
                                                <asp:LinkButton CssClass="icono-eye" CommandName="edit" runat="server" />
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
</asp:Content>
