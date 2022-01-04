namespace BranchingPractice
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
            this.btnDisplayGreeting = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplayGreeting
            // 
            this.btnDisplayGreeting.Location = new System.Drawing.Point(65, 126);
            this.btnDisplayGreeting.Name = "btnDisplayGreeting";
            this.btnDisplayGreeting.Size = new System.Drawing.Size(100, 62);
            this.btnDisplayGreeting.TabIndex = 0;
            this.btnDisplayGreeting.Text = "Display Greeting";
            this.btnDisplayGreeting.UseVisualStyleBackColor = true;
            this.btnDisplayGreeting.Click += new System.EventHandler(this.btnDisplayGreeting_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDisplayGreeting);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplayGreeting;
        private TextBox txtName;
    }
}