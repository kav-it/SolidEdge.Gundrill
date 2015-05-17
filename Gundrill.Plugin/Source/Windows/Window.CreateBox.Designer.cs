namespace GundrillPlugin.Source.Windows
{
    partial class WindowCreateBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(213, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(320, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Значение X (mm):";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(226, 41);
            this.trackBarX.Maximum = 100;
            this.trackBarX.Minimum = 10;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(192, 56);
            this.trackBarX.TabIndex = 3;
            this.trackBarX.TickFrequency = 5;
            this.trackBarX.Value = 10;
            this.trackBarX.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(172, 43);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 17);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "10";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(172, 87);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 17);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "10";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(226, 85);
            this.trackBarY.Maximum = 100;
            this.trackBarY.Minimum = 10;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(192, 56);
            this.trackBarY.TabIndex = 6;
            this.trackBarY.TickFrequency = 5;
            this.trackBarY.Value = 10;
            this.trackBarY.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Значение Y (mm):";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(172, 131);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(24, 17);
            this.labelZ.TabIndex = 11;
            this.labelZ.Text = "10";
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(226, 129);
            this.trackBarZ.Maximum = 100;
            this.trackBarZ.Minimum = 10;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(192, 56);
            this.trackBarZ.TabIndex = 10;
            this.trackBarZ.TickFrequency = 5;
            this.trackBarZ.Value = 10;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Значение Z (mm):";
            // 
            // WindowCreateBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(422, 233);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 280);
            this.Name = "WindowCreateBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод параметров";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Label label6;
    }
}