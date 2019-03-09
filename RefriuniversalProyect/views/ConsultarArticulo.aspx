<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarArticulo.aspx.cs" Inherits="RefriuniversalProyect.views.ConsultarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
         <div class="row">
            <div class="col-md-12">
                <div class="card card-user text-center">
                    <div class="card-header">
                        <h6>CONSULTAR ARTICULOS</h6>
                        <div class="row">
                            <div class="col-md-4 offset-4">
                                <div class="form-group">
                                    <label>REFERENCIA</label>
                                    <asp:TextBox runat="server" ID="referencia" placeholder="Referencia Articulo" CssClass="form-control" />
                                </div>
                                <asp:LinkButton Text="CONSULTAR" CssClass="btn btn-secondary" runat="server" OnClick="Unnamed_Click"/>
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
                        <table class="table table-responsive-lg">
                           <thead>
                               <tr>
                                   <th>CODIGO REPORTE</th>
                                   <th>DESC REPORTE</th>
                                   <th>FECHA REPORTE</th>
                                   <th>CODIGO ORDEN</th>
                                   <th>FECHA ORDEN</th>
                                   <th>REFERENCIA ARTICULO</th>
                                   <th>TIPO ARTICULO</th>
                                   <th>REPUESTO</th>
                                   <th>CANTIDAD</th>
                               </tr>
                           </thead>
                            <tbody>
                                <asp:ListView runat="server" id="listaArticulo">
                                    <ItemTemplate> 
                                        <tr>
                                            <td>
                                                <asp:Label Text='<%#Eval("codiREPORTE") %>' runat="server" id="codigoReporte" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("descREPORTE") %>' runat="server" id="Label1"/>
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("fechaREPORTE") %>' runat="server" id="Label2"/>
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("codiORDENSERVICIO") %>' runat="server" id="Label3" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("fechaORDENSERVICIO") %>' runat="server" id="Label4" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("refeARTICULO") %>' runat="server" id="Label5" />
                                            </td>
                                                <td>
                                                <asp:Label Text='<%#Eval("nombreTIPOARTICULO") %>' runat="server" id="Label8" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("nombPRODUCTO") %>' runat="server" id="Label6" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("cantidadREPORTE_PRODUCTO") %>' runat="server" id="Label7" />
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
