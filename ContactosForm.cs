using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class ContactosForm : Form
    {
        public ContactosForm()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged(null, null);
        }

        private void refrescar()
        {
            listView1.Items.Clear();

            /*
            foreach (Contacto contacto in Contactos.Lista)
            {
                ListViewItem listViewItem = listView1.Items.Add(contacto.Nombre);
                listViewItem.SubItems.Add(contacto.Email);
                listViewItem.SubItems.Add(contacto.Sexo);

                if (contacto.MayorDeEdad)
                {
                    listViewItem.SubItems.Add("Si");
                }
                else
                {
                    listViewItem.SubItems.Add("No");
                }

            }
            */

            var datos = new Datos();
            var dataTable = datos.GetContactos();
            
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = Convert.ToInt32(dataRow["id"]);
                string nombre = Convert.ToString(dataRow["Nombre"]);
                string email = Convert.ToString(dataRow["Email"]);
                string telefono = Convert.ToString(dataRow["Telefono"]);
                string sexo = Convert.ToString(dataRow["Sexo"]);
                bool mayorDeEdad = Convert.ToBoolean(dataRow["MayorDeEdad"]);

                ListViewItem listViewItem = listView1.Items.Add(nombre);
                listViewItem.Tag = id;
                listViewItem.SubItems.Add(email);
                listViewItem.SubItems.Add(telefono);
                listViewItem.SubItems.Add(sexo);

                if (mayorDeEdad)
                {
                    listViewItem.SubItems.Add("Si");
                }
                else
                {
                    listViewItem.SubItems.Add("No");
                }

            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            ContactosAgregarForm form2 = new ContactosAgregarForm();
            form2.ShowDialog();
            refrescar();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;

            if (count == 1)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                ContactosAgregarForm form2 = new ContactosAgregarForm(id);
                form2.ShowDialog();
                refrescar();
            }

        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            int count = listView1.SelectedItems.Count;

            if (count > 0)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                datos.Eliminar(id);
                refrescar();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;

            if (count == 0)
            {
                button_agregar.Enabled = true;
                button_editar.Enabled = false;
                button_eliminar.Enabled = false;
            }

            if (!(count == 0))
            {
                button_agregar.Enabled = false;
                button_editar.Enabled = true;
                button_eliminar.Enabled = true;
            }
            if (count > 1)
            {
                button_agregar.Enabled = false;
                button_editar.Enabled = false;
                button_eliminar.Enabled = true;
            }
        }

        private void ContactosForm_Shown(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
