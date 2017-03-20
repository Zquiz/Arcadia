<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaticNoise.aspx.cs" Inherits="StaticNoise" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--[if lt IE 9]>
<script>
	document.createElement('video');
</script>
<![endif]-->
    <title>23 rp2r89 q9rg2489rt </title>
    <link href="css/MainCSS.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <video playsinline autoplay muted loop poster="Graphic/staticnoise.png" id="bgvid">
                <source src="Graphic/Video/videoplayback.webm" type="video/webm">
                <source src="Graphic/Video/videoplayback.mp4" type="video/mp4">
            </video>
        </div>
    </form>
</body>
</html>