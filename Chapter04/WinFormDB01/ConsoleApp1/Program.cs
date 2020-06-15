using UnityEngine;
using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DatabaseConnection : MonoBehaviour
{
    MySqlConnection conn;
    MySqlDataAdapter dataAdapter;
    DataSet dataSet;

    void Awake()
    {
        string connectionString = "server=pascal.ccjs8el6oepb.us-east-1.rds.amazonaws.com;port=3306;database=Pascal;uid=chrina;pwd=Aa101023535.;charset=utf8";
        conn = new MySqlConnection(connectionString);

        try
        {
            conn.Open();
            ShowDBConnectionState();

            string sql = "SELECT * FROM Account";
            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);

            try
            {
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "Account") > 0)
                    Debug.Log(dataSet.Tables["Account"]);
                else
                    Debug.Log("검색된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                Debug.Log(ex.Message);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    private void ShowDBConnectionState()
    {
        if (conn.State == ConnectionState.Open)
        {
            Debug.Log("연결 성공!");
        }
        else
        {
            Debug.Log("연결 실패...");
        }
    }
}