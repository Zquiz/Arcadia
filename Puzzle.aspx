<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Puzzle.aspx.cs" Inherits="Puzzle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Are you there????</title>

       <link href="css/Terminal.css" rel="stylesheet" />

       

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="js/Terminal.js"></script>
 <script>
     $('body').click(function () {
         $('#textfield').find('command').focus(); // works well on  ipad 
     });
 </script>
    <link href="css/Normalize.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <div id="textarea">
            <asp:ScriptManager runat="server" ID="ScriptManager"></asp:ScriptManager>
      
                    <asp:Timer ID="Timer1" runat="server" Interval="3000" Enabled="False" OnTick="Timer1_Tick">
                    </asp:Timer>
           
                    <div id="console" class="console">
                        <span class="form"></span>
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal> 
                        <div id="cmd">
                        <span></span>
                        <div id="cursor"></div>
                    </div>
                                <div id="textfield"><input id="command" runat="server" style="height: 100%; width: 100%;" type="text" maxlength="105" /></div>

                    </div>

                   
                    <div class="fieldcontainer" style="visibility: hidden;">
                        <asp:Button ID="btnSend" runat="server" Text="Answer" CssClass="button" OnClick="btnSend_OnClick"></asp:Button>

                    </div>
                </div>
          
            
       
    </form>
</body>
</html>