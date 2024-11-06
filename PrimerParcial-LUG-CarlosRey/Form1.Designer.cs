namespace PrimerParcial_LUG_CarlosRey
{
    partial class Form1
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
            btnTestDB = new Button();
            label1 = new Label();
            gbPartido = new GroupBox();
            btnGuardarPartido = new Button();
            dtpFechaPartido = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtVisitante = new TextBox();
            txtLocal = new TextBox();
            label2 = new Label();
            cmbDeporte = new ComboBox();
            txtDeporte = new Label();
            dgvPartidos = new DataGridView();
            groupBox1 = new GroupBox();
            btnActualizarDatos = new Button();
            txtMarcadorVisitante = new TextBox();
            label7 = new Label();
            txtMarcadorLocal = new TextBox();
            label6 = new Label();
            btnEliminarPartido = new Button();
            cmbIdPartidos = new ComboBox();
            label5 = new Label();
            gbPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTestDB
            // 
            btnTestDB.Location = new Point(990, 15);
            btnTestDB.Name = "btnTestDB";
            btnTestDB.Size = new Size(110, 23);
            btnTestDB.TabIndex = 0;
            btnTestDB.Text = "Test Lectura DB";
            btnTestDB.UseVisualStyleBackColor = true;
            btnTestDB.Click += btnTestDB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 16);
            label1.Name = "label1";
            label1.Size = new Size(387, 25);
            label1.TabIndex = 1;
            label1.Text = "Grilla de Partidos Registrados en la BBDDs";
            // 
            // gbPartido
            // 
            gbPartido.BackColor = Color.LightSteelBlue;
            gbPartido.Controls.Add(btnGuardarPartido);
            gbPartido.Controls.Add(dtpFechaPartido);
            gbPartido.Controls.Add(label4);
            gbPartido.Controls.Add(label3);
            gbPartido.Controls.Add(txtVisitante);
            gbPartido.Controls.Add(txtLocal);
            gbPartido.Controls.Add(label2);
            gbPartido.Controls.Add(cmbDeporte);
            gbPartido.Controls.Add(txtDeporte);
            gbPartido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPartido.Location = new Point(4, 16);
            gbPartido.Name = "gbPartido";
            gbPartido.Size = new Size(242, 207);
            gbPartido.TabIndex = 2;
            gbPartido.TabStop = false;
            gbPartido.Text = "Ingresar Nuevo Partido";
            // 
            // btnGuardarPartido
            // 
            btnGuardarPartido.BackColor = Color.ForestGreen;
            btnGuardarPartido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarPartido.ForeColor = Color.White;
            btnGuardarPartido.Location = new Point(6, 160);
            btnGuardarPartido.Name = "btnGuardarPartido";
            btnGuardarPartido.Size = new Size(230, 36);
            btnGuardarPartido.TabIndex = 8;
            btnGuardarPartido.Text = "Guardar Partido";
            btnGuardarPartido.UseVisualStyleBackColor = false;
            btnGuardarPartido.Click += btnGuardarPartido_Click;
            // 
            // dtpFechaPartido
            // 
            dtpFechaPartido.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            dtpFechaPartido.Location = new Point(9, 133);
            dtpFechaPartido.Name = "dtpFechaPartido";
            dtpFechaPartido.Size = new Size(227, 21);
            dtpFechaPartido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label4.Location = new Point(9, 114);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 6;
            label4.Text = "Fecha del partido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 5;
            label3.Text = "Equipo Visitante:";
            // 
            // txtVisitante
            // 
            txtVisitante.Font = new Font("Arial", 9F);
            txtVisitante.Location = new Point(101, 83);
            txtVisitante.Name = "txtVisitante";
            txtVisitante.Size = new Size(135, 21);
            txtVisitante.TabIndex = 4;
            // 
            // txtLocal
            // 
            txtLocal.Font = new Font("Arial", 9F);
            txtLocal.Location = new Point(101, 54);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(135, 21);
            txtLocal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(9, 57);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 2;
            label2.Text = "Equipo Local:";
            // 
            // cmbDeporte
            // 
            cmbDeporte.Font = new Font("Arial", 9F);
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(101, 25);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(135, 23);
            cmbDeporte.TabIndex = 1;
            // 
            // txtDeporte
            // 
            txtDeporte.AutoSize = true;
            txtDeporte.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            txtDeporte.Location = new Point(9, 28);
            txtDeporte.Name = "txtDeporte";
            txtDeporte.Size = new Size(46, 16);
            txtDeporte.TabIndex = 0;
            txtDeporte.Text = "Deporte:";
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(260, 44);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.Size = new Size(840, 420);
            dgvPartidos.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(btnActualizarDatos);
            groupBox1.Controls.Add(txtMarcadorVisitante);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMarcadorLocal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnEliminarPartido);
            groupBox1.Controls.Add(cmbIdPartidos);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 235);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Partidos";
            // 
            // btnActualizarDatos
            // 
            btnActualizarDatos.BackColor = Color.ForestGreen;
            btnActualizarDatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarDatos.ForeColor = Color.Transparent;
            btnActualizarDatos.Location = new Point(9, 132);
            btnActualizarDatos.Name = "btnActualizarDatos";
            btnActualizarDatos.Size = new Size(225, 39);
            btnActualizarDatos.TabIndex = 13;
            btnActualizarDatos.Text = "Actualizar Datos";
            btnActualizarDatos.UseVisualStyleBackColor = false;
            btnActualizarDatos.Click += btnActualizarDatos_Click;
            // 
            // txtMarcadorVisitante
            // 
            txtMarcadorVisitante.Font = new Font("Arial", 9F);
            txtMarcadorVisitante.Location = new Point(133, 99);
            txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            txtMarcadorVisitante.Size = new Size(101, 21);
            txtMarcadorVisitante.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(6, 101);
            label7.Name = "label7";
            label7.Size = new Size(96, 16);
            label7.TabIndex = 11;
            label7.Text = "Marcador Visitante:";
            // 
            // txtMarcadorLocal
            // 
            txtMarcadorLocal.Font = new Font("Arial", 9F);
            txtMarcadorLocal.Location = new Point(133, 72);
            txtMarcadorLocal.Name = "txtMarcadorLocal";
            txtMarcadorLocal.Size = new Size(101, 21);
            txtMarcadorLocal.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(81, 16);
            label6.TabIndex = 9;
            label6.Text = "Marcador Local:";
            // 
            // btnEliminarPartido
            // 
            btnEliminarPartido.BackColor = Color.Brown;
            btnEliminarPartido.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPartido.ForeColor = Color.Transparent;
            btnEliminarPartido.Location = new Point(9, 177);
            btnEliminarPartido.Name = "btnEliminarPartido";
            btnEliminarPartido.Size = new Size(225, 40);
            btnEliminarPartido.TabIndex = 9;
            btnEliminarPartido.Text = "Eliminar Partido";
            btnEliminarPartido.UseVisualStyleBackColor = false;
            btnEliminarPartido.Click += btnEliminarPartido_Click;
            // 
            // cmbIdPartidos
            // 
            cmbIdPartidos.FormattingEnabled = true;
            cmbIdPartidos.Location = new Point(133, 38);
            cmbIdPartidos.Name = "cmbIdPartidos";
            cmbIdPartidos.Size = new Size(101, 28);
            cmbIdPartidos.TabIndex = 10;
            cmbIdPartidos.SelectedIndexChanged += cmbIdPartidos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Underline);
            label5.Location = new Point(6, 44);
            label5.Name = "label5";
            label5.Size = new Size(108, 16);
            label5.TabIndex = 9;
            label5.Text = "ID de Partido a editar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 472);
            Controls.Add(groupBox1);
            Controls.Add(dgvPartidos);
            Controls.Add(gbPartido);
            Controls.Add(label1);
            Controls.Add(btnTestDB);
            Name = "Form1";
            Text = "Primer Examen Parcial LUG  - Carlos Rey";
            Load += Form1_Load;
            gbPartido.ResumeLayout(false);
            gbPartido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestDB;
        private Label label1;
        private GroupBox gbPartido;
        private Button btnGuardarPartido;
        private DateTimePicker dtpFechaPartido;
        private Label label4;
        private Label label3;
        private TextBox txtVisitante;
        private TextBox txtLocal;
        private Label label2;
        private ComboBox cmbDeporte;
        private Label txtDeporte;
        private DataGridView dgvPartidos;
        private GroupBox groupBox1;
        private Button btnActualizarDatos;
        private TextBox txtMarcadorVisitante;
        private Label label7;
        private TextBox txtMarcadorLocal;
        private Label label6;
        private Button btnEliminarPartido;
        private ComboBox cmbIdPartidos;
        private Label label5;
    }
}
