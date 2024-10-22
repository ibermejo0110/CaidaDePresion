namespace PuertoSerie
{
    partial class frmSimulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulador));
            btnCalibrar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            cmbSerialPort = new ComboBox();
            label4 = new Label();
            txtDeltaP = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            cmbParity = new ComboBox();
            cmbStopBits = new ComboBox();
            numBaudRate = new NumericUpDown();
            numDataBit = new NumericUpDown();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).BeginInit();
            SuspendLayout();
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackColor = SystemColors.Control;
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(232, 370);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(93, 50);
            btnCalibrar.TabIndex = 60;
            btnCalibrar.Text = "Enviar";
            btnCalibrar.UseVisualStyleBackColor = false;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 11, 10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbSerialPort);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDeltaP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbParity);
            panel1.Controls.Add(cmbStopBits);
            panel1.Controls.Add(numBaudRate);
            panel1.Controls.Add(numDataBit);
            panel1.Location = new Point(38, 27);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 335);
            panel1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 1;
            label1.Text = "Puertos Seriales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 55;
            label5.Text = "StopBits";
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(196, 26);
            cmbSerialPort.Margin = new Padding(4, 5, 4, 5);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(171, 33);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 183);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 54;
            label4.Text = "BaudRate";
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(196, 75);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(171, 30);
            txtDeltaP.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(116, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 53;
            label3.Text = "Parity";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(134, 75);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(54, 35);
            panel4.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 237);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 52;
            label2.Text = "DataBits";
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(196, 125);
            cmbParity.Margin = new Padding(4, 5, 4, 5);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(171, 33);
            cmbParity.TabIndex = 48;
            // 
            // cmbStopBits
            // 
            cmbStopBits.FormattingEnabled = true;
            cmbStopBits.Location = new Point(196, 268);
            cmbStopBits.Margin = new Padding(4, 5, 4, 5);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(171, 33);
            cmbStopBits.TabIndex = 51;
            // 
            // numBaudRate
            // 
            numBaudRate.Location = new Point(196, 172);
            numBaudRate.Margin = new Padding(4, 5, 4, 5);
            numBaudRate.Name = "numBaudRate";
            numBaudRate.Size = new Size(171, 31);
            numBaudRate.TabIndex = 49;
            // 
            // numDataBit
            // 
            numDataBit.Location = new Point(199, 225);
            numDataBit.Margin = new Padding(4, 5, 4, 5);
            numDataBit.Name = "numDataBit";
            numDataBit.Size = new Size(171, 31);
            numDataBit.TabIndex = 50;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(331, 370);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(93, 50);
            btnCerrar.TabIndex = 62;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmSimulador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(449, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnCalibrar);
            Controls.Add(panel1);
            Name = "frmSimulador";
            Text = "Form2";
            Load += frmSimulador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalibrar;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private ComboBox cmbSerialPort;
        private Label label4;
        private TextBox txtDeltaP;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private ComboBox cmbParity;
        private ComboBox cmbStopBits;
        private NumericUpDown numBaudRate;
        private NumericUpDown numDataBit;
        private Button btnCerrar;
    }
}