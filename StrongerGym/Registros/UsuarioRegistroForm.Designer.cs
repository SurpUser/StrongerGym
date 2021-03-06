﻿using System.Windows.Forms;

namespace StrongerGym.Recursos
{
    partial class RegistroUsuarioForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarioForm));
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AreacomboBox = new System.Windows.Forms.ComboBox();
            this.IdUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaIniciomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.LoginportadapictureBox = new System.Windows.Forms.PictureBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.FechaIniciodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Usuariochart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginportadapictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuariochart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(259, 71);
            this.NombretextBox.MaxLength = 35;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(266, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(259, 109);
            this.ContrasenatextBox.MaxLength = 28;
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(266, 20);
            this.ContrasenatextBox.TabIndex = 0;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area:";
            // 
            // AreacomboBox
            // 
            this.AreacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreacomboBox.FormattingEnabled = true;
            this.AreacomboBox.Items.AddRange(new object[] {
            "Administrativa",
            "Empleado"});
            this.AreacomboBox.Location = new System.Drawing.Point(259, 186);
            this.AreacomboBox.Name = "AreacomboBox";
            this.AreacomboBox.Size = new System.Drawing.Size(266, 21);
            this.AreacomboBox.TabIndex = 4;
            // 
            // IdUsuariotextBox
            // 
            this.IdUsuariotextBox.Location = new System.Drawing.Point(259, 32);
            this.IdUsuariotextBox.MaxLength = 10;
            this.IdUsuariotextBox.Name = "IdUsuariotextBox";
            this.IdUsuariotextBox.Size = new System.Drawing.Size(227, 20);
            this.IdUsuariotextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "UsuarioId:";
            // 
            // FechaIniciomaskedTextBox
            // 
            this.FechaIniciomaskedTextBox.Location = new System.Drawing.Point(259, 146);
            this.FechaIniciomaskedTextBox.Mask = "00/00/0000";
            this.FechaIniciomaskedTextBox.Name = "FechaIniciomaskedTextBox";
            this.FechaIniciomaskedTextBox.ReadOnly = true;
            this.FechaIniciomaskedTextBox.Size = new System.Drawing.Size(266, 20);
            this.FechaIniciomaskedTextBox.TabIndex = 7;
            this.FechaIniciomaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::StrongerGym.Properties.Resources._1445977332_search_magnifying_glass_find;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(492, 20);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(33, 32);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::StrongerGym.Properties.Resources._1442108115_Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(259, 220);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(81, 44);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::StrongerGym.Properties.Resources._1444608937_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(346, 220);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(92, 44);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // LoginportadapictureBox
            // 
            this.LoginportadapictureBox.BackgroundImage = global::StrongerGym.Properties.Resources.user_icon;
            this.LoginportadapictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginportadapictureBox.InitialImage = null;
            this.LoginportadapictureBox.Location = new System.Drawing.Point(12, 20);
            this.LoginportadapictureBox.Name = "LoginportadapictureBox";
            this.LoginportadapictureBox.Size = new System.Drawing.Size(229, 244);
            this.LoginportadapictureBox.TabIndex = 1;
            this.LoginportadapictureBox.TabStop = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::StrongerGym.Properties.Resources._1442108658_trash;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(445, 220);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 44);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // FechaIniciodateTimePicker
            // 
            this.FechaIniciodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIniciodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIniciodateTimePicker.Location = new System.Drawing.Point(259, 146);
            this.FechaIniciodateTimePicker.Name = "FechaIniciodateTimePicker";
            this.FechaIniciodateTimePicker.Size = new System.Drawing.Size(266, 20);
            this.FechaIniciodateTimePicker.TabIndex = 8;
            // 
            // Usuariochart
            // 
            chartArea1.Name = "ChartArea1";
            this.Usuariochart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Usuariochart.Legends.Add(legend1);
            this.Usuariochart.Location = new System.Drawing.Point(531, 20);
            this.Usuariochart.Name = "Usuariochart";
            this.Usuariochart.Size = new System.Drawing.Size(265, 244);
            this.Usuariochart.TabIndex = 9;
            this.Usuariochart.Text = "chart1";
            // 
            // UsuarioerrorProvider
            // 
            this.UsuarioerrorProvider.ContainerControl = this;
            // 
            // RegistroUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 276);
            this.Controls.Add(this.Usuariochart);
            this.Controls.Add(this.FechaIniciodateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.IdUsuariotextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.AreacomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginportadapictureBox);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.LoginportadapictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuariochart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.PictureBox LoginportadapictureBox;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AreacomboBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox IdUsuariotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox FechaIniciomaskedTextBox;
        private System.Windows.Forms.Button button1;
        private Button Eliminarbutton;
        private DateTimePicker FechaIniciodateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart Usuariochart;
        private ErrorProvider UsuarioerrorProvider;
    }
}