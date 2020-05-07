<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ASPCrudPRESENTATION.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 79px;
        } 
        #form1 {
            height: 507px;
            width: 1191px;
        }
    </style>
</head>
<body style="height: 145px">
    <form id="form1" runat="server">
        <div style="height: 87px; width: 1189px">
            <asp:Label style="margin-left:45%" ID="Label1" runat="server" Text="CRUD" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        </div>
        <div style="height: 88px; width: 1189px">
            <asp:Label ID="Label2" runat="server" Text="Id:" Width="5%" style="text-align:center"></asp:Label>
            <asp:TextBox ID="txId" runat="server" Enabled="False" ReadOnly="True" Width="30px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Nombre:" Width="10%" style="text-align:center"></asp:Label>
            <asp:TextBox ID="txName" runat="server" Width="104px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Contraseña:" Width="10%" style="text-align:center"></asp:Label>
            <asp:TextBox ID="txPassword" runat="server" Height="17px" Width="130px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Seleccione si el estado es Activo:" Width="20%" style="text-align:center"></asp:Label>
            <asp:RadioButton ID="txState" runat="server" value="Activo"/>
            &nbsp;
            <asp:Label ID="Label6" runat="server" Text="Documento:" Width="10%" style="text-align:center"></asp:Label>
            <asp:TextBox ID="txDocument" runat="server" Height="17px" Width="130px"></asp:TextBox>
            <asp:Button ID="btAdd" runat="server" Height="36px" Text="Agregar" style="margin-left:5%" OnClick="btAdd_Click"/>
            </div>
        <div style="height: 79px">
            <asp:Button ID="btUpdate" runat="server" Height="35px" Text="Actualizar" Width="119px" style="margin-left:5%" OnClick="btUpdate_Click"/>
            <asp:Button ID="btDelete" runat="server" Height="35px" Text="Eliminar" Width="148px" style="margin-left:5%" OnClick="btDelete_Click"/>
            
        </div>
        <div>
            <asp:Label ID="Label8" runat="server" Text="Id para seleccionar datos:" Width="23%" style="text-align:center"></asp:Label>
            <asp:TextBox ID="txSelected" runat="server" Width="30px"></asp:TextBox>
            <asp:Button ID="btSelect" runat="server" Height="35px" Text="Seleccionar" Width="148px" style="margin-left:5%" OnClick="btSelect_Click"/>
        </div>
        <div style="width: 100%">
            <div style="width: 70%; display:inline-flex">
                 <asp:GridView ID="dgList" runat="server" Height="262px" Width="837px">
                 </asp:GridView>
            <div style="width: 10%; display:inline-flex"> 
                <asp:Label ID="Label7" runat="server" Text="Mensajes:" style="padding:5%"></asp:Label>
                <asp:Label ID="txMessage" runat="server" style="padding:5%"></asp:Label> 
            </div>
             </div>       
        </div>
        
    </form>
  </body>
</html>
