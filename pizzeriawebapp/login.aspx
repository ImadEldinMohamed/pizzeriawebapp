<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="pizzeriawebapp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

          <div class="container">

          <div class="row">
              <div class="col-md-4">
                  <span>inserisci il tuo username</span>
              </div>
              <div class="col-md-4"> 
                  <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
              </div>
              <div class="col-md-4">
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="scrivi il tuo nome" ControlToValidate="TextBox1">

                  </asp:RequiredFieldValidator>
          
              </div>
          </div>

           <div class="row">
    <div class="col-md-4">
        <span>inserisci la tua password</span>
    </div>
    <div class="col-md-4"> 
        <asp:TextBox ID="TextBox3"  TextMode="Password"   CssClass="form-control" runat="server"></asp:TextBox>
       

    </div>
    <div class="col-md-4">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="scrivi la tua password" ControlToValidate="TextBox1">

  </asp:RequiredFieldValidator>

    </div>
</div>
          
              <asp:Button ID="Button1" runat="server" Text="vai alla pizzeria"  OnClick="Button1_Click"/>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

      </div>

</asp:Content>
