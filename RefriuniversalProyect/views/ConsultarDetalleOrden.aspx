<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarDetalleOrden.aspx.cs" Inherits="RefriuniversalProyect.views.ConsultarDetalleOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5>DETALLE ORDEN</h5>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label>CODIGO</label>
                                    <asp:TextBox runat="server" id="CodigOrden" Enabled="false"/>
                                </div>
                            </div>
                              <div class="col">
                                <div class="form-group">
                                    <label>NOMBRE CLIENTE</label>
                                    <asp:TextBox runat="server" id="NombreCliente" Enabled="false"/>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>FECHA CREACION</label>
                                    <asp:TextBox runat="server" id="FechaCreacion" Enabled="false"/>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>ESTADO ORDEN</label>
                                    <asp:TextBox runat="server" id="EstadoOrden" Enabled="false"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-body">
                        <asp:ListView runat="server">
                            <ItemTemplate>
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
