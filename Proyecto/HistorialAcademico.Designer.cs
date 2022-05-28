namespace Proyecto
{
    partial class HistorialAcademico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscarh = new System.Windows.Forms.Button();
            this.txt_curph = new System.Windows.Forms.TextBox();
            this.pb_RegresarMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridHA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RegresarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial Academico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURP ";
            // 
            // btn_buscarh
            // 
            this.btn_buscarh.Location = new System.Drawing.Point(12, 621);
            this.btn_buscarh.Name = "btn_buscarh";
            this.btn_buscarh.Size = new System.Drawing.Size(166, 48);
            this.btn_buscarh.TabIndex = 2;
            this.btn_buscarh.Text = "Buscar...";
            this.btn_buscarh.UseVisualStyleBackColor = true;
            this.btn_buscarh.Click += new System.EventHandler(this.btn_buscarh_Click_1);
            // 
            // txt_curph
            // 
            this.txt_curph.Location = new System.Drawing.Point(12, 174);
            this.txt_curph.Name = "txt_curph";
            this.txt_curph.Size = new System.Drawing.Size(166, 23);
            this.txt_curph.TabIndex = 3;
            this.txt_curph.TextChanged += new System.EventHandler(this.txt_curph_TextChanged);
            // 
            // pb_RegresarMenu
            // 
            this.pb_RegresarMenu.BackColor = System.Drawing.Color.Gold;
            this.pb_RegresarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_RegresarMenu.Image = global::Proyecto.Properties.Resources.boton_de_flecha_izquierda_del_teclado;
            this.pb_RegresarMenu.Location = new System.Drawing.Point(12, 12);
            this.pb_RegresarMenu.Name = "pb_RegresarMenu";
            this.pb_RegresarMenu.Size = new System.Drawing.Size(50, 50);
            this.pb_RegresarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_RegresarMenu.TabIndex = 4;
            this.pb_RegresarMenu.TabStop = false;
            this.pb_RegresarMenu.Click += new System.EventHandler(this.pb_RegresarMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 72);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridHA
            // 
            this.dataGridHA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHA.Location = new System.Drawing.Point(195, 174);
            this.dataGridHA.Name = "dataGridHA";
            this.dataGridHA.RowTemplate.Height = 25;
            this.dataGridHA.Size = new System.Drawing.Size(1057, 495);
            this.dataGridHA.TabIndex = 6;
            this.dataGridHA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHA_CellContentClick);
            // 
            // HistorialAcademico
            // 
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondoCertificado;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridHA);
            this.Controls.Add(this.pb_RegresarMenu);
            this.Controls.Add(this.txt_curph);
            this.Controls.Add(this.btn_buscarh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HistorialAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_RegresarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_buscarh;
        private TextBox txt_curph;
        private PictureBox pb_RegresarMenu;
        private PictureBox pictureBox2;
        private DataGridView dataGridHA;
    }
}