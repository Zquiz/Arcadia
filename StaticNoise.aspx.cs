using System;

public partial class StaticNoise : System.Web.UI.Page
{
    /// <summary>
    /// Page load event handler. Will redirect the user after 5 seconds 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AppendHeader("Refresh", "5;URL=puzzle.aspx");
    }
}