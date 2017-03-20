<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Puzzle.aspx.cs" Inherits="Puzzle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Are you there????</title>

    <style>
        body {
            background-color: black;
            height: 100px;
               Color: #1ff042;

            font-family: 'monofonto';
            text-shadow: 0px 0px 4px #1ff042;
		
        }


        @font-face {
            font-family: "monofonto";
            src: url('monofonto.ttf');
        }
        p {
            white-space: pre;
            margin: 0;
        }
     

        .textbox {
            width: 80%;
            height: 50px;
            float: right;
        }

        .button {
            width: 19%;
            float: left;
            height: 50px;
        }

        .fieldcontainer {
            bottom: 0;
            margin-top: 50px;
            position: fixed;
            width: 100%;
        }
    </style>
       <link href="css/Terminal.css" rel="stylesheet" />

       

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="js/Terminal.js"></script>
 
    <link href="css/Normalize.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
        <div>
            <asp:ScriptManager runat="server" ID="ScriptManager"></asp:ScriptManager>
          <%--  <asp:UpdatePanel runat="server">

                <ContentTemplate>--%>

                    <asp:Timer ID="Timer1" runat="server" Interval="3000" Enabled="False" OnTick="Timer1_Tick">
                    </asp:Timer>
           
                    <div id="console" class="console">
                        <span class="form"></span>
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal> 
                        <div id="cmd">
                        <span></span>
                        <div id="cursor"></div>
                    </div>
                    <input id="command" runat="server" type="text" maxlength="105"  autofocus />
                    </div>

                   
                    <div class="fieldcontainer" style="visibility: hidden;">
                        <asp:Button ID="btnSend" runat="server" Text="Answer" CssClass="button" OnClick="btnSend_OnClick"></asp:Button>
<%--                        <asp:TextBox ID="txtmsg" runat="server" CssClass="textbox"></asp:TextBox>--%>
                    </div>
                </div>
              <%--  </ContentTemplate>
            </asp:UpdatePanel>--%>
            
       
    </form>
</body>
</html>