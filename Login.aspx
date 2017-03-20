<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <title>Teacher Login</title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
           <div>
               <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" Font-Bold="True" OnAuthenticate="Login1_Authenticate"></asp:Login>
                <br />
                <asp:Literal ID="litError" runat="server"></asp:Literal>
           </div>
       </div>
                
          
    </form>
</body>
</html>