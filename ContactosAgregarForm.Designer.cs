
namespace Prueba1
{
    partial class ContactosAgregarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_MayorDeEdad = new System.Windows.Forms.CheckBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_agregar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(62, 35);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(236, 20);
            this.textBox_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(62, 9);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(236, 20);
            this.textBox_nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_MayorDeEdad
            // 
            this.checkBox_MayorDeEdad.Location = new System.Drawing.Point(62, 88);
            this.checkBox_MayorDeEdad.Name = "checkBox_MayorDeEdad";
            this.checkBox_MayorDeEdad.Size = new System.Drawing.Size(104, 20);
            this.checkBox_MayorDeEdad.TabIndex = 3;
            this.checkBox_MayorDeEdad.Text = "Mayor de Edad";
            this.checkBox_MayorDeEdad.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cancelar.Location = new System.Drawing.Point(155, 114);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_agregar2
            // 
            this.button_agregar2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_agregar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_agregar2.Location = new System.Drawing.Point(74, 114);
            this.button_agregar2.Name = "button_agregar2";
            this.button_agregar2.Size = new System.Drawing.Size(75, 23);
            this.button_agregar2.TabIndex = 4;
            this.button_agregar2.Text = "Agregar";
            this.button_agregar2.UseVisualStyleBackColor = false;
            this.button_agregar2.Click += new System.EventHandler(this.button_agregar2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_sexo
            // 
            this.comboBox_sexo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sexo.FormattingEnabled = true;
            this.comboBox_sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBox_sexo.Location = new System.Drawing.Point(62, 61);
            this.comboBox_sexo.Name = "comboBox_sexo";
            this.comboBox_sexo.Size = new System.Drawing.Size(68, 21);
            this.comboBox_sexo.TabIndex = 2;
            // 
            // ContactosAgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 144);
            this.Controls.Add(this.comboBox_sexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_agregar2);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.checkBox_MayorDeEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactosAgregarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_MayorDeEdad;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_agregar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_sexo;
    }
}