<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="RefriuniversalProyect.views.Historial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/icono/1.3.0/icono.min.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5>BUSCAR ORDENES</h5>
                    
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>Fecha min</label>
                                    <input id="fechainicio" runat="server" type="date" class="form-control" />
                                </div>
                            </div>
                            <div class="col">
                                   <div class="form-group">
                                    <label>Fecha max</label>
                                    <input id="fechamax" type="date" runat="server" class="form-control" />
                                </div>
                            </div>
                            <div class="col">
                                <div class="text-center">
                                    <asp:Button Text="BUSCAR" CssClass="btn btn-info" OnClick="Unnamed_Click" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">               
                        <asp:ListView runat="server" ID="ListaORDENES" DataKeyNames="idORDENSERVICIO" OnItemEditing="ListaORDENES_ItemEditing">
                            <ItemTemplate>
                                <div class="col">
                                    <div class="card card-user">
                                        <div class="card-header">
                                            <asp:Label Text='<%#Eval("codiORDENSERVICIO") %>' ID="codigoORDEN" CssClass="h6 alert-info text-center" runat="server" />
                                          
                                        </div>
                                        <div class="card-body">
                                            <div class="row">
                                                <div class="col">
                                                    <div class="form-group">
                                                        <label>NOMBRE CLIENTE</label>
                                                        <asp:Label Text='<%#Eval("nombres") %>' ID="NombreCliente" runat="server" />
                                                    </div>
                                                    
                                                    <asp:Label Text='<%#Eval("idORDENSERVICIO") %>' ID="idORden" Visible="false" runat="server" />
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col">
                                                    <div class="form-group">
                                                        <label>FECHA ORDEN</label>
                                                         <asp:Label Text='<%#Eval("fechaORDENSERVICIO") %>' ID="Fecha" runat="server" />
                                                    </div>                                                   
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col">
                                                    <div class="form-group">
                                                        <label>ESTADO ORDEN</label>
                                                        <asp:Label Text='<%#Eval("estadoORDENSERVICIO") %>' ID="Estado" runat="server" />
                                                    </div>                                                    
                                                </div>
                                            </div>
                                        </div>
                                        <div class="card-footer">
                                            <asp:LinkButton Text="" CssClass="icono-eye" CommandName="edit" runat="server" />
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                 
            </div>
        </div>
    </div>
</asp:Content>
