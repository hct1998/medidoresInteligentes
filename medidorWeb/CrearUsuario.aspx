<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="medidorWeb.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Usuarios</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="rutTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar el Rut"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="apellidoTxt">Apellido</label>
                        <asp:TextBox ID="apellidoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="correoTxt">Correo</label>
                        <asp:TextBox ID="correoTxt"  CssClass="form-control" runat="server"></asp:TextBox>
                        
                    </div>

                    <div class="form-group">
                        <label for="passwordTxt">Password</label>
                        <asp:TextBox ID="passwordTxt"  CssClass="form-control" runat="server"></asp:TextBox>
                        
                    </div>
                    
                   
                   
                    
                    <asp:Button runat="server" CssClass="btn btn-primary" OnClick="agregarBtn_Click" ID="agregarBtn" Text="Agregar" />
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
