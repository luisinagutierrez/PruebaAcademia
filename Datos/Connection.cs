﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Connection
    {
        SqlConnection _conn;
        public SqlConnection Conn { get { return _conn; } set { _conn = value; } }
        public void Connect()
        {
            //Conn = new SqlConnection("server=PC-LUCA;Integrated Security=false;Database=db_Academia_302_TT_2023;uid=sa;pwd=261001;");
            Conn = new SqlConnection("server=DESKTOP-5D774K5;Integrated Security=false;Database=db_Academia_302_TT_2023;uid=sa;pwd=contrasenia02;"); 
            Conn.Open();
        }
        public void Disconnect()
        {
            Conn.Close();
            Conn = null;
        }
    }
}



