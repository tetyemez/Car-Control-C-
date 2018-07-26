namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.geri = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.sag = new System.Windows.Forms.Button();
            this.Sol = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dc_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portlar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.geri);
            this.groupBox1.Controls.Add(this.ileri);
            this.groupBox1.Controls.Add(this.sag);
            this.groupBox1.Controls.Add(this.Sol);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(18, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(300, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Box";
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.geri.Location = new System.Drawing.Point(112, 175);
            this.geri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(88, 29);
            this.geri.TabIndex = 3;
            this.geri.Text = "Back";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.geri_MouseDown);
            this.geri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.geri_MouseUp);
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ileri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ileri.Location = new System.Drawing.Point(112, 43);
            this.ileri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(88, 29);
            this.ileri.TabIndex = 2;
            this.ileri.Text = "Forward";
            this.ileri.UseVisualStyleBackColor = false;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            this.ileri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ileri_MouseDown);
            this.ileri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ileri_MouseUp);
            // 
            // sag
            // 
            this.sag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sag.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sag.Location = new System.Drawing.Point(206, 102);
            this.sag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sag.Name = "sag";
            this.sag.Size = new System.Drawing.Size(88, 29);
            this.sag.TabIndex = 0;
            this.sag.Text = "Right";
            this.sag.UseVisualStyleBackColor = false;
            this.sag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sag_MouseDown);
            this.sag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sag_MouseUp);
            // 
            // Sol
            // 
            this.Sol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sol.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sol.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Sol.Location = new System.Drawing.Point(7, 102);
            this.Sol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sol.Name = "Sol";
            this.Sol.Size = new System.Drawing.Size(88, 29);
            this.Sol.TabIndex = 0;
            this.Sol.Text = "Left";
            this.Sol.UseVisualStyleBackColor = false;
            this.Sol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sol_MouseDown);
            this.Sol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sol_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(224, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "Connect";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._15491886_335988323447785_180968739_o;
            this.pictureBox1.Location = new System.Drawing.Point(335, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dc_btn
            // 
            this.dc_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dc_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dc_btn.Location = new System.Drawing.Point(350, 14);
            this.dc_btn.Name = "dc_btn";
            this.dc_btn.Size = new System.Drawing.Size(88, 29);
            this.dc_btn.TabIndex = 6;
            this.dc_btn.Text = "Disconnect";
            this.dc_btn.UseVisualStyleBackColor = false;
            this.dc_btn.Click += new System.EventHandler(this.dc_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(517, 314);
            this.Controls.Add(this.dc_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Arduino ile Engel Algılayan Robot";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sag;
        private System.Windows.Forms.Button Sol;
        private System.Windows.Forms.Button button5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dc_btn;
    }
}

