namespace LibraryManagementSystem {
    partial class frmWelcome {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btngotologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Library Management System";
            // 
            // btngotologin
            // 
            this.btngotologin.Location = new System.Drawing.Point(261, 102);
            this.btngotologin.Name = "btngotologin";
            this.btngotologin.Size = new System.Drawing.Size(77, 29);
            this.btngotologin.TabIndex = 1;
            this.btngotologin.Text = "Login ?";
            this.btngotologin.UseVisualStyleBackColor = true;
            this.btngotologin.Click += new System.EventHandler(this.btngotologin_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 162);
            this.Controls.Add(this.btngotologin);
            this.Controls.Add(this.label1);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngotologin;
    }
}

