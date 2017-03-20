using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Class that control the connections to the database
/// </summary>
public class DbConnection
{
    /// <summary>
    /// Mehtod that open the database, get the data and put it into a dataset
    /// </summary>
    /// <param name="myCommand"></param>
    /// <returns></returns>
    public DataTable GetData(MySqlCommand myCommand)
    {
        DataSet objDS = new DataSet();

        //Change this connection string to connect the database
        MySqlConnection objConn = new MySqlConnection("server=localhost;database=arcadia;uid=root;pwd=admin ");
        MySqlDataAdapter objDA = new MySqlDataAdapter();
        myCommand.Connection = objConn;
        objDA.SelectCommand = myCommand;

        objConn.Open();
        objDA.Fill(objDS);
        objConn.Close();

        return objDS.Tables[0];
    }
    /// <summary>
    /// Open the database, modify the data and close the connections again
    /// </summary>
    /// <param name="cmd"></param>
    public void ModifyData(MySqlCommand cmd)
    {
        //Change this connection string to connect the database
        MySqlConnection objConn = new MySqlConnection("server=localhost;database=arcadia;uid=root;pwd=admin");
        cmd.Connection = objConn;
        objConn.Open();
        cmd.ExecuteNonQuery();
        objConn.Close();
    }
}