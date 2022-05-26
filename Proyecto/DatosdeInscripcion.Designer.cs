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
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(346, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 52);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPantallaArchivos
            // 
            this.btnPantallaArchivos.Location = new System.Drawing.Point(33, 362);
            this.btnPantallaArchivos.Name = "btnPantallaArchivos";
            this.btnPantallaArchivos.Size = new System.Drawing.Size(121, 39);
            this.btnPantallaArchivos.TabIndex = 7;
            this.btnPantallaArchivos.Text = "Subida de Archivos";
            this.btnPantallaArchivos.UseVisualStyleBackColor = true;
            this.btnPantallaArchivos.Click += new System.EventHandler(this.btnPantallaArchivos_Click);
            // 
            // cbxReincripcion
            // 
            this.cbxReincripcion.AutoSize = true;
            this.cbxReincripcion.Location = new System.Drawing.Point(633, 122);
            this.cbxReincripcion.Name = "cbxReincripcion";
            this.cbxReincripcion.Size = new System.Drawing.Size(92, 19);
            this.cbxReincripcion.TabIndex = 8;
            this.cbxReincripcion.Text = "Reincripcion";
            this.cbxReincripcion.UseVisualStyleBackColor = true;
            this.cbxReincripcion.CheckedChanged += new System.EventHandler(this.cbxReincripcion_CheckedChanged);
            this.cbxReincripcion.CheckStateChanged += new System.EventHandler(this.cbxReincripcion_CheckStateChanged);
            // 
            // lblMensajeDB
            // 
            this.lblMensajeDB.AutoSize = true;
            this.lblMensajeDB.Location = new System.Drawing.Point(309, 412);
            this.lblMensajeDB.Name = "lblMensajeDB";
            this.lblMensajeDB.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDB.TabIndex = 9;
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAPaterno.Location = new System.Drawing.Point(323, 104);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(99, 15);
            this.lblAPaterno.TabIndex = 10;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAMaterno.Location = new System.Drawing.Point(323, 163);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(103, 15);
            this.lblAMaterno.TabIndex = 11;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(246, 122);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(244, 23);
            this.txtAPaterno.TabIndex = 12;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(246, 181);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(244, 23);
            this.txtAMaterno.TabIndex = 13;
            // 
            // numGrado
            // 
            this.numGrado.Location = new System.Drawing.Point(289, 224);
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
            this.numGrado.Size = new System.Drawing.Size(43, 23);
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
            this.numGrupo.Location = new System.Drawing.Point(414, 224);
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
            this.numGrupo.Size = new System.Drawing.Size(43, 23);
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
            this.lblGrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrado.Location = new System.Drawing.Point(291, 207);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(41, 15);
            this.lblGrado.TabIndex = 15;
            this.lblGrado.Text = "Grado";
            this.lblGrado.Visible = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.Location = new System.Drawing.Point(415, 206);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(42, 15);
            this.lblGrupo.TabIndex = 16;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.Visible = false;
            // 
            // DatosdeInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "DatosdeInscripcion";
            this.Text = "Recibo de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupo)).EndInit();
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
    }
}