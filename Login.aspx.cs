using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : Page
{
    private readonly Function _function = new Function();

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    ///     method for the logincontroller. Use the database to validate if the user exist and than send you to the cms
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        var myUser = "";
        var myPass = "";

        myUser = Login1.UserName.Replace("'", "");
        myPass = Login1.Password.Replace("'", "");
        if (!_function.CheckUserExist(myUser))
            litError.Text = "Wrong username or password";
        else if (_function.Login(myUser, myPass))
            FormsAuthentication.RedirectFromLoginPage(myUser, false);
        else
            litError.Text = "Wrong user or password";
    }
}