namespace CaidaPresion
{
    partial class frmEspumante
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspumante));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            dgEspumante = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            customPanel2 = new Controles.CustomPanel();
            BtnGuardar = new Button();
            btnCalibrar = new Button();
            btnValoresIniciales = new Button();
            btnNuevo = new Button();
            customPanel1 = new Controles.CustomPanel();
            customPanel3 = new Controles.CustomPanel();
            customPanel4 = new Controles.CustomPanel();
            dgConcentracion = new DataGridView();
            concentracion_id = new DataGridViewTextBoxColumn();
            concentracion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgEspumante).BeginInit();
            customPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConcentracion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(123, 43);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(177, 122);
            txtDescripcion.TabIndex = 46;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(123, 16);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ScrollBars = ScrollBars.Vertical;
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 70);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 49;
            label2.Text = "Descripción";
            // 
            // dgEspumante
            // 
            dgEspumante.AllowUserToAddRows = false;
            dgEspumante.AllowUserToDeleteRows = false;
            dgEspumante.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgEspumante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgEspumante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEspumante.Columns.AddRange(new DataGridViewColumn[] { id, nombre, descripcion });
            dgEspumante.Dock = DockStyle.Fill;
            dgEspumante.Location = new Point(0, 0);
            dgEspumante.Margin = new Padding(2, 2, 2, 2);
            dgEspumante.Name = "dgEspumante";
            dgEspumante.ReadOnly = true;
            dgEspumante.RowHeadersVisible = false;
            dgEspumante.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgEspumante.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgEspumante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEspumante.Size = new Size(208, 87);
            dgEspumante.TabIndex = 58;
            dgEspumante.CellContentClick += dgEspumante_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 150;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 78;
            // 
            // descripcion
            // 
            descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 8;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 97;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = SystemColors.WindowText;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(BtnGuardar);
            customPanel2.Controls.Add(btnCalibrar);
            customPanel2.Controls.Add(btnValoresIniciales);
            customPanel2.Controls.Add(btnNuevo);
            customPanel2.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(391, 212);
            customPanel2.Margin = new Padding(2, 2, 2, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(155, 44);
            customPanel2.TabIndex = 60;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackgroundImage = (Image)resources.GetObject("BtnGuardar.BackgroundImage");
            BtnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.Location = new Point(43, 7);
            BtnGuardar.Margin = new Padding(2, 2, 2, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(31, 30);
            BtnGuardar.TabIndex = 44;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackgroundImage = (Image)resources.GetObject("btnCalibrar.BackgroundImage");
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(113, 7);
            btnCalibrar.Margin = new Padding(2, 2, 2, 2);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(31, 30);
            btnCalibrar.TabIndex = 31;
            btnCalibrar.UseVisualStyleBackColor = true;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // btnValoresIniciales
            // 
            btnValoresIniciales.BackgroundImage = (Image)resources.GetObject("btnValoresIniciales.BackgroundImage");
            btnValoresIniciales.BackgroundImageLayout = ImageLayout.Stretch;
            btnValoresIniciales.FlatStyle = FlatStyle.Flat;
            btnValoresIniciales.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValoresIniciales.Location = new Point(78, 7);
            btnValoresIniciales.Margin = new Padding(2, 2, 2, 2);
            btnValoresIniciales.Name = "btnValoresIniciales";
            btnValoresIniciales.Size = new Size(31, 30);
            btnValoresIniciales.TabIndex = 43;
            btnValoresIniciales.UseVisualStyleBackColor = true;
            btnValoresIniciales.Click += btnValoresIniciales_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(8, 7);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(31, 30);
            btnNuevo.TabIndex = 35;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.Transparent;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(txtNombre);
            customPanel1.Controls.Add(txtDescripcion);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(8, 22);
            customPanel1.Margin = new Padding(2, 2, 2, 2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(318, 180);
            customPanel1.TabIndex = 61;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.Transparent;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(dgEspumante);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(338, 22);
            customPanel3.Margin = new Padding(2, 2, 2, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(208, 87);
            customPanel3.TabIndex = 62;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.Transparent;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(dgConcentracion);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(338, 115);
            customPanel4.Margin = new Padding(2, 2, 2, 2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(208, 87);
            customPanel4.TabIndex = 63;
            // 
            // dgConcentracion
            // 
            dgConcentracion.AllowUserToAddRows = false;
            dgConcentracion.AllowUserToDeleteRows = false;
            dgConcentracion.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgConcentracion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgConcentracion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConcentracion.Columns.AddRange(new DataGridViewColumn[] { concentracion_id, concentracion });
            dgConcentracion.Dock = DockStyle.Fill;
            dgConcentracion.Location = new Point(0, 0);
            dgConcentracion.Margin = new Padding(2, 2, 2, 2);
            dgConcentracion.Name = "dgConcentracion";
            dgConcentracion.ReadOnly = true;
            dgConcentracion.RowHeadersVisible = false;
            dgConcentracion.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgConcentracion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgConcentracion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgConcentracion.Size = new Size(208, 87);
            dgConcentracion.TabIndex = 58;
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
            concentracion.DataPropertyName = "concentracion";
            concentracion.HeaderText = "Concentración";
            concentracion.MinimumWidth = 8;
            concentracion.Name = "concentracion";
            concentracion.ReadOnly = true;
            concentracion.Width = 150;
            // 
            // frmEspumante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(560, 270);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel1);
            Controls.Add(customPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmEspumante";
            Text = "Espumante";
            Load += frmEspumante_Load;
            ((System.ComponentModel.ISupportInitialize)dgEspumante).EndInit();
            customPanel2.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgConcentracion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private DataGridView dgEspumante;
        private Controles.CustomPanel customPanel2;
        private Button BtnGuardar;
        private Button btnCalibrar;
        private Button btnValoresIniciales;
        private Button btnNuevo;
        private Controles.CustomPanel customPanel1;
        private Controles.CustomPanel customPanel3;
        private Controles.CustomPanel customPanel4;
        private DataGridView dgConcentracion;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn concentracion_id;
        private DataGridViewTextBoxColumn concentracion;
    }
}