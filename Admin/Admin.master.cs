using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class Admin_Admin : System.Web.UI.MasterPage
{
    /// <summary>
    /// Page load method 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //if the user isnt logged in get redirected to homepage
        if (!Request.IsAuthenticated)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
        //if use is logged in, show the logout button
        if (Request.IsAuthenticated)
        {
            LoginStatus1.Visible = true;
        }
        //the enable/disable button 
        if (Glich.GlichEnabler)
            btnGlich.Text = "Disable glich";
        else if (!Glich.GlichEnabler)
        {
            btnGlich.Text = "Enable glich";
        }
    }
    /// <summary>
    /// Mehtod for the button, the teachers are able to diabled or enabled the glich if need be
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGlich_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (Glich.GlichEnabler)
            {
                Glich.GlichEnabler = false;
                btnGlich.Text = "Enable glich";
            }
            else if (!Glich.GlichEnabler)
            {
                Glich.GlichEnabler = true;
                btnGlich.Text = "Disable glich";
            }
        }
    }
}