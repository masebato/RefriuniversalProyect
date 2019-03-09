<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarOrdenes.aspx.cs" Inherits="RefriuniversalProyect.views.ConsultarOrdenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="card-columns">
            <asp:ListView runat="server" ID="OrdenesCliente" OnItemEditing="OrdenesCliente_ItemEditing" DataKeyNames="idORDENSERVICIO">
                <ItemTemplate>
                    <div class="card card-user">
                        <div class="card-header">
                            <asp:Label runat="server" id="codigo" Text='<%#Eval("codiORDENSERVICIO")%>' CssClass="h6"/>
                            <asp:LinkButton CssClass="icono-eye" CommandName="edit" runat="server" />
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <label>NOMBRE</label>
                                        <asp:Label Text='<%#Eval("NOmbres")%>' CssClass="form-control" ID="nombre" runat="server" />
                                        <asp:Label Text='<%#Eval("idORDENSERVICIO")%>' Visible="false" ID="idorden" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <label>FECHA</label>
                                        <asp:Label Text='<%#Eval("fechaORDENSERVICIO")%>' CssClass="form-control" ID="fecha" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <label>ESTADO</label>
                                        <asp:Label Text='<%#Eval("estadoORDENSERVICIO")%>' CssClass="form-control" ID="estado" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        <label>DESCRIPCION</label>
                                        <asp:Label Text='<%#Eval("descORDENSERVICIO")%>' CssClass="form-control" ID="desc" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
