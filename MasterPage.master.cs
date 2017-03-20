using System;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    /// <summary>
    /// button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signup.aspx");
    }
    /// <summary>
    /// Method that will overrid the oninit and give the correct css and metatag for the system people are seeing the webpage in
    /// </summary>
    /// <param name="e"></param>
    protected override void OnInit(EventArgs e)
    {
        var css = new HtmlLink();
        var meta = new HtmlMeta();
        if (Request.UserAgent.IndexOf("Intel Mac OS X") > 0)
        {
            css.Href = ResolveClientUrl("css/mac.css");
            css.Attributes["rel"] = "stylesheet";
            css.Attributes["type"] = "text/css";
            css.Attributes["media"] = "all";
            meta.Name = "viewport";
            meta.Content = "width=device-width, maximum-scale=1.0";
            Page.Header.Controls.Add(meta);
            Page.Header.Controls.Add(css);
        }
        else if (Request.UserAgent.Contains("iPad"))
        {
            css.Href = ResolveClientUrl("css/ipad.css");
            css.Attributes["rel"] = "stylesheet";
            css.Attributes["type"] = "text/css";
            css.Attributes["media"] = "all";
            Page.Header.Controls.Add(css);
            meta.Name = "viewport";
            meta.Content = "width=device-width, maximum-scale=1.0";
            Page.Header.Controls.Add(meta);
        }
        else
        {
            css.Href = ResolveClientUrl("css/StyleSheet.css");
            css.Attributes["rel"] = "stylesheet";
            css.Attributes["type"] = "text/css";
            css.Attributes["media"] = "all";
            meta.Name = "viewport";
            meta.Content = "width=device-width, maximum-scale=1.0";
            Page.Header.Controls.Add(meta);
            Page.Header.Controls.Add(css);
        }
    }
}