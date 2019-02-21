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
                            <h5>BUSCAR ORDENES</h5>
                        </div>
                        <div class="card-body">
                           <div class="row">
                                <div class="col-md-3 ">
                                    <div class="text-center">   
                                        <label>Codigo</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="Buscador"  placeholder="" required/>                                       
                                    </div>
                                </div>
                                  <div class="col-md-2 ">
                                    <div class="text-center">           
                                        <label>Fecha min</label>
                                        <input id="fechaini" type="date" class="form-control"/>
                                    </div>
                                </div>
                                <div class="col-md-2 ">
                                    <div class="text-center">           
                                        <label>Fecha max</label>
                                        <input id="fechamax" type="date" class="form-control"/>
                                    </div>
                                </div>
                                <div class="col-md-2 ">
                                    <div class="text-center">                                                                                
                                        <asp:Button Text="BUSCAR" CssClass="btn btn-info" runat="server" />
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
