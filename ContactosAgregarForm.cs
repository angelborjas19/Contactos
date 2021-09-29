using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class ContactosAgregarForm : Form
    {
        private int Id = 0;

        public ContactosAgregarForm()
        {
            InitializeComponent();
        }

        public ContactosAgregarForm(int id)
        {
            InitializeComponent();
            Id = id;
            Text = "Editar contacto";
            button_agregar2.Text = "Editar";
            
            Datos datos = new Datos();
            DataRow dataRow = datos.GetContacto(Id);
            if (dataRow != null)
            {
                textBox_nombre.Text = Convert.ToString(dataRow["Nombre"]);
                textBox_email.Text = Convert.ToString(dataRow["Email"]);
                textBox_telefono.Text = Convert.ToString(dataRow["Telefono"]);
                comboBox_sexo.Text = Convert.ToString(dataRow["Sexo"]);
                checkBox_MayorDeEdad.Checked = Convert.ToBoolean(dataRow["MayorDeEdad"]);
            }
        }

        private void button_agregar2_Click(object sender, EventArgs e)
        {
            string nombre = textBox_nombre.Text;
            string email = textBox_email.Text;
            string telefono = textBox_telefono.Text;
            string sexo = comboBox_sexo.Text;
            bool mayorDeEdad = checkBox_MayorDeEdad.Checked;

            if (string.IsNullOrEmpty (textBox_nombre.Text))
            {
                MessageBox.Show("El nombre que ingresaste es invalido");
                return;
            }

            if (string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("El email que ingresaste es invalido");
                return;
            }

            if (!textBox_email.Text.Contains("@"))
            {
                MessageBox.Show("El email debe contener @");
                return;
            }
            else
            {
                if (!textBox_email.Text.Contains("."))
                {
                    MessageBox.Show("El email debe contener (.)");
                    return;
                }
            }

            if (string.IsNullOrEmpty(textBox_telefono.Text))
            {
                MessageBox.Show("Ingrese el sexo");
                return;
            }

            if (!comboBox_sexo.Text.Equals("Hombre") && !comboBox_sexo.Text.Equals("Mujer"))
            {
                MessageBox.Show("Ingrese el sexo");
                return;
            }

            Datos datos = new Datos();
            if (Id > 0)
            {
                datos.Editar(nombre, email, telefono, sexo, mayorDeEdad, Id);
            }
            else
            {
                datos.Insertar(nombre, email, telefono, sexo, mayorDeEdad);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
