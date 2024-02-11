namespace U64DebugReceiver
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupPort = new System.Windows.Forms.NumericUpDown();
            this.btnCaptureStart = new System.Windows.Forms.Button();
            this.btnCaptureStop = new System.Windows.Forms.Button();
            this.btnSaveDump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(211, 52);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(187, 20);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "239.0.1.66";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multicast IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // nupPort
            // 
            this.nupPort.Location = new System.Drawing.Point(532, 51);
            this.nupPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nupPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPort.Name = "nupPort";
            this.nupPort.Size = new System.Drawing.Size(120, 20);
            this.nupPort.TabIndex = 3;
            this.nupPort.Value = new decimal(new int[] {
            11002,
            0,
            0,
            0});
            // 
            // btnCaptureStart
            // 
            this.btnCaptureStart.Location = new System.Drawing.Point(66, 138);
            this.btnCaptureStart.Name = "btnCaptureStart";
            this.btnCaptureStart.Size = new System.Drawing.Size(90, 23);
            this.btnCaptureStart.TabIndex = 4;
            this.btnCaptureStart.Text = "Start Capture";
            this.btnCaptureStart.UseVisualStyleBackColor = true;
            this.btnCaptureStart.Click += new System.EventHandler(this.btnCaptureStart_Click);
            // 
            // btnCaptureStop
            // 
            this.btnCaptureStop.Location = new System.Drawing.Point(240, 138);
            this.btnCaptureStop.Name = "btnCaptureStop";
            this.btnCaptureStop.Size = new System.Drawing.Size(87, 23);
            this.btnCaptureStop.TabIndex = 5;
            this.btnCaptureStop.Text = "Stop Capture";
            this.btnCaptureStop.UseVisualStyleBackColor = true;
            this.btnCaptureStop.Click += new System.EventHandler(this.btnCaptureStop_Click);
            // 
            // btnSaveDump
            // 
            this.btnSaveDump.Location = new System.Drawing.Point(419, 138);
            this.btnSaveDump.Name = "btnSaveDump";
            this.btnSaveDump.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDump.TabIndex = 6;
            this.btnSaveDump.Text = "Save";
            this.btnSaveDump.UseVisualStyleBackColor = true;
            this.btnSaveDump.Click += new System.EventHandler(this.btnSaveDump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 182);
            this.Controls.Add(this.btnSaveDump);
            this.Controls.Add(this.btnCaptureStop);
            this.Controls.Add(this.btnCaptureStart);
            this.Controls.Add(this.nupPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Ultimate 64 Debug Stream Dumper";
            ((System.ComponentModel.ISupportInitialize)(this.nupPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupPort;
        private System.Windows.Forms.Button btnCaptureStart;
        private System.Windows.Forms.Button btnCaptureStop;
        private System.Windows.Forms.Button btnSaveDump;
    }
}

