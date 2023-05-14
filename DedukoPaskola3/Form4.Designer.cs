namespace DedukoPaskola3
{
    partial class mainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainProgram));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableID = new System.Windows.Forms.Label();
            this.tableIDBox = new System.Windows.Forms.TextBox();
            this.tableFirstName = new System.Windows.Forms.Label();
            this.tableFirstBox = new System.Windows.Forms.TextBox();
            this.tableLastName = new System.Windows.Forms.Label();
            this.tableLastBox = new System.Windows.Forms.TextBox();
            this.tableAmountLoaned = new System.Windows.Forms.Label();
            this.tableAmountBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(561, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableID
            // 
            this.tableID.AutoSize = true;
            this.tableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableID.ForeColor = System.Drawing.Color.Aqua;
            this.tableID.Location = new System.Drawing.Point(226, 63);
            this.tableID.Name = "tableID";
            this.tableID.Size = new System.Drawing.Size(61, 37);
            this.tableID.TabIndex = 5;
            this.tableID.Text = "ID:";
            this.tableID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableIDBox
            // 
            this.tableIDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.tableIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableIDBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIDBox.ForeColor = System.Drawing.Color.White;
            this.tableIDBox.Location = new System.Drawing.Point(302, 71);
            this.tableIDBox.Margin = new System.Windows.Forms.Padding(0);
            this.tableIDBox.MaxLength = 16;
            this.tableIDBox.Name = "tableIDBox";
            this.tableIDBox.Size = new System.Drawing.Size(220, 32);
            this.tableIDBox.TabIndex = 6;
            // 
            // tableFirstName
            // 
            this.tableFirstName.AutoSize = true;
            this.tableFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableFirstName.ForeColor = System.Drawing.Color.Aqua;
            this.tableFirstName.Location = new System.Drawing.Point(92, 139);
            this.tableFirstName.Name = "tableFirstName";
            this.tableFirstName.Size = new System.Drawing.Size(195, 37);
            this.tableFirstName.TabIndex = 7;
            this.tableFirstName.Text = "First Name:";
            this.tableFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableFirstBox
            // 
            this.tableFirstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.tableFirstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableFirstBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableFirstBox.ForeColor = System.Drawing.Color.White;
            this.tableFirstBox.Location = new System.Drawing.Point(302, 144);
            this.tableFirstBox.Margin = new System.Windows.Forms.Padding(0);
            this.tableFirstBox.MaxLength = 16;
            this.tableFirstBox.Name = "tableFirstBox";
            this.tableFirstBox.Size = new System.Drawing.Size(220, 32);
            this.tableFirstBox.TabIndex = 8;
            // 
            // tableLastName
            // 
            this.tableLastName.AutoSize = true;
            this.tableLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLastName.ForeColor = System.Drawing.Color.Aqua;
            this.tableLastName.Location = new System.Drawing.Point(96, 209);
            this.tableLastName.Name = "tableLastName";
            this.tableLastName.Size = new System.Drawing.Size(191, 37);
            this.tableLastName.TabIndex = 9;
            this.tableLastName.Text = "Last Name:";
            this.tableLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLastBox
            // 
            this.tableLastBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.tableLastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLastBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLastBox.ForeColor = System.Drawing.Color.White;
            this.tableLastBox.Location = new System.Drawing.Point(302, 214);
            this.tableLastBox.Margin = new System.Windows.Forms.Padding(0);
            this.tableLastBox.MaxLength = 16;
            this.tableLastBox.Name = "tableLastBox";
            this.tableLastBox.Size = new System.Drawing.Size(220, 32);
            this.tableLastBox.TabIndex = 10;
            // 
            // tableAmountLoaned
            // 
            this.tableAmountLoaned.AutoSize = true;
            this.tableAmountLoaned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableAmountLoaned.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableAmountLoaned.ForeColor = System.Drawing.Color.Aqua;
            this.tableAmountLoaned.Location = new System.Drawing.Point(18, 278);
            this.tableAmountLoaned.Name = "tableAmountLoaned";
            this.tableAmountLoaned.Size = new System.Drawing.Size(269, 37);
            this.tableAmountLoaned.TabIndex = 11;
            this.tableAmountLoaned.Text = "Amount Loaned:";
            this.tableAmountLoaned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAmountBox
            // 
            this.tableAmountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.tableAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableAmountBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableAmountBox.ForeColor = System.Drawing.Color.White;
            this.tableAmountBox.Location = new System.Drawing.Point(302, 283);
            this.tableAmountBox.Margin = new System.Windows.Forms.Padding(0);
            this.tableAmountBox.MaxLength = 16;
            this.tableAmountBox.Name = "tableAmountBox";
            this.tableAmountBox.Size = new System.Drawing.Size(220, 32);
            this.tableAmountBox.TabIndex = 12;
            // 
            // submitButton
            // 
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(302, 359);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(220, 67);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(25, 556);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(208, 67);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(302, 441);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(220, 67);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(302, 514);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(220, 67);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1120, 646);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.tableAmountBox);
            this.Controls.Add(this.tableAmountLoaned);
            this.Controls.Add(this.tableLastBox);
            this.Controls.Add(this.tableLastName);
            this.Controls.Add(this.tableFirstBox);
            this.Controls.Add(this.tableFirstName);
            this.Controls.Add(this.tableIDBox);
            this.Controls.Add(this.tableID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(1136, 762);
            this.Name = "mainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Deactivate += new System.EventHandler(this.mainProgram_Deactivate);
            this.Load += new System.EventHandler(this.mainProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tableID;
        private System.Windows.Forms.TextBox tableIDBox;
        private System.Windows.Forms.Label tableFirstName;
        private System.Windows.Forms.TextBox tableFirstBox;
        private System.Windows.Forms.Label tableLastName;
        private System.Windows.Forms.TextBox tableLastBox;
        private System.Windows.Forms.Label tableAmountLoaned;
        private System.Windows.Forms.TextBox tableAmountBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}