using DataAccess.Repository;

namespace CaidaPresion
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0.68D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0.6D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1.2D, 20D);
            dataGridView1 = new DataGridView();
            Variable = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            btnValoresIniciales = new Button();
            txtJsl = new TextBox();
            label6 = new Label();
            btnNuevo = new Button();
            rbtManual = new RadioButton();
            radioButton1 = new RadioButton();
            txtVelLinealGas = new TextBox();
            label2 = new Label();
            btnCalibrar = new Button();
            btnGraficar = new Button();
            txtDeltaP = new TextBox();
            BtnOtrosResultados = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label15 = new Label();
            label7 = new Label();
            pnlGraficas = new Panel();
            grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel18 = new Panel();
            btnNuevoEspumante = new Button();
            cmbtipoGrafica = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label5 = new Label();
            cmbEspumante = new ComboBox();
            cmbParamGraficar = new ComboBox();
            cmbConcentracion = new ComboBox();
            label10 = new Label();
            panel2 = new Panel();
            lblReloj = new Label();
            label1 = new Label();
            panel11 = new Panel();
            panel6 = new Panel();
            btnAyuda = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel12 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            customPanel6 = new Controles.CustomPanel();
            pictureBox1 = new PictureBox();
            panel15 = new Panel();
            panel17 = new Panel();
            customPanel3 = new Controles.CustomPanel();
            label16 = new Label();
            customPanel2 = new Controles.CustomPanel();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            customPanel1 = new Controles.CustomPanel();
            panel16 = new Panel();
            customPanel5 = new Controles.CustomPanel();
            customPanel4 = new Controles.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grafica).BeginInit();
            panel18.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel14.SuspendLayout();
            customPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel15.SuspendLayout();
            panel17.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            panel16.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Variable, Resultado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(305, 143);
            dataGridView1.TabIndex = 44;
            // 
            // Variable
            // 
            Variable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Variable.DataPropertyName = "Variable";
            Variable.HeaderText = "Variable";
            Variable.MinimumWidth = 8;
            Variable.Name = "Variable";
            Variable.ReadOnly = true;
            // 
            // Resultado
            // 
            Resultado.DataPropertyName = "Resultado";
            Resultado.HeaderText = "Resultado";
            Resultado.MinimumWidth = 8;
            Resultado.Name = "Resultado";
            Resultado.ReadOnly = true;
            Resultado.Width = 150;
            // 
            // btnValoresIniciales
            // 
            btnValoresIniciales.BackgroundImage = (Image)resources.GetObject("btnValoresIniciales.BackgroundImage");
            btnValoresIniciales.BackgroundImageLayout = ImageLayout.Stretch;
            btnValoresIniciales.FlatStyle = FlatStyle.Flat;
            btnValoresIniciales.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValoresIniciales.Location = new Point(20, 105);
            btnValoresIniciales.Margin = new Padding(2);
            btnValoresIniciales.Name = "btnValoresIniciales";
            btnValoresIniciales.Size = new Size(31, 30);
            btnValoresIniciales.TabIndex = 43;
            btnValoresIniciales.UseVisualStyleBackColor = true;
            btnValoresIniciales.Click += button3_Click;
            // 
            // txtJsl
            // 
            txtJsl.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJsl.Location = new Point(234, 99);
            txtJsl.Margin = new Padding(2);
            txtJsl.Name = "txtJsl";
            txtJsl.Size = new Size(60, 23);
            txtJsl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(157, 101);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 16);
            label6.TabIndex = 42;
            label6.Text = "Jsl (cm/s)";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(20, 37);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(31, 30);
            btnNuevo.TabIndex = 35;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button1_Click;
            // 
            // rbtManual
            // 
            rbtManual.AutoSize = true;
            rbtManual.BackColor = Color.Transparent;
            rbtManual.Checked = true;
            rbtManual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtManual.ForeColor = Color.White;
            rbtManual.Location = new Point(31, 41);
            rbtManual.Margin = new Padding(2);
            rbtManual.Name = "rbtManual";
            rbtManual.Size = new Size(75, 20);
            rbtManual.TabIndex = 34;
            rbtManual.TabStop = true;
            rbtManual.Text = "Manual";
            rbtManual.UseVisualStyleBackColor = false;
            rbtManual.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(31, 77);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(102, 20);
            radioButton1.TabIndex = 33;
            radioButton1.Text = "Automático";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtVelLinealGas
            // 
            txtVelLinealGas.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVelLinealGas.Location = new Point(234, 73);
            txtVelLinealGas.Margin = new Padding(2);
            txtVelLinealGas.Name = "txtVelLinealGas";
            txtVelLinealGas.Size = new Size(60, 23);
            txtVelLinealGas.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 16);
            label2.TabIndex = 32;
            label2.Text = "Velocidad lineal del gas (cm/s)";
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackgroundImage = (Image)resources.GetObject("btnCalibrar.BackgroundImage");
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.Enabled = false;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(20, 139);
            btnCalibrar.Margin = new Padding(2);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(31, 30);
            btnCalibrar.TabIndex = 31;
            btnCalibrar.UseVisualStyleBackColor = true;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // btnGraficar
            // 
            btnGraficar.BackgroundImage = (Image)resources.GetObject("btnGraficar.BackgroundImage");
            btnGraficar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGraficar.FlatStyle = FlatStyle.Flat;
            btnGraficar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficar.Location = new Point(20, 173);
            btnGraficar.Margin = new Padding(2);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(33, 30);
            btnGraficar.TabIndex = 28;
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(234, 48);
            txtDeltaP.Margin = new Padding(2);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(60, 23);
            txtDeltaP.TabIndex = 27;
            // 
            // BtnOtrosResultados
            // 
            BtnOtrosResultados.BackgroundImage = (Image)resources.GetObject("BtnOtrosResultados.BackgroundImage");
            BtnOtrosResultados.BackgroundImageLayout = ImageLayout.Stretch;
            BtnOtrosResultados.FlatStyle = FlatStyle.Flat;
            BtnOtrosResultados.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOtrosResultados.Location = new Point(20, 71);
            BtnOtrosResultados.Margin = new Padding(2);
            BtnOtrosResultados.Name = "BtnOtrosResultados";
            BtnOtrosResultados.Size = new Size(31, 30);
            BtnOtrosResultados.TabIndex = 44;
            BtnOtrosResultados.UseVisualStyleBackColor = true;
            BtnOtrosResultados.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(104, 51);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 16);
            label15.TabIndex = 54;
            label15.Text = "Caida de presión";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(76, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 16);
            label7.TabIndex = 53;
            label7.Text = "DATOS DE ENTRADA";
            // 
            // pnlGraficas
            // 
            pnlGraficas.BackColor = Color.FromArgb(42, 46, 50);
            pnlGraficas.Controls.Add(grafica);
            pnlGraficas.Controls.Add(panel18);
            pnlGraficas.Controls.Add(panel2);
            pnlGraficas.Dock = DockStyle.Top;
            pnlGraficas.Location = new Point(0, 0);
            pnlGraficas.Name = "pnlGraficas";
            pnlGraficas.Size = new Size(854, 422);
            pnlGraficas.TabIndex = 0;
            // 
            // grafica
            // 
            grafica.BackColor = Color.FromArgb(42, 46, 50);
            chartArea1.Name = "ChartArea1";
            grafica.ChartAreas.Add(chartArea1);
            grafica.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            grafica.Legends.Add(legend1);
            grafica.Location = new Point(0, 103);
            grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            grafica.Series.Add(series1);
            grafica.Size = new Size(854, 319);
            grafica.TabIndex = 0;
            grafica.Text = "chart1";
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(42, 46, 50);
            panel18.Controls.Add(btnNuevoEspumante);
            panel18.Controls.Add(cmbtipoGrafica);
            panel18.Controls.Add(label13);
            panel18.Controls.Add(label12);
            panel18.Controls.Add(label5);
            panel18.Controls.Add(cmbEspumante);
            panel18.Controls.Add(cmbParamGraficar);
            panel18.Controls.Add(cmbConcentracion);
            panel18.Controls.Add(label10);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 12);
            panel18.Name = "panel18";
            panel18.Size = new Size(854, 91);
            panel18.TabIndex = 1;
            // 
            // btnNuevoEspumante
            // 
            btnNuevoEspumante.BackgroundImage = (Image)resources.GetObject("btnNuevoEspumante.BackgroundImage");
            btnNuevoEspumante.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoEspumante.FlatStyle = FlatStyle.Flat;
            btnNuevoEspumante.Location = new Point(324, 29);
            btnNuevoEspumante.Margin = new Padding(2);
            btnNuevoEspumante.Name = "btnNuevoEspumante";
            btnNuevoEspumante.Size = new Size(28, 20);
            btnNuevoEspumante.TabIndex = 41;
            btnNuevoEspumante.UseVisualStyleBackColor = true;
            btnNuevoEspumante.Click += btnNuevoEspumante_Click;
            // 
            // cmbtipoGrafica
            // 
            cmbtipoGrafica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipoGrafica.FormattingEnabled = true;
            cmbtipoGrafica.Location = new Point(537, 58);
            cmbtipoGrafica.Name = "cmbtipoGrafica";
            cmbtipoGrafica.Size = new Size(212, 23);
            cmbtipoGrafica.TabIndex = 40;
            cmbtipoGrafica.SelectedIndexChanged += cmbtipoGrafica_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(377, 58);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(113, 16);
            label13.TabIndex = 39;
            label13.Text = "Tipo de gráfica";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(375, 31);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(157, 16);
            label12.TabIndex = 38;
            label12.Text = "Parámetros a graficar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(82, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 36;
            label5.Text = "Espumante";
            // 
            // cmbEspumante
            // 
            cmbEspumante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspumante.FormattingEnabled = true;
            cmbEspumante.Location = new Point(191, 29);
            cmbEspumante.Name = "cmbEspumante";
            cmbEspumante.Size = new Size(132, 23);
            cmbEspumante.TabIndex = 0;
            cmbEspumante.SelectedIndexChanged += cmbEspumante_SelectedIndexChanged;
            // 
            // cmbParamGraficar
            // 
            cmbParamGraficar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParamGraficar.FormattingEnabled = true;
            cmbParamGraficar.Location = new Point(537, 29);
            cmbParamGraficar.Name = "cmbParamGraficar";
            cmbParamGraficar.Size = new Size(212, 23);
            cmbParamGraficar.TabIndex = 37;
            cmbParamGraficar.SelectedIndexChanged += cmbParamGraficar_SelectedIndexChanged;
            // 
            // cmbConcentracion
            // 
            cmbConcentracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConcentracion.FormattingEnabled = true;
            cmbConcentracion.Location = new Point(191, 60);
            cmbConcentracion.Name = "cmbConcentracion";
            cmbConcentracion.Size = new Size(160, 23);
            cmbConcentracion.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(82, 63);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 16);
            label10.TabIndex = 34;
            label10.Text = "Concentración";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 12);
            panel2.TabIndex = 1;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.BackColor = Color.Transparent;
            lblReloj.Font = new Font("Centaur", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.ForeColor = Color.White;
            lblReloj.Location = new Point(21, 20);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(157, 44);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 16);
            label1.TabIndex = 52;
            label1.Text = "MODO DE EJECUCIÓN";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Controls.Add(panel6);
            panel11.Controls.Add(panel3);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(label11);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1360, 77);
            panel11.TabIndex = 54;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAyuda);
            panel6.Controls.Add(btnMinimizar);
            panel6.Controls.Add(btnMaximizar);
            panel6.Controls.Add(btnCerrar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1096, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(264, 77);
            panel6.TabIndex = 47;
            // 
            // btnAyuda
            // 
            btnAyuda.BackgroundImage = (Image)resources.GetObject("btnAyuda.BackgroundImage");
            btnAyuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnAyuda.Location = new Point(119, 3);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(34, 33);
            btnAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAyuda.TabIndex = 43;
            btnAyuda.TabStop = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackgroundImage = (Image)resources.GetObject("btnMinimizar.BackgroundImage");
            btnMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimizar.Location = new Point(159, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 33);
            btnMinimizar.TabIndex = 44;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximizar.Location = new Point(191, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 33);
            btnMaximizar.TabIndex = 41;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(223, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 33);
            btnCerrar.TabIndex = 42;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 113, 163);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(242, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(854, 77);
            panel3.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(67, 43);
            label9.Name = "label9";
            label9.Size = new Size(682, 20);
            label9.TabIndex = 41;
            label9.Text = "DEL LABORATORIO DE CARBOQUIMICA  DE LA UNIVERSIDAD DEL ATLANTICO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(5, 15);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(820, 20);
            label8.TabIndex = 40;
            label8.Text = "DISEÑO DE UNA INTERFAZ GRAFICA PARA LA COLUMNA DE FLOTACION  A ESCALA TEST RIG ";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(42, 46, 50);
            panel12.Controls.Add(label4);
            panel12.Controls.Add(label3);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(242, 77);
            panel12.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 43);
            label4.Name = "label4";
            label4.Size = new Size(175, 18);
            label4.TabIndex = 40;
            label4.Text = "INGENIERIA QUIMICA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 39;
            label3.Text = "PROGRAMA DE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(134, 42);
            label11.Name = "label11";
            label11.Size = new Size(0, 18);
            label11.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel14);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 396);
            panel1.TabIndex = 55;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel13);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 422);
            panel7.Name = "panel7";
            panel7.Size = new Size(242, 0);
            panel7.TabIndex = 48;
            // 
            // panel13
            // 
            panel13.BackgroundImage = (Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = ImageLayout.Stretch;
            panel13.Location = new Point(51, 23);
            panel13.Margin = new Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new Size(162, 137);
            panel13.TabIndex = 41;
            // 
            // panel14
            // 
            panel14.Controls.Add(customPanel6);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(242, 422);
            panel14.TabIndex = 47;
            // 
            // customPanel6
            // 
            customPanel6.BackColor = Color.White;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(pictureBox1);
            customPanel6.ForeColor = Color.Black;
            customPanel6.GradientAngle = 90F;
            customPanel6.GradientBottomColor = Color.CadetBlue;
            customPanel6.GradientTopColor = Color.DodgerBlue;
            customPanel6.Location = new Point(18, 34);
            customPanel6.Margin = new Padding(2);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(204, 311);
            customPanel6.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel15
            // 
            panel15.Controls.Add(panel17);
            panel15.Controls.Add(panel16);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(242, 77);
            panel15.Name = "panel15";
            panel15.Size = new Size(1118, 396);
            panel15.TabIndex = 56;
            // 
            // panel17
            // 
            panel17.Controls.Add(customPanel3);
            panel17.Controls.Add(customPanel2);
            panel17.Controls.Add(customPanel1);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(854, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(264, 396);
            panel17.TabIndex = 53;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = SystemColors.WindowText;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(label16);
            customPanel3.Controls.Add(lblReloj);
            customPanel3.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(49, 439);
            customPanel3.Margin = new Padding(2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(206, 67);
            customPanel3.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(70, 6);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(55, 16);
            label16.TabIndex = 54;
            label16.Text = "RELOJ";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = SystemColors.WindowText;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(label21);
            customPanel2.Controls.Add(label20);
            customPanel2.Controls.Add(label19);
            customPanel2.Controls.Add(label18);
            customPanel2.Controls.Add(label17);
            customPanel2.Controls.Add(label14);
            customPanel2.Controls.Add(BtnOtrosResultados);
            customPanel2.Controls.Add(btnGraficar);
            customPanel2.Controls.Add(btnCalibrar);
            customPanel2.Controls.Add(btnValoresIniciales);
            customPanel2.Controls.Add(btnNuevo);
            customPanel2.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(39, 163);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(216, 214);
            customPanel2.TabIndex = 52;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(57, 173);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(119, 26);
            label21.TabIndex = 58;
            label21.Text = "Graficar Resultados\r\n\r\n";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(55, 141);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(156, 26);
            label20.TabIndex = 57;
            label20.Text = "Encender/Apagar Medidor\r\n\r\n";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(55, 105);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(123, 26);
            label19.TabIndex = 56;
            label19.Text = "Ver Valores Iniciales\r\n\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(55, 75);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(150, 26);
            label18.TabIndex = 55;
            label18.Text = "Mostrar Otros Resultados\r\n\r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(55, 39);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(121, 26);
            label17.TabIndex = 54;
            label17.Text = "Nuevos Resultados \r\n\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(49, 10);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(127, 16);
            label14.TabIndex = 53;
            label14.Text = "HERRAMIENTAS\r\n";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = SystemColors.WindowText;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(rbtManual);
            customPanel1.Controls.Add(radioButton1);
            customPanel1.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(39, 12);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(213, 115);
            customPanel1.TabIndex = 41;
            // 
            // panel16
            // 
            panel16.Controls.Add(customPanel5);
            panel16.Controls.Add(customPanel4);
            panel16.Controls.Add(pnlGraficas);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(854, 396);
            panel16.TabIndex = 52;
            // 
            // customPanel5
            // 
            customPanel5.BackColor = SystemColors.WindowText;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(dataGridView1);
            customPanel5.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel5.Location = new Point(468, 439);
            customPanel5.Margin = new Padding(2);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(305, 143);
            customPanel5.TabIndex = 48;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = SystemColors.WindowText;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(label15);
            customPanel4.Controls.Add(label7);
            customPanel4.Controls.Add(txtDeltaP);
            customPanel4.Controls.Add(label2);
            customPanel4.Controls.Add(txtJsl);
            customPanel4.Controls.Add(label6);
            customPanel4.Controls.Add(txtVelLinealGas);
            customPanel4.ForeColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(57, 439);
            customPanel4.Margin = new Padding(2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(306, 143);
            customPanel4.TabIndex = 47;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1360, 473);
            Controls.Add(panel15);
            Controls.Add(panel1);
            Controls.Add(panel11);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlGraficas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grafica).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel14.ResumeLayout(false);
            customPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel15.ResumeLayout(false);
            panel17.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            panel16.ResumeLayout(false);
            customPanel5.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnValoresIniciales;
        private TextBox txtJsl;
        private Label label6;
        private Button btnNuevo;
        private RadioButton rbtManual;
        private RadioButton radioButton1;
        private TextBox txtVelLinealGas;
        private Label label2;
        private Button btnCalibrar;
        private Button btnGraficar;
        private TextBox txtDeltaP;
        private Button BtnOtrosResultados;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlGraficas;
        private Label lblReloj;
        private Label label7;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private Label label10;
        private ComboBox cmbEspumante;
        private Panel panel11;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private Panel panel12;
        private Label label9;
        private Label label8;
        private Label label11;
        private Panel panel3;
        private Panel panel6;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel7;
        private Panel panel13;
        private Panel panel14;
        private PictureBox pictureBox1;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private ComboBox cmbConcentracion;
        private Label label5;
        private Label label12;
        private ComboBox cmbParamGraficar;
        private DataGridViewTextBoxColumn Variable;
        private DataGridViewTextBoxColumn Resultado;
        private ComboBox cmbtipoGrafica;
        private Label label13; 
        private EspumanteRepository espumanteRepository;
        private EspumanteConcentracionRepository espumanteConcentracionRepository;
        private ConcentracionRepository concentracionRepository;
        private ResultadoRepository resultadoRepository;
        private GraficaRepository graficaRepository;
        private OtrosResultadosRepository OtrosResultadosRepository;
        private Label label15;
        private PictureBox btnMinimizar;
        private Controles.CustomPanel customPanel1;
        private Controles.CustomPanel customPanel3;
        private Controles.CustomPanel customPanel2;
        private Label label16;
        private Controles.CustomPanel customPanel4;
        private Controles.CustomPanel customPanel5;
        private Label label14;
        private PictureBox btnAyuda;
        private Label label18;
        private Label label17;
        private Label label21;
        private Label label20;
        private Label label19;
        private Controles.CustomPanel customPanel6;
        private Button btnNuevoEspumante;
    }
}