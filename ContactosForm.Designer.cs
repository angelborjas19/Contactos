
namespace Prueba1
{
    partial class ContactosForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_eliminar.Location = new System.Drawing.Point(619, 70);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 0;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_editar.Location = new System.Drawing.Point(619, 41);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 0;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_agregar.Location = new System.Drawing.Point(619, 12);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 0;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 426);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 212;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sexo";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mayor de Edad";
            this.columnHeader4.Width = 126;
            // 
            // ContactosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_eliminar);
            this.Name = "ContactosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.Shown += new System.EventHandler(this.ContactosForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

