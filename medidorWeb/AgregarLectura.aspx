<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="medidorWeb.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Lecturas</h3>
                </div>
                <div class="card-body">
                   <div class="form_group">
                        <label for="id_medidorDDL">Id Medidor</label>
                        <asp:DropDownList ID="id_medidorDDL" runat="server"></asp:DropDownList>
                    </div>
                  
                    
                </div>
                   
                    <div class="form-group">
                        <label for="consumoTxt">Consumo</label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    
                  <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />

                   
                    
                 
                    
                </div>
            </div>
        </div>
    </div>











</asp:Content>
