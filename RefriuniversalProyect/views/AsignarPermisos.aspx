<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="AsignarPermisos.aspx.cs" Inherits="RefriuniversalProyect.views.Parametricas.AsignarRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/icono/1.3.0/icono.min.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container-fluid">
            <div class="col-md-12 ">
                <div class="card card-user">
                    <div class="card-header">
                        <h5>ASIGNAR PERMISOS</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-6 offset-md-3">
                                <asp:DropDownList runat="server" ID="dropdownRoles" CssClass="form-control" AppendDataBoundItems="True" AutoPostBack="true" OnSelectedIndexChanged="dropdownRoles_SelectedIndexChanged" required>
                                    <asp:ListItem Text="Seleccione un rol" Selected="True" Value="0" />
                                </asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class=" col-md-6">
                                <h6>PERMISOS DEL ROL</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE MENU</th>                                           
                                            <th>ELIMINAR</th>
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="listaPermisos" runat="server" DataKeyNames="id" OnItemEditing="listaPermisos_ItemEditing">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombre") %>' runat="server" ID="NombreMENUList" />
                                                    </td>
                                                  
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-crossCircle" Style="color: cornflowerblue"  CommandName="edit"  runat="server" />
                                                    </td>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("id") %>' runat="server" ID="idMENUlist" Visible="false" />
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                            <div class=" col-md-6">
                                <h6>PERMISOS</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE MENU</th>
                                            <th>AGREGAR</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="permisosno" runat="server" DataKeyNames="menuid" OnItemEditing="permisosno_ItemEditing" >
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("menunombre") %>' runat="server" ID="NombreMENUList" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-pluscircle" Style="color: cornflowerblue" CommandName="edit" runat="server" />
                                                    </td>
                                                   
                                                    <td>
                                                        <asp:Label Text='<%#Eval("menuid") %>' runat="server" ID="idMENUlist" Visible="false" />
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
