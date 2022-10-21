using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DeniseConiglio_WindowsFinal
{
    
        public partial class Form1 : Form
        {
            int sueldo;
            string Puesto;
            string Nombre;
            string Apellido;
            string[] dias;

            public Form1()
            {
                InitializeComponent();
            }

            private void btbValidaciones_Click(object sender, EventArgs e)
            {
                sueldo = Convert.ToInt32(txtSueldo.Text);
                Puesto = Convert.ToString(txtPuesto.Text);

                validaciones(sueldo, Puesto);

            }

            #region mis metodos

            private void validaciones(int sueldo, string Puesto)
            {
                if(sueldo>0)
                {
                    MessageBox.Show("SUELDO VALIDO");
                    if (Puesto == "desarrollador" || Puesto == "DBA" || Puesto == "soporte tecnico")
                    {
                        MessageBox.Show("PUESTO VALIDO");
                    }
                    else
                    {
                        MessageBox.Show("PUESTO INVALIDO");
                    }
                }
                else
                {
                    MessageBox.Show("SUELDO INVALIDO");
                }

            

            
            }
            #endregion

            private void btbMostrar_Click(object sender, EventArgs e)
            {
                Nombre = Convert.ToString(txtNombre.Text);
                Apellido = Convert.ToString(txtApellido.Text);
                Puesto = Convert.ToString(txtPuesto.Text);

                MessageBox.Show(Nombre.ToUpper() + " " +Apellido.ToUpper() + " "+ Puesto.ToUpper());

            }

            private void btbIngresarHoras_Click(object sender, EventArgs e)
            {
                int hsLun = Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia lunes"));
                int hsMar = Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia martes"));
                int hsMie = Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia miercoles"));
                int hsJue = Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia jueves"));
                int hsVie = Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia viernes"));

                int totalHs = hsLun + hsMar + hsMie + hsJue + hsVie;

                MessageBox.Show("Total de horas trabajadas: " + totalHs);

                int promedioHs = totalHs / 5;

                MessageBox.Show("Promedio de horas trabajadas: " + promedioHs);

                dias = new string[5];

                if(hsLun<4)
                {
                dias[0] = "lunes, ";
                }
                if (hsMar < 4)
                {
                    dias[1] = "martes, ";
                }
                if (hsMie < 4)
                {
                    dias[2] = "miercoles, ";
                }
                if (hsJue < 4)
                {
                    dias[3] = "jueves, ";
                }
                if (hsVie < 4)
                {
                    dias[4] = "viernes, ";
                }

                
                MessageBox.Show("Dias trabajando menos de 4hs: " + dias[0]+ dias[1]+ dias[2]+ dias[3]+ dias[4]);
                
                
                
                
                

            }
        
        }
}
