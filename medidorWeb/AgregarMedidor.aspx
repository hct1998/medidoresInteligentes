<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="medidorWeb.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Medidores</h3>
                </div>
                            
                    <div class="form-group">
                        <label for="num_medidorTxt">Numero de serie medidor</label>
                        <asp:TextBox ID="num_medidorTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    


                   
                  <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />

                   
                    
                 
                    
                </div>
            </div>
        </div>
    </div>










</asp:Content>
