<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pizzeria.aspx.cs" Inherits="pizzeriawebapp.Pizzeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <h2>scegli il tuo menu</h2>
      <h3>scegli la tua pizza</h3>

    <asp:DropDownList ID="DropDownList1" runat="server">
         <asp:ListItem Value="margherita" Text="margherita"></asp:ListItem>
         <asp:ListItem Value="4 formaggi" Text="4 formaggi"></asp:ListItem>
         <asp:ListItem Value="solo pomodoro" Text="solo pomodoro"></asp:ListItem>
         <asp:ListItem Value="frutti di mare" Text="frutti di mare"></asp:ListItem>
    </asp:DropDownList>


   <h4>aggiunte</h4>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem Value="3,00" Text="mozzarella di bufala"></asp:ListItem>
          <asp:ListItem Value="3,00" Text="prosciutto cotto"></asp:ListItem>
          <asp:ListItem Value="2,00" Text="funghi"></asp:ListItem>
          <asp:ListItem Value="2,00" Text="bacon"></asp:ListItem>
          <asp:ListItem Value="3,00" Text="salame piccante"></asp:ListItem>
          <asp:ListItem Value="3,00" Text="speck"></asp:ListItem>
    </asp:CheckBoxList>

    <asp:Button ID="Button2"  CssClass="btn btn-warning" runat="server" Text="aggiungi piatto" OnClick="Button2_Click" />
    <asp:Button ID="Button1"   CssClass="btn btn-primary"  runat="server" Text="concludi ordine" OnClick="Button1_Click" />


    <asp:Button ID="Button3" runat="server" Text="logout" OnClick="Button3_Click"  />


    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

</asp:Content>
