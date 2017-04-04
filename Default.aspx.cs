using System;
using System.Data;
using System.Web.UI;

public partial class Default : Page
{
    private readonly Function _function = new Function();
    private DataTable _dtTable;
    private int _place;
    private DataRow[] _rows;

    /// <summary>
    ///     page load event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        DrawRank();
    }

    /// <summary>
    ///     button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signup.aspx");
    }

    /// <summary>
    ///     draw the html for the rank and use the info from the database.
    /// </summary>
    protected void DrawRank()
    {
        _dtTable = _function.SelectHighScore();
        _rows = _dtTable.Select();
        _place = 0;
        litNumberInfo.Text = "";
        litNumberInfo.Text += "<div class='statContainer'>";
        foreach (var t in _rows)
        {
            _place++;
            if (_place == 1)
            {
                litNumberInfo.Text += "<div class='firstPlaceContainer'>";
                litNumberInfo.Text += "<div class='st-Place'>1st Place</div>";
                litNumberInfo.Text += "<div class='st-PlaceText'>" + t["fldName"] + "</div>";
                litNumberInfo.Text += "<div class='TONNES-OF-CO2-EM'>";
                litNumberInfo.Text += "<div class='text-style-1'><span class='COUNTER'>" + t["fldNumber"] +
                                      "</span></div>";
                litNumberInfo.Text += "<div class='text-style-2' style='margin-top:-29px;'>TONNES</div>";
                litNumberInfo.Text += "OF CO2 EMISSIONS PER CAPITA";
                litNumberInfo.Text += "</div>";
                litNumberInfo.Text += "</div>";
            }
            else if (_place == 2)
            {
                litNumberInfo.Text += "<div class='secondThreePlaceContainer'>";
                litNumberInfo.Text += "<div class='secondThreePlaceNumber'><span class='COUNTER'>" + t["fldNumber"] +
                                      "</span></div>";
                litNumberInfo.Text += "<div class='nd-Place'>2nd Place</div>";
                litNumberInfo.Text += "<div class='secondThreeCountry'>" + t["fldName"] + "</div>";
                litNumberInfo.Text += "<div class='secondThreeInfo'><span class='text-style-1'>TONNES</span>";
                litNumberInfo.Text += "<br />OF CO2 EMISSIONS PER CAPITA</div>";
                litNumberInfo.Text += "</div>";
            }
            else
            {
                litNumberInfo.Text += "<div class='secondThreePlaceContainer' style='margin-top:75px;'>";
                litNumberInfo.Text += "<div class='secondThreePlaceNumber'><span class='COUNTER'>" + t["fldNumber"] +
                                      "</span></div>";
                litNumberInfo.Text += "<div class='nd-Place'>3rd Place</div>";
                litNumberInfo.Text += "<div class='secondThreeCountry'>" + t["fldName"] + "</div>";
                litNumberInfo.Text += "<div class='secondThreeInfo'><span class='text-style-1'>TONNES</span>";
                litNumberInfo.Text += "<br />OF CO2 EMISSIONS PER CAPITA</div>";
                litNumberInfo.Text += "</div>";
            }
        }
        litNumberInfo.Text += "</div>";
    }
}