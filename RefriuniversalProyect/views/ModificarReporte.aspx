<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ModificarReporte.aspx.cs" Inherits="RefriuniversalProyect.views.ModificarReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12" >
                <div class="card card-user">
                    <div class="card-header">
                       <div class="row">
                                <div class="col-md-3 ">
                                    <div class="form-group">   
                                        <label>Codigo</label>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="Buscador"  placeholder="" required/>                                       
                                    </div>
                                </div>
                                  <div class="col-md-2  ">
                                    <div class="form-group">      
                                        <label>Fecha min</label>
                                        <input id="fechaini" type="date" class="form-control"/>
                                    </div>
                                </div>
                                <div class="col-md-2 ">
                                     <div class="form-group">          
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
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
