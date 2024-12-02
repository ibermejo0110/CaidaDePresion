namespace CaidaPresion
{
    partial class frmCalibracion
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
            cmbSerialPort = new ComboBox();
            label1 = new Label();
            btnCerrar = new Button();
            customPanel1 = new Controles.CustomPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbParity = new ComboBox();
            cmbStopBits = new ComboBox();
            numBaudRate = new NumericUpDown();
            numDataBit = new NumericUpDown();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).BeginInit();
            SuspendLayout();
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(153, 35);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(141, 23);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 1;
            label1.Text = "Puertos Seriales";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(190, 174);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(104, 30);
            btnCerrar.TabIndex = 61;
            btnCerrar.Text = "Abrir puerto";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(cmbParity);
            customPanel1.Controls.Add(cmbStopBits);
            customPanel1.Controls.Add(numBaudRate);
            customPanel1.Controls.Add(numDataBit);
            customPanel1.Controls.Add(label1);
            customPanel1.Controls.Add(btnCerrar);
            customPanel1.Controls.Add(cmbSerialPort);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(12, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(312, 221);
            customPanel1.TabIndex = 63;
            customPanel1.Paint += customPanel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(78, 153);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 69;
            label5.Text = "StopBits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 97);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 68;
            label4.Text = "BaudRate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 65);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 67;
            label3.Text = "Parity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 125);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 66;
            label2.Text = "DataBits";
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(153, 62);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(141, 23);
            cmbParity.TabIndex = 62;
            // 
            // cmbStopBits
            // 
            cmbStopBits.FormattingEnabled = true;
            cmbStopBits.Location = new Point(152, 146);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(142, 23);
            cmbStopBits.TabIndex = 65;
            // 
            // numBaudRate
            // 
            numBaudRate.Location = new Point(153, 90);
            numBaudRate.Name = "numBaudRate";
            numBaudRate.Size = new Size(141, 23);
            numBaudRate.TabIndex = 63;
            // 
            // numDataBit
            // 
            numDataBit.Location = new Point(154, 118);
            numDataBit.Name = "numDataBit";
            numDataBit.Size = new Size(140, 23);
            numDataBit.TabIndex = 64;
            // 
            // frmCalibracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(338, 245);
            Controls.Add(customPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCalibracion";
            Text = "Calibración";
            Load += Form1_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSerialPort;
        private Label label1;
        private Button btnCerrar;
        private Controles.CustomPanel customPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbParity;
        private ComboBox cmbStopBits;
        private NumericUpDown numBaudRate;
        private NumericUpDown numDataBit;
    }
}