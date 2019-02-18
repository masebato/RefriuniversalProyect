<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="RefriuniversalProyect.views.Historial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container-fluid">

            <div class="row">
                <div class="col-md-12">
                    <div class="user card">
                        <div class="card-header">
                        </div>
                        <div class="card-body">
                           <div class="row">
                                <div class="col-md-3 offset-md-3">
                                    <div class="text-center">                                        
                                        <asp:TextBox runat="server" CssClass="form-control" ID="Buscador"  placeholder="" required/>
                                          <asp:Button Text="buscar" CssClass="btn btn-default" runat="server" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <table id="tableOrdenes">
                                        <thead>
                                            <tr>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:ListView runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td></td>
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
    </div>
</asp:Content>
