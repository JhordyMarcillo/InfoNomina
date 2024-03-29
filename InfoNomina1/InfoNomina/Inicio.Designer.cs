﻿namespace InfoNomina
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Btn_IngresoDatos = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_CalculoSueldo = new System.Windows.Forms.Button();
            this.Btn_ConsultaCargo = new System.Windows.Forms.Button();
            this.Btn_Ordenar = new System.Windows.Forms.Button();
            this.Btn_PresentarInfo = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_IngresoDatos
            // 
            this.Btn_IngresoDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_IngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IngresoDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_IngresoDatos.Location = new System.Drawing.Point(103, 101);
            this.Btn_IngresoDatos.Name = "Btn_IngresoDatos";
            this.Btn_IngresoDatos.Size = new System.Drawing.Size(318, 81);
            this.Btn_IngresoDatos.TabIndex = 1;
            this.Btn_IngresoDatos.Text = "Ingresar un nuevo empleado";
            this.Btn_IngresoDatos.UseVisualStyleBackColor = false;
            this.Btn_IngresoDatos.Click += new System.EventHandler(this.Btn_IngresoDatos_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(103, 234);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(318, 81);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualización de datos";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_CalculoSueldo
            // 
            this.Btn_CalculoSueldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_CalculoSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CalculoSueldo.Location = new System.Drawing.Point(103, 367);
            this.Btn_CalculoSueldo.Name = "Btn_CalculoSueldo";
            this.Btn_CalculoSueldo.Size = new System.Drawing.Size(318, 81);
            this.Btn_CalculoSueldo.TabIndex = 3;
            this.Btn_CalculoSueldo.Text = "Calcular el Sueldo";
            this.Btn_CalculoSueldo.UseVisualStyleBackColor = false;
            this.Btn_CalculoSueldo.Click += new System.EventHandler(this.Btn_CalculoSueldo_Click);
            // 
            // Btn_ConsultaCargo
            // 
            this.Btn_ConsultaCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ConsultaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultaCargo.Location = new System.Drawing.Point(574, 101);
            this.Btn_ConsultaCargo.Name = "Btn_ConsultaCargo";
            this.Btn_ConsultaCargo.Size = new System.Drawing.Size(318, 81);
            this.Btn_ConsultaCargo.TabIndex = 4;
            this.Btn_ConsultaCargo.Text = "Consulta del Cargo";
            this.Btn_ConsultaCargo.UseVisualStyleBackColor = false;
            this.Btn_ConsultaCargo.Click += new System.EventHandler(this.Btn_ConsultaCargo_Click);
            // 
            // Btn_Ordenar
            // 
            this.Btn_Ordenar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ordenar.Location = new System.Drawing.Point(574, 234);
            this.Btn_Ordenar.Name = "Btn_Ordenar";
            this.Btn_Ordenar.Size = new System.Drawing.Size(318, 81);
            this.Btn_Ordenar.TabIndex = 5;
            this.Btn_Ordenar.Text = "Ordenar";
            this.Btn_Ordenar.UseVisualStyleBackColor = false;
            this.Btn_Ordenar.Click += new System.EventHandler(this.Btn_Ordenar_Click);
            // 
            // Btn_PresentarInfo
            // 
            this.Btn_PresentarInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_PresentarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PresentarInfo.Location = new System.Drawing.Point(574, 367);
            this.Btn_PresentarInfo.Name = "Btn_PresentarInfo";
            this.Btn_PresentarInfo.Size = new System.Drawing.Size(318, 81);
            this.Btn_PresentarInfo.TabIndex = 6;
            this.Btn_PresentarInfo.Text = "Presentar con info";
            this.Btn_PresentarInfo.UseVisualStyleBackColor = false;
            this.Btn_PresentarInfo.Click += new System.EventHandler(this.Btn_PresentarInfo_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(794, 511);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(192, 50);
            this.Btn_Exit.TabIndex = 7;
            this.Btn_Exit.Text = "Salir";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido a la empresa SofTech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(103, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 580);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_PresentarInfo);
            this.Controls.Add(this.Btn_Ordenar);
            this.Controls.Add(this.Btn_ConsultaCargo);
            this.Controls.Add(this.Btn_CalculoSueldo);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_IngresoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_IngresoDatos;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_CalculoSueldo;
        private System.Windows.Forms.Button Btn_ConsultaCargo;
        private System.Windows.Forms.Button Btn_Ordenar;
        private System.Windows.Forms.Button Btn_PresentarInfo;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}