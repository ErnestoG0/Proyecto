namespace Proyecto
{
    partial class Menu
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
            this.pb_Certificado = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_HistorialAcademico = new System.Windows.Forms.PictureBox();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnAltaBajaModificacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Certificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HistorialAcademico)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Certificado
            // 
            this.pb_Certificado.BackColor = System.Drawing.Color.Gold;
            this.pb_Certificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Certificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Certificado.Image = global::Proyecto.Properties.Resources.certificado;
            this.pb_Certificado.Location = new System.Drawing.Point(424, 79);
            this.pb_Certificado.Name = "pb_Certificado";
            this.pb_Certificado.Size = new System.Drawing.Size(119, 118);
            this.pb_Certificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Certificado.TabIndex = 0;
            this.pb_Certificado.TabStop = false;
            this.pb_Certificado.Click += new System.EventHandler(this.pb_Certificado_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Gold;
            this.btn_Salir.BackgroundImage = global::Proyecto.Properties.Resources.boton;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Location = new System.Drawing.Point(1238, 1);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(26, 25);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Control Escolar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 58);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pb_HistorialAcademico
            // 
            this.pb_HistorialAcademico.BackColor = System.Drawing.Color.Gold;
            this.pb_HistorialAcademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_HistorialAcademico.Image = global::Proyecto.Properties.Resources.carpeta;
            this.pb_HistorialAcademico.Location = new System.Drawing.Point(288, 79);
            this.pb_HistorialAcademico.Name = "pb_HistorialAcademico";
            this.pb_HistorialAcademico.Size = new System.Drawing.Size(119, 118);
            this.pb_HistorialAcademico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_HistorialAcademico.TabIndex = 4;
            this.pb_HistorialAcademico.TabStop = false;
            this.pb_HistorialAcademico.Click += new System.EventHandler(this.pb_HistorialAcademico_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.BackColor = System.Drawing.Color.Gold;
            this.btnInscripcion.BackgroundImage = global::Proyecto.Properties.Resources.inscripcion;
            this.btnInscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInscripcion.Location = new System.Drawing.Point(12, 79);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(119, 118);
            this.btnInscripcion.TabIndex = 5;
            this.btnInscripcion.UseVisualStyleBackColor = false;
            // 
            // btnAltaBajaModificacion
            // 
            this.btnAltaBajaModificacion.BackColor = System.Drawing.Color.Gold;
            this.btnAltaBajaModificacion.BackgroundImage = global::Proyecto.Properties.Resources.formulario_de_inscripcion;
            this.btnAltaBajaModificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltaBajaModificacion.Location = new System.Drawing.Point(147, 79);
            this.btnAltaBajaModificacion.Name = "btnAltaBajaModificacion";
            this.btnAltaBajaModificacion.Size = new System.Drawing.Size(119, 118);
            this.btnAltaBajaModificacion.TabIndex = 6;
            this.btnAltaBajaModificacion.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondoCertificado;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btnAltaBajaModificacion);
            this.Controls.Add(this.btnInscripcion);
            this.Controls.Add(this.pb_HistorialAcademico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pb_Certificado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Certificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HistorialAcademico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_Certificado;
        private Button btn_Salir;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pb_HistorialAcademico;
        private Button btnInscripcion;
        private Button btnAltaBajaModificacion;
    }
}