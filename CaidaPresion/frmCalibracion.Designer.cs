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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalibracion));
            cmbSerialPort = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            txtDeltaP = new TextBox();
            panel1 = new Panel();
            btnCerrar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            button1 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(137, 15);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(141, 23);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 1;
            label1.Text = "Puertos Seriales";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(94, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(38, 21);
            panel4.TabIndex = 47;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(137, 45);
            txtDeltaP.Margin = new Padding(2);
            txtDeltaP.Multiline = true;
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.ReadOnly = true;
            txtDeltaP.ScrollBars = ScrollBars.Vertical;
            txtDeltaP.Size = new Size(141, 87);
            txtDeltaP.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 11, 10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbSerialPort);
            panel1.Controls.Add(txtDeltaP);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(8, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 143);
            panel1.TabIndex = 56;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(249, 230);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(65, 30);
            btnCerrar.TabIndex = 61;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(317, 223);
            tabControl1.TabIndex = 62;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(309, 195);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "COM";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(309, 195);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "USB";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(309, 195);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CX PROGRAMMER";
            // 
            // button1
            // 
            button1.Location = new Point(150, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCalibracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(317, 268);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(btnCerrar);
            Name = "frmCalibracion";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSerialPort;
        private Label label1;
        private Panel panel4;
        private TextBox txtDeltaP;
        private Panel panel1;
        private Button btnCerrar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
    }
}