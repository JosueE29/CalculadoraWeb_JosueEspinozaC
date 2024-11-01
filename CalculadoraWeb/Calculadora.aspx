<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="CalculadoraWeb.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Web</title>
      <style type="text/css">
    body {
      background: rgb(81, 120, 250);
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
      <h1>
        Calculadora WEB
      </h1>
      <h2>
        Mi primera Calculadora
      </h2>
      <label>Numero 1:</label>
        <br/>
       <asp:TextBox ID="TValor1" type="number" runat="server">  </asp:TextBox>
        <br/>
        <br/>
      <label>Numero 2:</label>
            <br/>
       <asp:TextBox ID="TValor2" type="number" runat="server">  </asp:TextBox>
            <br/>
            <br/>
             <asp:Label ID="lResultado" runat="server" Text=" "></asp:Label>
             <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Red" Text=" "></asp:Label>
             <br/>
             <br/>
           <asp:Button ID="Button1" runat="server" Height="49px" Text="Aceptar" Width="115px" Font-Size="Medium" ForeColor="Red" OnClick="Button1_Click1" />
    </div>
        
       
        <asp:RadioButton ID="RadioButtonSuma" runat="server" GroupName="radio" Text="Suma" />
        <br />
        <asp:RadioButton ID="RadioButtonResta" runat="server" GroupName="radio" Text="Resta" />
        <br />
        <asp:RadioButton ID="RadioButtonDivi" runat="server" GroupName="radio" Text="Division" />
        <br />
        <asp:RadioButton ID="RadioButtonMultipicacion" runat="server" GroupName="radio" Text="Multiplicacion" />
        <br />
        <br />
        <asp:DropDownList ID="ListaDrop" runat="server" Height="18px" Width="176px">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem>Resta</asp:ListItem>
            <asp:ListItem>Division</asp:ListItem>
            <asp:ListItem>Multiplicacion</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxSuma" runat="server" Text="Suma" />
        <br />
        <asp:CheckBox ID="CheckBoxResta" runat="server" Text="Resta" />
        <br />
        <asp:CheckBox ID="CheckBoxMultiplicacion" runat="server" Text="Multiplicacion" />
        <br />
        <asp:CheckBox ID="CheckBoxDivision" runat="server" Text="Division" />
        <br />
        
       
    </form>
</body>
</html>
