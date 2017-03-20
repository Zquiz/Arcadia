using System;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.UI.HtmlControls;

using ASP;

public partial class Signup : System.Web.UI.Page
{
    //Reason fields are static is because of the update panels postback
    private static int _step;
    private readonly Function _myFunction = new Function();
    private static HttpPostedFile _uploadName;
    private static HttpPostedFile _upload2Name;
    private static int _ghgNumber;

    /// <summary>
    /// page load method that will make sure it panels and textboxs is reset if needed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        this.Page.Form.Enctype = "multipart/form-data";
        pnlStep2.Enabled = false;
        pnlStep3.Enabled = false;
        btnNext1.Enabled = false;
        Button1.Enabled = false;
        txtEmail.Text = "";
        txtGHG.Text = "";
        txtName.Text = "";
      
        txtPassword.Attributes["value"] = txtPassword.Text;

        btnNext1.BackColor = Color.SlateGray;
        Button1.BackColor = Color.SlateGray;

        btnSignup.Enabled = false;
        btnSignup.BackColor = Color.SlateGray;

        _step = 0;
        DrawBread();
        DrawStepText();
    }
    /// <summary>
    /// Make sure the form have the right data when render
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        HtmlForm form = this.Page.Form;
        if ((form != null) && (form.Enctype.Length == 0))
        {
            form.Enctype = "multipart/form-data";
        }
    }
    /// <summary>
    /// Draw the html for the step text
    /// </summary>
    protected void DrawStepText()
    {
        litHeader.Text = "";
        switch (_step)
        {
            case 0:
                litHeader.Text += "<div class='steptextcontainer'>";
                litHeader.Text += "<div class='STEPTEXT'>STEP 1</div>";
                litHeader.Text += "<div class='Stepundertext'>Identify your carbon footprint calculator</div>";
                litHeader.Text += "</div>";
                break;

            case 1:
                litHeader.Text += "<div class='steptextcontainer'>";
                litHeader.Text += "<div class='STEPTEXT'>STEP 2</div>";
                litHeader.Text += "<div class='Stepundertext'>Upload a picture of yoursef (selfie) with one high and one low carbon emitting product in your life</div>";
                litHeader.Text += "</div>";
                break;

            case 2:
                litHeader.Text += "<div class='steptextcontainer'>";
                litHeader.Text += "<div class='STEPTEXT'>STEP 3</div>";
                litHeader.Text += "<div class='Stepundertext'>Fill out the form below and you’re all done!</div>";
                litHeader.Text += "</div>";
                break;
        }
    }
    /// <summary>
    /// dare the breadcrumbs so the user can see how long they are
    /// </summary>
    protected void DrawBread()
    {
        litBread.Text = "";
        switch (_step)
        {
            case 0:
                litBread.Text += "<div class='breadcontainer'>";
                litBread.Text += "<div class='reddot'></div>";
                litBread.Text += "<div id='step1line' class='greyline'></div>";
                litBread.Text += "<div class='greydot'></div>";
                litBread.Text += "<div class='greyline'></div>";
                litBread.Text += "<div class='greydot'></div>";
                litBread.Text += "</div>";
                break;

            case 1:
                litBread.Text += "<div class='breadcontainer'>";
                litBread.Text += "<div class='reddot'></div>";
                litBread.Text += "<div class='redline'></div>";
                litBread.Text += "<div id='step2dot' class='greydot'></div>";
                litBread.Text += "<div class='greyline'></div>";
                litBread.Text += "<div class='greydot'></div>";
                litBread.Text += "</div>";
                break;

            case 2:
                litBread.Text += "<div class='breadcontainer'>";
                litBread.Text += "<div class='reddot'></div>";
                litBread.Text += "<div class='redline'></div>";
                litBread.Text += "<div class='reddot' style='margin-left:28.5px;'></div>";
                litBread.Text += "<div class='redline'></div>";
                litBread.Text += "<div id='step3dot' class='greydot'></div>";
                litBread.Text += "</div>";
                break;

            case 3:
                litBread.Text += "<div class='breadcontainer'>";
                litBread.Text += "<div class='reddot'></div>";
                litBread.Text += "<div class='redline'></div>";
                litBread.Text += "<div class='reddot' style='margin-left:28.5px;'></div>";
                litBread.Text += "<div class='redline'></div>";
                litBread.Text += "<div class='reddot' style='margin-right:0; margin-left:28.5px;'></div>";
                litBread.Text += "</div>";
                break;
        }
    }
    /// <summary>
    /// THe first button event handler for step 1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnNext1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtGHG.Text))
        {
            _ghgNumber = Convert.ToInt32(txtGHG.Text);
            PanelChanger();
            DrawBread();
            DrawStepText();
        }
    }
    /// <summary>
    /// Method to change the panel when called
    /// </summary>
    protected void PanelChanger()
    {
        _step++;
        switch (_step)
        {
            case 1:
                pnlStep1.Visible = false;
                pnlStep1.Enabled = false;
                pnlStep2.Visible = true;
                pnlStep2.Enabled = true;
                break;

            case 2:
                pnlStep2.Visible = false;
                pnlStep2.Enabled = false;
                pnlStep3.Visible = true;
                pnlStep3.Enabled = true;
                break;
        }
    }
    /// <summary>
    /// step 2 button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        _uploadName = Request.Files["upload"];
        _upload2Name = Request.Files["upload2"];
        PanelChanger();
        DrawBread();
        DrawStepText();
    }
    /// <summary>
    /// Last step button event handler 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSignup_OnClick(object sender, EventArgs e)
    {
        if (txtEmail.Text != "" && txtName.Text != "" && txtPassword.Text != "")
        {
            if (MailValidator.EmailIsValid(txtEmail.Text))
            {
                _myFunction.AddSignIn(txtName.Text, txtEmail.Text, ImageUpload().Item1, ImageUpload().Item2,_ghgNumber);
                if (Glich.GlichEnabler)
                {
                    _step = 0;
                    txtEmail.Text = "";
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Attributes["value"] = "";
                    _uploadName = null;
                    _upload2Name = null;
                    Response.Redirect("~/StaticNoise.aspx");
                }

                if (!Glich.GlichEnabler)
                {
                    _step = 0;
                    txtEmail.Text = "";
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Attributes["value"] = "";
                    _uploadName = null;
                    _upload2Name = null;
                    Response.Redirect("Default.aspx");

                    Label5.Text = "Thank you for supporting Arcadia. We will contact you soon with further info";
                }
            }
            else
            {
                Label5.Text = "Insert a valid mail";
            }
        }
        else
        {
            Label5.Text = "Incorrect info, please enter info in all the fields";
        }
    }
    /// <summary>
    /// Tuple with 2 return value for the upload image info. So the last step can set the correct name on the image
    /// </summary>
    /// <returns></returns>
    protected Tuple<string, string> ImageUpload()
    {
        string highfileName = "";

        string lowFileName = "";

        //check if files was submitted
        if (_uploadName != null && _uploadName.ContentLength > 0 && _upload2Name != null && _upload2Name.ContentLength > 0)
        {
            //high save method
            string fileNameExtension = Path.GetExtension(_uploadName.FileName);
            string highName = $"high{txtName.Text}{fileNameExtension}";
            _uploadName.SaveAs(Server.MapPath(Path.Combine("~/Image_Upload/", highName)));
            highfileName = $"~/Image_Upload/high{txtName.Text}{fileNameExtension}";
            //low save method
            string lowfileNameExtension = Path.GetExtension(_upload2Name.FileName);
            string lowName = $"low{txtName.Text}.{lowfileNameExtension}";
            _upload2Name.SaveAs(Server.MapPath(Path.Combine("~/Image_Upload/", lowName)));
            lowFileName = $"~/Image_Upload/low{txtName.Text}{lowfileNameExtension}";
        }
        return Tuple.Create(highfileName, lowFileName);
    }
}