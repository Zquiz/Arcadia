using System;
using System.Web.Security;
using System.Web.UI;
using ASP;

public partial class Admin_Admin : MasterPage
{
    /// <summary>
    ///     Page load method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //if the user isnt logged in get redirected to homepage
        if (!Request.IsAuthenticated)
            FormsAuthentication.RedirectToLoginPage();
        //if use is logged in, show the logout button
        if (Request.IsAuthenticated)
            LoginStatus1.Visible = true;
        //the enable/disable button 
        if (Glitch.GlichEnabler)
            btnGlich.Text = "Disable Glitch";
        else if (!Glitch.GlichEnabler)
            btnGlich.Text = "Enable Glitch";
    }

    /// <summary>
    ///     Mehtod for the button, the teachers are able to diabled or enabled the glich if need be
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGlich_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
            if (Glitch.GlichEnabler)
            {
                Glitch.GlichEnabler = false;
                btnGlich.Text = "Enable Glitch";
            }
            else if (!Glitch.GlichEnabler)
            {
                Glitch.GlichEnabler = true;
                btnGlich.Text = "Disable Glitch";
            }
    }
}