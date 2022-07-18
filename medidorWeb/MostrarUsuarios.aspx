<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MostrarUsuarios.aspx.cs" Inherits="medidorWeb.MostrarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

               <div class="row mt-5">
                    <asp:GridView 
                        CssClass="table table-hover table-bordered"
                        ID="grillaUsuario"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros"
                        OnRowCommand="grillaUsuario_RowCommand1"
                        runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                            <asp:BoundField HeaderText="Rut" DataField="Rut" />
                            <asp:BoundField HeaderText="Correo" DataField="Correo" />
                            
                            <asp:TemplateField HeaderText="Acciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btn btn-danger" runat="server"
                                        CommandName="eliminar" Text="Eliminar"
                                        CommandArgument='<%#Eval("id_usuario") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
              </ContentTemplate>
            </asp:UpdatePanel>
             
    


























</asp:Content>
