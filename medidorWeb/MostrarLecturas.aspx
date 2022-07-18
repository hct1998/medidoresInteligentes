<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="medidorWeb.MostrarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

               <div class="row mt-5">
                    <asp:GridView 
                        CssClass="table table-hover table-bordered"
                        ID="grillaLecturas"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros"
                        OnRowCommand="grillaLecturas_RowCommand"
      
                        runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="ID MEDIDOR" DataField="id_medidor" />
                            <asp:BoundField HeaderText="FECHA" DataField="fecha" />
                            <asp:BoundField HeaderText="CONSUMO" DataField="consumo" />
                            
                            
                            <asp:TemplateField HeaderText="Acciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btn btn-danger" runat="server"
                                        CommandName="eliminar" Text="Eliminar"
                                        CommandArgument='<%#Eval("id_lectura") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
              </ContentTemplate>
            </asp:UpdatePanel>
             

    


</asp:Content>
