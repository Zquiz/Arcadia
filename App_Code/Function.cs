using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Function
/// </summary>
public class Function
{
    //fields
    private readonly DbConnection _dbConnection = new DbConnection();

    /// <summary>
    /// Login method that check if it's correct info
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool Login(string username, string password)
    {
        MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbluser WHERE flduserName=?USER AND fldpassword=?PASS");

        //Replace the properties with the parameter values
        cmd.Parameters.Add("?USER", MySqlDbType.VarChar).Value = username;
        cmd.Parameters.Add("?PASS", MySqlDbType.VarChar).Value = password;

        DataTable dt = _dbConnection.GetData(cmd);

        if (dt.Rows.Count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Ask the database if the person exist. if it do return true else false
    public bool CheckUserExist(string username)
    {
        MySqlCommand check = new MySqlCommand($"select * from tblsignup where fldName='{username}'");
        DataTable checkTable = _dbConnection.GetData(check);
        if (checkTable.Rows.Count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Get all the info about who have signed up
    /// </summary>
    /// <returns></returns>
    public DataTable GetUserInfo()
    {
        MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tblsignup"));

        return _dbConnection.GetData(cmd);
    }
    /// <summary>
    /// Insert the data of who have signed up
    /// </summary>
    /// <param name="name"></param>
    /// <param name="mail"></param>
    /// <param name="highImage"></param>
    /// <param name="lowImage"></param>
    /// <param name="ghg"></param>
    public void AddSignIn(string name, string mail, string highImage, string lowImage, decimal ghg)
    {
            MySqlCommand cmd = new MySqlCommand(
                $"Insert into tblsignup(fldName, fldMail, fldLowImage, fldHighImage, fldGHG) VALUES('{name}', '{mail}', '{lowImage}', '{highImage}', '{ghg}')");
            _dbConnection.ModifyData(cmd);
      
    }
    /// <summary>
    /// Delete everyone on the table signup so it can clear the database for next ARG run if need be
    /// </summary>
    public void DeleteAllSignUp()
    {
        MySqlCommand cmd = new MySqlCommand("DELETE FROM tblsignup");
        _dbConnection.ModifyData(cmd);
    }
    /// <summary>
    /// method made to select the country info
    /// </summary>
    /// <returns></returns>
    public DataTable SelectHighScore()
    {
        MySqlCommand cmd = new MySqlCommand(string.Format("SELECT fldNumber, fldName, fldID from tblCountryStats ORDER BY fldNumber ASC limit 3"));
        return _dbConnection.GetData(cmd);
    }
    /// <summary>
    /// method to update the info. used in a old build but might come in handy
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="number"></param>
    public void UpdateHighscore(int id, string name, int number)
    {
        MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE tblCountryStats set fldName='{1}', fldNumber={2} WHERE fldID={0}", id, name, number));
        _dbConnection.ModifyData(cmd);
    }
}