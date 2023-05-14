namespace DedukoPaskola3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSign = new System.Windows.Forms.Button();
            this.mainLog = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainName = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSign
            // 
            this.mainSign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSign.FlatAppearance.BorderSize = 0;
            this.mainSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSign.ForeColor = System.Drawing.Color.White;
            this.mainSign.Location = new System.Drawing.Point(14, 154);
            this.mainSign.MinimumSize = new System.Drawing.Size(100, 50);
            this.mainSign.Name = "mainSign";
            this.mainSign.Size = new System.Drawing.Size(192, 50);
            this.mainSign.TabIndex = 10;
            this.mainSign.Text = "Sign Up";
            this.mainSign.UseVisualStyleBackColor = true;
            this.mainSign.Click += new System.EventHandler(this.mainSign_Click);
            // 
            // mainLog
            // 
            this.mainLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLog.FlatAppearance.BorderSize = 0;
            this.mainLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLog.ForeColor = System.Drawing.Color.White;
            this.mainLog.Location = new System.Drawing.Point(14, 247);
            this.mainLog.MinimumSize = new System.Drawing.Size(120, 50);
            this.mainLog.Name = "mainLog";
            this.mainLog.Size = new System.Drawing.Size(192, 50);
            this.mainLog.TabIndex = 11;
            this.mainLog.Text = "Log In";
            this.mainLog.UseVisualStyleBackColor = true;
            this.mainLog.Click += new System.EventHandler(this.mainLog_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(14, 559);
            this.exitButton.MinimumSize = new System.Drawing.Size(120, 50);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(192, 50);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.mainName);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.mainSign);
            this.mainPanel.Controls.Add(this.mainLog);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(236, 625);
            this.mainPanel.TabIndex = 10;
            // 
            // mainName
            // 
            this.mainName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.mainName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainName.ForeColor = System.Drawing.Color.Aqua;
            this.mainName.Location = new System.Drawing.Point(14, 36);
            this.mainName.Margin = new System.Windows.Forms.Padding(0);
            this.mainName.MaxLength = 16;
            this.mainName.Multiline = true;
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            this.mainName.Size = new System.Drawing.Size(192, 86);
            this.mainName.TabIndex = 12;
            this.mainName.Text = "Dėduko\r\nPaskola";
            this.mainName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainName.WordWrap = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.Location = new System.Drawing.Point(1089, 590);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.phoneNumber.MaxLength = 16;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Size = new System.Drawing.Size(333, 38);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.Text = "Tel. Nr. 8 64893341";
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1431, 646);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainLog;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Button mainSign;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox mainName;
    }
}

