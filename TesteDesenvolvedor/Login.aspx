
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="TesteDesenvolvedor.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <style type="text/css">
        body{
            margin-top: 8%;
            background-color: #F0F8FF;
            font-family: sans-serif;
            font-size: 1em;
            color: #ff0000;
            text-align:center;
            justify-content: center;
            
        }

        
      
        .input {
           border-radius: 5px;
           padding: 0.2em;
           border: 1px solid #0094ff;
           box-shadow: 2px 2px 2px rgba(0,0,0,0.2);
           
           text-align:center;
           
        }
        .botao {
           border-radius: 5px;
           font-size: 1.2em;
           background: #0094ff;
           border: 0;
           margin-bottom: 1em;
           color: whitesmoke;
           padding: 0.2em 0.6em;
           box-shadow: 2px 2px 2px rgba(0,0,0,0.2);
           text-shadow: 1px 1px 1px rgba(0,0,0,0.5);
           text-align:center;
           
        }

        .botao:hover{
            background: #004c82;
            box-shadow: inset 2px 2px 2px rgba(0,0,0,0.2);
            text-shadow:none;
        }

        .label{
            margin-top: 0.8em;
            color: #004c82;
            display: block;
        }

        write{
        color: #ff0000;
        }

      
        
        
        

      
        
        
    </style>
</head>
<body>
    <form runat="server">
    <div class="auto-style1">
    <br />
        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Para ter acesso aos usuarios, é necessário entrar como administrador!"></asp:Label>
        
        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Caso seja seu primeiro acesso utilize:"></asp:Label>
        
        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Administrador: admin"></asp:Label>
        
        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Senha: admin"></asp:Label>
        
        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Fique tranquilo: Você pode alterar esses dados após realizar o login!"></asp:Label>
        
        
        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Administrador:"></asp:Label>
     
        <asp:TextBox ID="TextBox1" runat="server" CssClass="input"></asp:TextBox>
        
        
        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Senha:"></asp:Label>
        
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="input"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Entrar" CssClass="botao" />
    
   
    
    </div>
        
    </form>
</body>
</html>
