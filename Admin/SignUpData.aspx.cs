using System;
using System.Web.UI;

public partial class Admin_SignUpData : Page
{
    private readonly Function _myFunction = new Function();

    /// <summary>
    ///     Page load method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //if not is a postback bind the griwview with the database
        if (!IsPostBack)
        {
            GridView1.DataSource = _myFunction.GetUserInfo();
            GridView1.DataBind();
        }
    }

    /// <summary>
    ///     button event handler to delete everything from the database and bind the info again
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        _myFunction.DeleteAllSignUp();
        GridView1.DataSource = _myFunction.GetUserInfo();
        GridView1.DataBind();
    }
}