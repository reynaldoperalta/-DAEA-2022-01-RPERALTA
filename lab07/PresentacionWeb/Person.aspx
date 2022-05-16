<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="PresentacionWeb.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mx-4 my-4">
            <div class="mb-3 col-lg-5 ">
                    <asp:Label ID="Buscar" runat="server" Text="Buscar" CssClass="px-2"></asp:Label>
                    <asp:TextBox ID="txtBuscar" runat="server"  CssClass="px-2"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar"  CssClass="btn btn-success px-2" OnClick="btnBuscar_Click"/>
                    <asp:Button ID="Button2" runat="server" Text="Listar" CssClass="btn btn-primary px-2" OnClick="btnListar_Click"/>
                                 
            </div>
            <div>
                <asp:GridView ID="gvDatos" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
