namespace CaidaPresion
{
    partial class frmOtrosResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtrosResultados));
            dgOtrosResultados = new DataGridView();
            idOtro = new DataGridViewTextBoxColumn();
            PrimerTermino = new DataGridViewTextBoxColumn();
            ReynoldEnjambre = new DataGridViewTextBoxColumn();
            SegundoTermino = new DataGridViewTextBoxColumn();
            TercerTermino = new DataGridViewTextBoxColumn();
            FuncionObjetivo = new DataGridViewTextBoxColumn();
            DiametroBurbuja = new DataGridViewTextBoxColumn();
            resultado_id = new DataGridViewTextBoxColumn();
            dgResultados = new DataGridView();
            panel18 = new Panel();
            btnExportar = new Button();
            label5 = new Label();
            cmbConcentracion = new ComboBox();
            label10 = new Label();
            cmbEspumante = new ComboBox();
            customPanel1 = new Controles.CustomPanel();
            customPanel2 = new Controles.CustomPanel();
            id = new DataGridViewTextBoxColumn();
            Jg = new DataGridViewTextBoxColumn();
            DeltaP = new DataGridViewTextBoxColumn();
            Jsl = new DataGridViewTextBoxColumn();
            Holdup = new DataGridViewTextBoxColumn();
            Db = new DataGridViewTextBoxColumn();
            Ub = new DataGridViewTextBoxColumn();
            Usg = new DataGridViewTextBoxColumn();
            Reb = new DataGridViewTextBoxColumn();
            concentracion_id = new DataGridViewTextBoxColumn();
            concentracion = new DataGridViewTextBoxColumn();
            espumante_id = new DataGridViewTextBoxColumn();
            espumante = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgOtrosResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgResultados).BeginInit();
            panel18.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgOtrosResultados
            // 
            dgOtrosResultados.AllowUserToAddRows = false;
            dgOtrosResultados.AllowUserToDeleteRows = false;
            dgOtrosResultados.BackgroundColor = Color.FromArgb(42, 46, 50);
            dgOtrosResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOtrosResultados.Columns.AddRange(new DataGridViewColumn[] { idOtro, PrimerTermino, ReynoldEnjambre, SegundoTermino, TercerTermino, FuncionObjetivo, DiametroBurbuja, resultado_id });
            dgOtrosResultados.Dock = DockStyle.Fill;
            dgOtrosResultados.Location = new Point(0, 0);
            dgOtrosResultados.Margin = new Padding(4, 5, 4, 5);
            dgOtrosResultados.Name = "dgOtrosResultados";
            dgOtrosResultados.ReadOnly = true;
            dgOtrosResultados.RowHeadersVisible = false;
            dgOtrosResultados.RowHeadersWidth = 62;
            dgOtrosResultados.Size = new Size(1075, 229);
            dgOtrosResultados.TabIndex = 0;
            // 
            // idOtro
            // 
            idOtro.DataPropertyName = "id";
            idOtro.HeaderText = "Id";
            idOtro.MinimumWidth = 8;
            idOtro.Name = "idOtro";
            idOtro.ReadOnly = true;
            idOtro.Visible = false;
            idOtro.Width = 150;
            // 
            // PrimerTermino
            // 
            PrimerTermino.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PrimerTermino.DataPropertyName = "PrimerTermino";
            PrimerTermino.HeaderText = "Primer termino";
            PrimerTermino.MinimumWidth = 8;
            PrimerTermino.Name = "PrimerTermino";
            PrimerTermino.ReadOnly = true;
            PrimerTermino.Width = 153;
            // 
            // ReynoldEnjambre
            // 
            ReynoldEnjambre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReynoldEnjambre.DataPropertyName = "ReynoldEnjambre";
            ReynoldEnjambre.HeaderText = "Reynold enjambre";
            ReynoldEnjambre.MinimumWidth = 8;
            ReynoldEnjambre.Name = "ReynoldEnjambre";
            ReynoldEnjambre.ReadOnly = true;
            ReynoldEnjambre.Width = 175;
            // 
            // SegundoTermino
            // 
            SegundoTermino.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SegundoTermino.DataPropertyName = "SegundoTermino";
            SegundoTermino.HeaderText = "Segundo término";
            SegundoTermino.MinimumWidth = 8;
            SegundoTermino.Name = "SegundoTermino";
            SegundoTermino.ReadOnly = true;
            SegundoTermino.Width = 171;
            // 
            // TercerTermino
            // 
            TercerTermino.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TercerTermino.DataPropertyName = "TercerTermino";
            TercerTermino.HeaderText = "Tercer término";
            TercerTermino.MinimumWidth = 8;
            TercerTermino.Name = "TercerTermino";
            TercerTermino.ReadOnly = true;
            TercerTermino.Width = 147;
            // 
            // FuncionObjetivo
            // 
            FuncionObjetivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FuncionObjetivo.DataPropertyName = "FuncionObjetivo";
            FuncionObjetivo.HeaderText = "Función objetivo";
            FuncionObjetivo.MinimumWidth = 8;
            FuncionObjetivo.Name = "FuncionObjetivo";
            FuncionObjetivo.ReadOnly = true;
            FuncionObjetivo.Width = 165;
            // 
            // DiametroBurbuja
            // 
            DiametroBurbuja.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiametroBurbuja.DataPropertyName = "DiametroBurbuja";
            DiametroBurbuja.HeaderText = "Diámetro Burbuja";
            DiametroBurbuja.MinimumWidth = 8;
            DiametroBurbuja.Name = "DiametroBurbuja";
            DiametroBurbuja.ReadOnly = true;
            DiametroBurbuja.Width = 171;
            // 
            // resultado_id
            // 
            resultado_id.DataPropertyName = "resultado_id";
            resultado_id.HeaderText = "resultado_id";
            resultado_id.MinimumWidth = 8;
            resultado_id.Name = "resultado_id";
            resultado_id.ReadOnly = true;
            resultado_id.Visible = false;
            resultado_id.Width = 150;
            // 
            // dgResultados
            // 
            dgResultados.AllowUserToAddRows = false;
            dgResultados.AllowUserToDeleteRows = false;
            dgResultados.BackgroundColor = Color.FromArgb(42, 46, 50);
            dgResultados.BorderStyle = BorderStyle.Fixed3D;
            dgResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResultados.Columns.AddRange(new DataGridViewColumn[] { id, Jg, DeltaP, Jsl, Holdup, Db, Ub, Usg, Reb, concentracion_id, concentracion, espumante_id, espumante });
            dgResultados.Dock = DockStyle.Fill;
            dgResultados.Location = new Point(0, 0);
            dgResultados.Name = "dgResultados";
            dgResultados.ReadOnly = true;
            dgResultados.RowHeadersVisible = false;
            dgResultados.RowHeadersWidth = 62;
            dgResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgResultados.Size = new Size(1075, 192);
            dgResultados.TabIndex = 45;
            dgResultados.CellContentClick += dgResultados_CellContentClick;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(42, 46, 50);
            panel18.Controls.Add(btnExportar);
            panel18.Controls.Add(label5);
            panel18.Controls.Add(cmbConcentracion);
            panel18.Controls.Add(label10);
            panel18.Controls.Add(cmbEspumante);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 0);
            panel18.Margin = new Padding(4, 5, 4, 5);
            panel18.Name = "panel18";
            panel18.Size = new Size(1143, 115);
            panel18.TabIndex = 46;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = (Image)resources.GetObject("btnExportar.BackgroundImage");
            btnExportar.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(862, 34);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(64, 50);
            btnExportar.TabIndex = 37;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 49);
            label5.Name = "label5";
            label5.Size = new Size(116, 24);
            label5.TabIndex = 36;
            label5.Text = "Espumante";
            // 
            // cmbConcentracion
            // 
            cmbConcentracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConcentracion.FormattingEnabled = true;
            cmbConcentracion.Location = new Point(601, 43);
            cmbConcentracion.Margin = new Padding(4, 5, 4, 5);
            cmbConcentracion.Name = "cmbConcentracion";
            cmbConcentracion.Size = new Size(227, 33);
            cmbConcentracion.TabIndex = 35;
            cmbConcentracion.SelectedIndexChanged += cmbConcentracion_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(445, 48);
            label10.Name = "label10";
            label10.Size = new Size(148, 24);
            label10.TabIndex = 34;
            label10.Text = "Concentración";
            // 
            // cmbEspumante
            // 
            cmbEspumante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspumante.FormattingEnabled = true;
            cmbEspumante.Location = new Point(182, 44);
            cmbEspumante.Margin = new Padding(4, 5, 4, 5);
            cmbEspumante.Name = "cmbEspumante";
            cmbEspumante.Size = new Size(227, 33);
            cmbEspumante.TabIndex = 0;
            cmbEspumante.SelectedIndexChanged += cmbEspumante_SelectedIndexChanged;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = SystemColors.WindowText;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgResultados);
            customPanel1.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(39, 161);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(1075, 192);
            customPanel1.TabIndex = 47;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = SystemColors.WindowText;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(dgOtrosResultados);
            customPanel2.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(39, 388);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(1075, 229);
            customPanel2.TabIndex = 48;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // Jg
            // 
            Jg.DataPropertyName = "Jg(cm/s)";
            Jg.HeaderText = "Jg(cm/s)";
            Jg.MinimumWidth = 8;
            Jg.Name = "Jg";
            Jg.ReadOnly = true;
            Jg.Width = 150;
            // 
            // DeltaP
            // 
            DeltaP.DataPropertyName = "DeltaP(Psi)";
            DeltaP.HeaderText = "DeltaP(Psi)";
            DeltaP.MinimumWidth = 8;
            DeltaP.Name = "DeltaP";
            DeltaP.ReadOnly = true;
            DeltaP.Width = 150;
            // 
            // Jsl
            // 
            Jsl.DataPropertyName = "Jsl(cm/s)";
            Jsl.HeaderText = "Jsl(cm/s)";
            Jsl.MinimumWidth = 8;
            Jsl.Name = "Jsl";
            Jsl.ReadOnly = true;
            Jsl.Width = 150;
            // 
            // Holdup
            // 
            Holdup.DataPropertyName = "%Holdup";
            Holdup.HeaderText = "%Holdup";
            Holdup.MinimumWidth = 8;
            Holdup.Name = "Holdup";
            Holdup.ReadOnly = true;
            Holdup.Width = 150;
            // 
            // Db
            // 
            Db.DataPropertyName = "Db(mm)";
            Db.HeaderText = "Db(mm)";
            Db.MinimumWidth = 8;
            Db.Name = "Db";
            Db.ReadOnly = true;
            Db.Width = 150;
            // 
            // Ub
            // 
            Ub.DataPropertyName = "Ub(cm/s)";
            Ub.HeaderText = "Ub(cm/s)";
            Ub.MinimumWidth = 8;
            Ub.Name = "Ub";
            Ub.ReadOnly = true;
            Ub.Width = 150;
            // 
            // Usg
            // 
            Usg.DataPropertyName = "Usg(m/s)";
            Usg.HeaderText = "Usg(m/s)";
            Usg.MinimumWidth = 8;
            Usg.Name = "Usg";
            Usg.ReadOnly = true;
            Usg.Width = 150;
            // 
            // Reb
            // 
            Reb.DataPropertyName = "Reynold de burbuja";
            Reb.HeaderText = "Reynold de burbuja";
            Reb.MinimumWidth = 8;
            Reb.Name = "Reb";
            Reb.ReadOnly = true;
            Reb.Width = 150;
            // 
            // concentracion_id
            // 
            concentracion_id.DataPropertyName = "concentracion_id";
            concentracion_id.HeaderText = "concentracion_id";
            concentracion_id.MinimumWidth = 8;
            concentracion_id.Name = "concentracion_id";
            concentracion_id.ReadOnly = true;
            concentracion_id.Visible = false;
            concentracion_id.Width = 150;
            // 
            // concentracion
            // 
            concentracion.DataPropertyName = "Concentración(ppm)";
            concentracion.HeaderText = "Concentración(ppm)";
            concentracion.MinimumWidth = 8;
            concentracion.Name = "concentracion";
            concentracion.ReadOnly = true;
            concentracion.Width = 150;
            // 
            // espumante_id
            // 
            espumante_id.DataPropertyName = "espumante_id";
            espumante_id.HeaderText = "espumante_id";
            espumante_id.MinimumWidth = 8;
            espumante_id.Name = "espumante_id";
            espumante_id.ReadOnly = true;
            espumante_id.Visible = false;
            espumante_id.Width = 150;
            // 
            // espumante
            // 
            espumante.DataPropertyName = "espumante";
            espumante.HeaderText = "Espumante";
            espumante.MinimumWidth = 8;
            espumante.Name = "espumante";
            espumante.ReadOnly = true;
            espumante.Width = 150;
            // 
            // frmOtrosResultados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1143, 639);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(panel18);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmOtrosResultados";
            Text = "frmDatosEntrada";
            Load += frmDatosEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)dgOtrosResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgResultados).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgOtrosResultados;
        private DataGridView dgResultados;
        private Panel panel18;
        private Label label5;
        private ComboBox cmbConcentracion;
        private Label label10;
        private ComboBox cmbEspumante;
        private Button btnExportar;
        private DataGridViewTextBoxColumn idOtro;
        private DataGridViewTextBoxColumn PrimerTermino;
        private DataGridViewTextBoxColumn ReynoldEnjambre;
        private DataGridViewTextBoxColumn SegundoTermino;
        private DataGridViewTextBoxColumn TercerTermino;
        private DataGridViewTextBoxColumn FuncionObjetivo;
        private DataGridViewTextBoxColumn DiametroBurbuja;
        private DataGridViewTextBoxColumn resultado_id;
        private Controles.CustomPanel customPanel1;
        private Controles.CustomPanel customPanel2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Jg;
        private DataGridViewTextBoxColumn DeltaP;
        private DataGridViewTextBoxColumn Jsl;
        private DataGridViewTextBoxColumn Holdup;
        private DataGridViewTextBoxColumn Db;
        private DataGridViewTextBoxColumn Ub;
        private DataGridViewTextBoxColumn Usg;
        private DataGridViewTextBoxColumn Reb;
        private DataGridViewTextBoxColumn concentracion_id;
        private DataGridViewTextBoxColumn concentracion;
        private DataGridViewTextBoxColumn espumante_id;
        private DataGridViewTextBoxColumn espumante;
    }
}