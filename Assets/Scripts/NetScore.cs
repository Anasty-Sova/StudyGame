using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;
using System;
using System.IO;

public class NetScore : MonoBehaviour
{
  
  public Text txt;
  string strtr = "Server=localhost;Port=3306;Database=denisgame;User ID=root;Password=;CharSet=utf8;";
  public void Top(){
      MySqlConnection SqlConn = new MySqlConnection(strtr);
      SqlConn.Open();
      MySqlCommand topCommand = new MySqlCommand("SELECT * FROM test ORDER BY score DESC LIMIT 10",SqlConn);
      MySqlDataReader MyReader = topCommand.ExecuteReader();
      while(MyReader.Read()){
         txt.text += MyReader["name"].ToString() + " :" + MyReader["score"].ToString() + System.Environment.NewLine;
      }
      MyReader.Close();
      SqlConn.Close();
      }

}
