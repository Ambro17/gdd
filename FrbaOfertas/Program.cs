﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>


        static string connectionString = "Data Source= localhost\\SQLSERVER2012;" +
                                 "Initial Catalog = GD2C2019; " +
                                 "User ID = gdCupon2019; Password = gd2019;";
        public static System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString);
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            con.Open();

            Application.Run(new AbmCliente.Form1());
        }
    }
}