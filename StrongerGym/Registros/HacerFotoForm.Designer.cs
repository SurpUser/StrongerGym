﻿namespace StrongerGym.Registros
{
    partial class HacerFotoForm
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.CamarascomboBox = new System.Windows.Forms.ComboBox();
            this.HacerFotobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 96);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(612, 355);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // CamarascomboBox
            // 
            this.CamarascomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamarascomboBox.FormattingEnabled = true;
            this.CamarascomboBox.Location = new System.Drawing.Point(116, 52);
            this.CamarascomboBox.Name = "CamarascomboBox";
            this.CamarascomboBox.Size = new System.Drawing.Size(314, 21);
            this.CamarascomboBox.TabIndex = 1;
            // 
            // HacerFotobutton
            // 
            this.HacerFotobutton.Location = new System.Drawing.Point(436, 52);
            this.HacerFotobutton.Name = "HacerFotobutton";
            this.HacerFotobutton.Size = new System.Drawing.Size(75, 23);
            this.HacerFotobutton.TabIndex = 3;
            this.HacerFotobutton.Text = "Tomar";
            this.HacerFotobutton.UseVisualStyleBackColor = true;
            this.HacerFotobutton.Click += new System.EventHandler(this.HacerFotobutton_Click);
            // 
            // HacerFotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 463);
            this.Controls.Add(this.HacerFotobutton);
            this.Controls.Add(this.CamarascomboBox);
            this.Controls.Add(this.videoSourcePlayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HacerFotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomar Fotografia";
            this.Load += new System.EventHandler(this.HacerFotoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox CamarascomboBox;
        private System.Windows.Forms.Button HacerFotobutton;
    }
}