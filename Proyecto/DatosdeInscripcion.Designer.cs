namespace ProcesoIncripcion
{
    partial class DatosdeInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPantallaArchivos = new System.Windows.Forms.Button();
            this.cbxReincripcion = new System.Windows.Forms.CheckBox();
            this.lblMensajeDB = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.numGrado = new System.Windows.Forms.NumericUpDown();
            this.numGrupo = new System.Windows.Forms.NumericUpDown();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(300, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gold;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(266, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 52);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPantallaArchivos
            // 
            this.btnPantallaArchivos.BackColor = System.Drawing.Color.Gold;
            this.btnPantallaArchivos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPantallaArchivos.Location = new System.Drawing.Point(69, 513);
            this.btnPantallaArchivos.Name = "btnPantallaArchivos";
            this.btnPantallaArchivos.Size = new System.Drawing.Size(121, 39);
            this.btnPantallaArchivos.TabIndex = 7;
            this.btnPantallaArchivos.Text = "Subida de Archivos";
            this.btnPantallaArchivos.UseVisualStyleBackColor = false;
            this.btnPantallaArchivos.Click += new System.EventHandler(this.btnPantallaArchivos_Click);
            // 
            // cbxReincripcion
            // 
            this.cbxReincripcion.AutoSize = true;
            this.cbxReincripcion.BackColor = System.Drawing.Color.Transparent;
            this.cbxReincripcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxReincripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.cbxReincripcion.Location = new System.Drawing.Point(65, 105);
            this.cbxReincripcion.Name = "cbxReincripcion";
            this.cbxReincripcion.Size = new System.Drawing.Size(147, 27);
            this.cbxReincripcion.TabIndex = 8;
            this.cbxReincripcion.Text = "Reincripcion";
            this.cbxReincripcion.UseVisualStyleBackColor = false;
            this.cbxReincripcion.CheckedChanged += new System.EventHandler(this.cbxReincripcion_CheckedChanged);
            this.cbxReincripcion.CheckStateChanged += new System.EventHandler(this.cbxReincripcion_CheckStateChanged);
            // 
            // lblMensajeDB
            // 
            this.lblMensajeDB.AutoSize = true;
            this.lblMensajeDB.Location = new System.Drawing.Point(332, 519);
            this.lblMensajeDB.Name = "lblMensajeDB";
            this.lblMensajeDB.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDB.TabIndex = 9;
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblAPaterno.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAPaterno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAPaterno.Location = new System.Drawing.Point(256, 187);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(167, 23);
            this.lblAPaterno.TabIndex = 10;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.BackColor = System.Drawing.Color.Transparent;
            this.lblAMaterno.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAMaterno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAMaterno.Location = new System.Drawing.Point(256, 260);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(172, 23);
            this.lblAMaterno.TabIndex = 11;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(226, 223);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(244, 23);
            this.txtAPaterno.TabIndex = 12;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(226, 297);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(244, 23);
            this.txtAMaterno.TabIndex = 13;
            // 
            // numGrado
            // 
            this.numGrado.Location = new System.Drawing.Point(242, 385);
            this.numGrado.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrado.Name = "numGrado";
            this.numGrado.Size = new System.Drawing.Size(68, 23);
            this.numGrado.TabIndex = 3;
            this.numGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrado.Visible = false;
            // 
            // numGrupo
            // 
            this.numGrupo.Location = new System.Drawing.Point(364, 385);
            this.numGrupo.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGrupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrupo.Name = "numGrupo";
            this.numGrupo.Size = new System.Drawing.Size(64, 23);
            this.numGrupo.TabIndex = 14;
            this.numGrupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrupo.Visible = false;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrado.Location = new System.Drawing.Point(242, 341);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(68, 23);
            this.lblGrado.TabIndex = 15;
            this.lblGrado.Text = "Grado";
            this.lblGrado.Visible = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrupo.Location = new System.Drawing.Point(364, 341);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(69, 23);
            this.lblGrupo.TabIndex = 16;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Gold;
            this.btnRegresar.BackgroundImage = global::Proyecto.Properties.Resources.boton_de_flecha_izquierda_del_teclado;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Location = new System.Drawing.Point(9, 11);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 50);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.BackColor = System.Drawing.Color.Gold;
            this.lblRecibo.Font = new System.Drawing.Font("Bookman Old Style", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecibo.Location = new System.Drawing.Point(65, 11);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(320, 46);
            this.lblRecibo.TabIndex = 18;
            this.lblRecibo.Text = "Recibo de Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 76);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // DatosdeInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondoCertificado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(681, 615);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecibo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.numGrupo);
            this.Controls.Add(this.numGrado);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.lblAMaterno);
            this.Controls.Add(this.lblAPaterno);
            this.Controls.Add(this.lblMensajeDB);
            this.Controls.Add(this.cbxReincripcion);
            this.Controls.Add(this.btnPantallaArchivos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "DatosdeInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Escolar";
            this.Load += new System.EventHandler(this.DatosdeInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Button btnGuardar;
        private Button btnPantallaArchivos;
        private CheckBox cbxReincripcion;
        private Label lblMensajeDB;
        private Label lblAPaterno;
        private Label lblAMaterno;
        private Label lblGrado;
        private Label lblGrupo;
        public TextBox txtAPaterno;
        public TextBox txtNombre;
        public TextBox txtAMaterno;
        public NumericUpDown numGrado;
        public NumericUpDown numGrupo;
        private Button btnRegresar;
        private Label lblRecibo;
        private PictureBox pictureBox1;
    }
}