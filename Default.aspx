<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script>
        function DisableBodyScroll(id) {

            document.body.classList.add('modal-open');

            // window.open(window.location.href + "#" + id);
        }

        function EnableBodyScroll() {
            document.body.classList.remove('modal-open');
        }
    </script>
    <div class="slideshow-container">
        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
        <div class="mySlides fade">
            <div class="Filter_overlay-Copy" style="float: left; background: url(Graphic/website1.png) no-repeat; background-size: cover;">

                <div class="A-MODEL-WORLD-TO-LIV-container">

                    <div class="A-MODEL-WORLD-TO-LIV " style="float: left;">
                        <div class="A-MODEL-WORLD-TO-LIV-text" style="position: absolute; float: left;">A MODEL WORLD TO LIVE IN</div>
                    </div>
                    <div class="ARCADIA" style="float: left;">
                        <div>ARCADIA</div>
                    </div>
                </div>
                <div style="float: left; padding: 43px 0 0 140px;">
                    <asp:Button ID="Button2" runat="server" Text="ENTER" CssClass="bannersignup" BorderStyle="None" Font-Names="OratorStd" Font-Size="36px" ForeColor="White" OnClick="Button2_Click" />
                </div>
            </div>
        </div>

        <div class="mySlides fade">
            <div class="Filter_overlay-Copy" style="float: left; background: url(Graphic/website2.png) no-repeat; background-size: cover;">

                <div class="A-MODEL-WORLD-TO-LIV-container">

                    <div class="A-MODEL-WORLD-TO-LIV " style="float: left;">
                        <div class="A-MODEL-WORLD-TO-LIV-text" style="position: absolute; float: left;">MAKE SURE ARCADIA COMES TO YOUR CITY</div>
                    </div>
                    <div class="ARCADIA" style="float: left;">
                        <div>ARCADIA</div>
                    </div>
                </div>
                <div style="float: left; padding: 43px 0 0 140px;">
                    <asp:Button ID="Button1" runat="server" Text="ENTER" CssClass="bannersignup" BorderStyle="None" Font-Names="OratorStd" Font-Size="36px" ForeColor="White" OnClick="Button2_Click" />
                </div>
            </div>
        </div>

        <div class="mySlides fade">
            <div class="Filter_overlay-Copy" style="float: left; background: url(Graphic/website3.png) no-repeat; background-size: cover;">

                <div class="A-MODEL-WORLD-TO-LIV-container">

                    <div class="A-MODEL-WORLD-TO-LIV " style="float: left;">
                        <div class="A-MODEL-WORLD-TO-LIV-text" style="position: absolute; float: left;">LIVE IN A BETTER FUTURE</div>
                    </div>
                    <div class="ARCADIA" style="float: left;">
                        <div>ARCADIA</div>
                    </div>
                </div>
                <div style="float: left; padding: 43px 0 0 140px;">
                    <asp:Button ID="Button3" runat="server" Text="ENTER" CssClass="bannersignup" BorderStyle="None" Font-Names="OratorStd" Font-Size="36px" ForeColor="White" />
                </div>
            </div>
        </div>
    </div>

    <div style="text-align: center; position: absolute; left: 49%; margin-top: 600px; z-index: 2;">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
        <span class="dot" onclick="currentSlide(3)"></span>
    </div>
    <script src="js/Slider.js"></script>
    <!--Content div box-->
    <div class="content">
        <div class="whiteContentfield">
            <div style="float: left; width: 100%; min-height: 300px; display: flex; flex-direction: column; justify-content: center; align-items: center;">
                <div class="Contentheader">Arcadia can be your new future</div>
                <div class="Contentinfo">
                    Arcadia is contained in a biodome with self-sustaining, fully recyclable and environmentally friendly technology that will build a better tomorrow and protect you from the effects of climate changes, natural disasters and any other inconveniences that the rest of the world is forced to face.<br />
                    We aim to build a model city and have narrowed down our options to these three countries for various reasons. If you would like Arcadia to come to your backyard, sign up now.
                </div>
            </div>
            <div style="float: left; width: 100%; display: flex; justify-content: center; align-items: center;">
                <div class="ContentBox" style="margin-left: 0;">

                    <a href="#myModal1" onclick="DisableBodyScroll()">
                        <div class="overlay"></div>
                        <div class="ContentImage" style="background: url(Graphic/canadasmall.jpg) no-repeat; background-size: cover;">
                        </div>
                    </a>
                    <div class="ContentImageText">CANADA</div>
                </div>

                <div class="ContentBox">

                    <a href="#myModal2" onclick="DisableBodyScroll()">
                        <div class="overlay"></div>
                        <div class="ContentImage" style="background: url(Graphic/denmarksmall.jpg) no-repeat; background-size: cover; background-position-x: -164px">
                        </div>
                    </a>
                    <div class="ContentImageText">DENMARK</div>
                </div>

                <div class="ContentBox">

                    <a href="#myModal3" onclick="DisableBodyScroll()">
                        <div class="overlay"></div>
                        <div class="ContentImage" style="background: url(Graphic/chinasmall.jpg) no-repeat; background-size: cover;">
                        </div>
                    </a>
                    <div class="ContentImageText">CHINA</div>
                </div>
            </div>
        </div>
    </div>
    <div class="blackcontentBox" style="background-image: url(Graphic/website4.png); background-size: cover;">
        <div class="blackBoxHeader">
            YOUR CARBON FOOTPRINT COUNTS
        </div>
        <div class="blackBoxUnderHeader">CO2 emissions (metric tons per capita)</div>

        <asp:Literal ID="litNumberInfo" runat="server"> </asp:Literal>

        <script src="http://cdnjs.cloudflare.com/ajax/libs/waypoints/2.0.3/waypoints.min.js"></script>
        <script src="js/jquery.counterup.min.js"></script>
        <script>
            jQuery(document).ready(function ($) {
                $('.COUNTER').counterUp({
                    delay: 10,
                    time: 2500
                });
            });
        </script>
    </div>
    <div class="content" style="background-color: #282828">
        <div class="whiteContentfield" style="margin: 0 0 0 0;">
          
                <div style="display: flex; justify-content: center; align-items: center; flex-direction:column">
                    <div class="Contentheader" style="color: white; width: 100%">ARCADIA’S FUTURISTIC DESIGN</div>
                    <div class="ThreeDimage">
                       
                                                                            <iframe width="536" height="373" src="https://sketchfab.com/models/3ed3abaacbbd4cf89153857bb96d1fd8/embed" frameborder="0" allowvr allowfullscreen mozallowfullscreen="true" webkitallowfullscreen="true" onmousewheel=""></iframe>

                         <div class="ThreeDInfo" style="color: white;">Arcadia will provides protective features that you need for you and your family. The entire city will be covered with a solar panel dome that follows the movement of the sun that will power Arcadia. Working with the best architects in the world we provide green buildings that create a beautiful city skyline along with plenty of parks to surround.</div>

                    </div>
                </div>
            </div>
        
    </div>
    <div class="blackcontentBox" style="background-color: #d8d8d8; height: 402px;">
        <div class="Bottomheadline" style="float: left">Be the first country to have the safest, cleanest and a completely self sustaining city in the world!</div>
        <div style="width: 261px; height: 70px; margin-top: 70px;">
            <asp:Button ID="Button6" runat="server" Text="ENTER" CssClass="Signupbottom" BorderStyle="None" Font-Names="OratorStd" Font-Size="36px" ForeColor="White" OnClick="Button2_Click" Width=" 261px" Height=" 70px" />
        </div>
    </div>
    <div id="myModal1" class="modalDialog">
        <div class="divinfobox">
            <a href="#close" title="Close" class="close" onclick="EnableBodyScroll()">X</a>
            <div style="background: url(Graphic/canadabig.jpg) no-repeat; background-size: cover; width: 706px; height: 247px; background-position-y: -90px; margin-bottom: 20px;"></div>
            <div class="divinfoboxtext">
                Cold weather and hockey may be internationally recognised symbols of Canada, but beyond its climate and recreation activities, this great nation full of enormous freedom and opportunity is what Arcadia is looking for.<br />
                <br />
                In a recent national air quality study by the World Health Organization, Canada placed third for the cleanest air on the planet. This fresh country is also a geographically diverse country and boasts some of the most beautiful geology in the world. Just like the diversity of geography, multiculturalism in Canada is the belief that one can feel a sense of belonging to Canada without denying their ancestral culture.  Canada is ranked among the world’s top countries regarding its integration of immigrants.<br />
                <br />
                This gorgeous land is also full of opportunities, and presents a high life standard. Canada has a high employment rate according to OECD, and there will be even more opportunities in the future. Between now and 2021, a million jobs are expected to go unfilled in Canada.<br />
                <br />
                Not to mention that Canada is also an eco-friendly country. In a large scale, 79% of Canada’s electricity comes from eco-friendly, non-greenhouse gas emitting sources. Regulations were put in place that will limit emissions from cars and small trucks built after 2016. In a macro scale, more and more Canadians are walking to work.  More and more house owners concern about the energy efficiency and most of the Canadians have good understanding of waste disposal and recycling.<br />
                <br />
                No matter what you are looking for in a country, there is always a place in Canada that satisfies your needs. The diversity harmony and eco-friendly of the country are a true match to the concept of Arcadia.
            </div>
        </div>
    </div>
    <div id="myModal2" class="modalDialog">
        <div class="divinfobox">
            <a href="#close" title="Close" class="close" onclick="EnableBodyScroll()">X</a>

            <div style="background: url(Graphic/denmarkbig.jpg) no-repeat; background-size: cover; width: 706px; height: 247px; background-position-y: -90px; margin-bottom: 20px;"></div>

            <div class="divinfoboxtext">
                Denmark is often referred to as one of the greenest countries by the European Environment Commission, and the “world’s happiest country” according to UN's first World Happiness Report.
            <br />
                <br />
                Denmark has a beautiful countryside with low crime rate. Additionally, clean beaches and green forests are rarely more than a half hour’s drive away.  Your children can roam freely and safely, while you explore all the many cultural and artistic offerings available.
            <br />
                <br />
                This beautiful land is also full of opportunities. Denmark is one of the best countries to do business. It scored particularly well for freedom (personal and monetary) and low corruption. The regulatory climate is one of the world’s “most transparent and efficient,” according to the Heritage Foundation.
            <br />
                <br />
                Last but not least, Denmark’s government has a similar vision of the green city as Arcadia. Denmark's government plays a leading role in pushing for the use of green and sustainable energy. Since 1980, Denmark has grown to become a global leader in the development of new sustainable technologies and solutions. During the same period, the Danish economy has grown by almost 80 percent without increasing gross energy consumption. 30% of the country’s power production comes from wind energy, and the aim is to cover all energy supplies with green energy by 2050.
            <br />
                <br />
                With modern market economy, advanced industry with world-leading firms in pharmaceuticals, maritime shipping, gorgeous landscape  and renewable energy, Denmark is definitely one of the most competitive candidates.
            </div>
        </div>
    </div>

    <div id="myModal3" class="modalDialog">
        <div class="divinfobox">
            <a href="#close" title="Close" class="close" onclick="EnableBodyScroll()">X</a>

            <div style="background: url(Graphic/chinabig.jpg) no-repeat; background-size: cover; width: 706px; height: 247px; background-position-y: -90px; margin-bottom: 20px;"></div>

            <div class="divinfoboxtext">
                Denmark is often referred to as one of the greenest countries by the European Environment Commission, and the “world’s happiest country” according to UN's first World Happiness Report.
            <br />
                <br />
                Denmark has a beautiful countryside with low crime rate. Additionally, clean beaches and green forests are rarely more than a half hour’s drive away.  Your children can roam freely and safely, while you explore all the many cultural and artistic offerings available.
            <br />
                <br />
                This beautiful land is also full of opportunities. Denmark is one of the best countries to do business. It scored particularly well for freedom (personal and monetary) and low corruption. The regulatory climate is one of the world’s “most transparent and efficient,” according to the Heritage Foundation.
            <br />
                <br />
                Last but not least, Denmark’s government has a similar vision of the green city as Arcadia. Denmark's government plays a leading role in pushing for the use of green and sustainable energy. Since 1980, Denmark has grown to become a global leader in the development of new sustainable technologies and solutions. During the same period, the Danish economy has grown by almost 80 percent without increasing gross energy consumption. 30% of the country’s power production comes from wind energy, and the aim is to cover all energy supplies with green energy by 2050.
            <br />
                <br />
                With modern market economy, advanced industry with world-leading firms in pharmaceuticals, maritime shipping, gorgeous landscape  and renewable energy, Denmark is definitely one of the most competitive candidates.
            </div>
        </div>
    </div>
</asp:Content>