<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script>
        function validateFloatKeyPress(el, evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode;
            var number = el.value.split('.');
            if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }

            if (number.length > 1 && charCode == 46) {
                return false;
            }
            //get the carat position
            var caratPos = getSelectionStart(el);
            var dotPos = el.value.indexOf(".");
            if (caratPos > dotPos && dotPos > -1 && (number[1].length > 1)) {
                return false;
            }
            return true;
        }

        //thanks: http://javascript.nwbox.com/cursor_position/
        function getSelectionStart(o) {
            if (o.createTextRange) {
                var r = document.selection.createRange().duplicate()
                r.moveEnd('character', o.value.length)
                if (r.text == '') return o.value.length
                return o.value.lastIndexOf(r.text)
            } else return o.selectionStart
        }

        //step 2
        window.setInterval(function() {

                if (document.getElementById('<%= upload.ClientID %>').value.trim() !== "" &&
                    document.getElementById('<%= upload2.ClientID %>').value.trim() !== "") {
                    document.getElementById('<%= Button1.ClientID %>').disabled = false;
                    document.getElementById('<%= Button1.ClientID %>').style.backgroundColor = "#02b795";
                    document.getElementById("step2dot").className = "reddot2";
                }

            },
            500);
        //step 1
        window.setInterval(function() {
                if (document.getElementById('<%= txtGHG.ClientID %>').value.trim() !== "") {
                    document.getElementById('<%= btnNext1.ClientID %>').disabled = false;
                    document.getElementById('<%= btnNext1.ClientID %>').style.backgroundColor = "#02b795";
                    document.getElementById("step1line").className = "redline";
                } else {
                    document.getElementById('<%= btnNext1.ClientID %>').disabled = true;
                    document.getElementById('<%= btnNext1.ClientID %>').style.backgroundColor = "SlateGray";
                    document.getElementById("step1line").className = "greyline";
                }
            },
            500);
        //step 3
        window.setInterval(function() {
                if (document.getElementById('<%= txtName.ClientID %>').value.trim() !== "" &&
                    document.getElementById('<%= txtEmail.ClientID %>').value.trim() !== "" &&
                    document.getElementById('<%= txtPassword.ClientID %>').value.trim() !== "") {
                    document.getElementById('<%= btnSignup.ClientID %>').disabled = false;
                    document.getElementById('<%= btnSignup.ClientID %>').style.backgroundColor = "#02b795";
                    document.getElementById("step3dot").className = "reddot2";
                } else {
                    document.getElementById('<%= btnSignup.ClientID %>').disabled = true;
                    document.getElementById('<%= btnSignup.ClientID %>').style.backgroundColor = "SlateGray";
                    document.getElementById("step3dot").className = "greydot";
                }
            },
            500);
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="Filter_overlay-Copy" style="float: left; background: url(Graphic/website3.png) no-repeat; background-size: cover;">

        <div class="A-MODEL-WORLD-TO-LIV-container">

            <div class="A-MODEL-WORLD-TO-LIV " style="float: left; width: 1100px; height: 317px;">
                <div class="StepHeader" style="float: left; font-size: 48px; text-align: left; margin-left: 138px;">A SIMPLE 3 STEP PROCESS</div>
                <div class="A-MODEL-WORLD-TO-LIV-text" style="position: absolute; float: left; font-size: 17.6px; text-align: left; line-height: 2.56; font-family: Calibri; letter-spacing: normal;  margin-left: 138px; margin-top: 78px;">
                    Here at Arcadia, we need you, the applicant, to prove their ability to fit into the lifestyle and culture of Arcadia.<br/>
                    STEP 1 | Complete a Carbon Calculator<br/>
                    STEP 2 | Show us your ability to identify high and low carbon emitting products in your life<br/>
                    STEP 3 | Create a simple profile<br/>
                    With these three steps, you will automatically be in the running!
                </div>
            </div>
        </div>
    </div>
    <div class="content">
        <div class="whiteContentfield">
            <div style="float: left; width: 100%; min-height: 300px; display: flex; flex-direction: column; justify-content: center; align-items: center;">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                    <ContentTemplate>
                        <asp:Literal ID="litBread" runat="server"></asp:Literal>
                        <asp:Literal ID="litHeader" runat="server"></asp:Literal>
                        <asp:Panel ID="pnlStep1" runat="server">
                            <div>
                                <div id="bill">
                               <iframe width="710" height="1300" frameborder="0" marginwidth="0" marginheight="0" scrolling="no" src="http://calculator.carbonfootprint.com/calculator.aspx" style="float: left; margin: 0 25px 0 0"></iframe>

                                    <div class="tipBox">
                                        <div class="tipBoxHeader">Ways to reduce your carbon footprint:</div>
                                        <div class="tipBoxUnderheader">Switch from incandescent to compact fluorescent light bulbs (CFLs)</div>
                                        <div class="tipBoxContent">Compact fluorescent light bulbs use 66% less energy and last about 10 times longer than incandescent light bulbs. Replacing a 100-watt incandescent bulb with a 25-watt CFL will save approximately $30 in electricity over the life of the bulb. Also, CFLs usually only need to be replaced every five to six years, which reduces the number of light bulbs you need to purchase.</div>
                                    </div>
                                    <div>
                                        <div class="CFtextboxheader">TONNES OF GHG PER YEAR:</div>
                                        <asp:TextBox ID="txtGHG" runat="server" CssClass="CFTextbox" Font-Size="24px" ForeColor="#39393A" AutoCompleteType="Disabled" Font-Bold="True" Font-Names="OratorStd" onkeypress="return validateFloatKeyPress(this,event);" pattern="[0-9]*" inputmode="numeric"></asp:TextBox>

                                        <asp:Button ID="btnNext1" runat="server" Text="NEXT" CssClass="Nextsignup" Font-Bold="True" Font-Names="OratorStd" Font-Size="17px" ForeColor="White" BorderStyle="None" OnClick="btnNext1_Click"/>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>

                        <asp:Panel ID="pnlStep2" runat="server" Visible="False">

                            <div style="width: 100%; display: flex; flex-direction: row; justify-content: center;">
                                <div class="signupImage" style="background: url(Graphic/signupImage1.png) no-repeat; background-size: contain;">
                                </div>
                                <div class="signupImage" style="background: url(Graphic/signupImage2.png) no-repeat; background-size: contain;">
                                </div>
                                <div class="signupImage" style="background: url(Graphic/signupImage3.png) no-repeat; background-size: contain;">
                                </div>
                                <div class="signupImage" style="margin-right: 0; background: url(Graphic/signupImage4.png) no-repeat; background-size: contain;">
                                </div>
                            </div>
                            <div>
                                <div style=" float: left;width: 72%;display: flex;flex-direction: row;justify-content: center;align-items: center;">
                                    <div style="float: left; width: 78%;">
                                        <div class="STEPTEXT">HIGH CARBON EMITTING PRODUCT</div>

                                    <div class="Imageuploadbox">
                                        <asp:FileUpload type="file" id="upload" ViewStateMode="Enabled" name="upload" accept="image/*" style="opacity: 0; width: 355px; height: 122px; float: left; position: absolute; z-index: 3;" onchange="document.getElementById('output').src = window.URL.createObjectURL(this.files[0])" runat="server"/>

                                        <img id="output" alt="" style="width: 352px; height: 119px; position: absolute; float: left; object-fit: contain;"/>
                                        <div class="Imageuploadboxmiddle">

                                            <div class="Imageuploadboxarrow"></div>
                                        </div>
                                    </div>
                                </div>
                                      <div style="float: right; width: 0%">
                                    <div class="STEPTEXT" style="width: 450px;">LOW CARBON EMITTING PRODUCT</div>
                                    <div class="Imageuploadbox">
                                        <asp:FileUpload type="file" id="upload2" name="upload2" ViewStateMode="Enabled" accept="image/*" style="opacity: 0; width: 355px; height: 122px; float: left; position: absolute; z-index: 3;" onchange="document.getElementById('output2').src = window.URL.createObjectURL(this.files[0])" runat="server"/>

                                        <img id="output2" alt="" style="width: 352px; height: 119px; position: absolute; float: left; object-fit: contain;"/>
                                        <div class="Imageuploadboxmiddle">

                                            <div class="Imageuploadboxarrow"></div>
                                        </div>
                                    </div>

                                </div>
                                
                                </div>
                                
                                

                              

                                <asp:Button ID="Button1" runat="server" Text="NEXT" CssClass="Nextsignup2" Font-Bold="True" Font-Names="OratorStd" Font-Size="17px" ForeColor="White" BorderStyle="None" OnClick="Button1_Click"/>
                            
                            </div>
                            <div style="float: left;text-align: center;width: 100%;margin-top: -108px;">
                                <asp:Label ID="Label1" runat="server" Text="" CssClass="STEPTEXT"></asp:Label>

                            </div>

                        </asp:Panel>

                        <asp:Panel ID="pnlStep3" runat="server" Visible="False">

                            <div style="float: left">
                                <div style="height: 536px; margin-top: 24px; float: left;">
                                    <div class="NAME">NAME</div>
                                    <div class="EMAIL" style="margin-top: 76px;">EMAIL</div>
                                    <div class="PASSWORD" style="margin-top: 79px;">PASSWORD</div>
                                </div>
                                <div style="float: left; height: 536px; margin-left: 20px;">
                                    <div style="margin-bottom: 35px;">
                                        <asp:TextBox ID="txtName" type="text" runat="server" CssClass="Textfield"/>
                                    </div>
                                    <div style="margin-bottom: 35px;">
                                        <asp:TextBox ID="txtEmail" type="text" runat="server" CssClass="Textfield" inputmode="email"/>
                                    </div>
                                    <div>
                                        <asp:TextBox ID="txtPassword" type="text" runat="server" CssClass="Textfield" TextMode="Password"/>
                                    </div>
                                    <div style="float: left;">
                                        <asp:Label ID="Label5" runat="server" Text="" CssClass="STEPTEXT"></asp:Label>
                                    </div>
                                </div>
                            </div>
                            <div style="float: left">

                                <div class="BE-A-PART-OF-THE-FUT" style="margin: -13px 0 130px 154px;">BE A PART OF THE FUTURE</div>
                                <div style="float: right; margin-right: 50px;" class="ipadButtonStep3">
                                    <asp:Button ID="btnSignup" runat="server" Text="DONE" CssClass="Signup" BorderStyle="None" Font-Names="OratorStd" Font-Size="Large" ForeColor="White" OnClick="btnSignup_OnClick"/>
                                </div>
                            </div>
                        </asp:Panel>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="button1"/>
                    </Triggers>

                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>