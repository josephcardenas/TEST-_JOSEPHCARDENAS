using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using DATOS;


namespace FORMULARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Persona Persona = new Persona();
            Persona.Nombre = textBoxNombre.Text;
            Persona.Apellido = textBoxApellido.Text;

            Persona.Razon = comboBoxRazon.Text;
            Persona.Aplicale = checkBoxAplicale.Text;


            int resultado = BDPersona.Agregar(Persona);

            if (resultado > 0)
            {
                MessageBox.Show("Datos guardados Correctamente");
            }



        }
    }
}
