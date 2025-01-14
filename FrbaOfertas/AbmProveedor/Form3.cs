﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public bool finished = false;
        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                util.execCommand("INSERT INTO Proveedor (RS,dom,ciudad,telefono,CUIT,mail,codigoPostal,rubro,contacto) " +
                                 "VALUES (@RS,@di,@ci,@te,@cu,@ma,@co,@ru,@no)",
                                                            "@RS", razonSocial.Text,
                                                            "@di", direccion.Text,
                                                            "@ci", ciudad.Text,
                                                            "@te", telefono.Text,
                                                            "@cu", CUIT.Text,
                                                            "@ma", mail.Text,
                                                            "@co", codigoPostal.Text,
                                                            "@ru", rubro.Text,
                                                            "@no", contacto.Text
                                                            );
                finished = true;
            }
            catch (SqlException er)
            {
                var newForm = new ErrorWindow();

                Console.WriteLine(er.Message + " >>>>>>>" + er.Number);
                if (er.Number == 2627)
                {
                    newForm.setText("un usuario con esos datos ya existe");
                }
                else
                {
                    newForm.setText("datos faltantes o mal ingresados"); //tira el mismo error para datos vacios y malos sql
                }

                newForm.Show();
            }
            Close();

        }
    }
}
