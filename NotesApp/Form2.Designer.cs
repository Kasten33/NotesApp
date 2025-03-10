namespace NotesApp
{
    partial class Form2
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
            this.GoForm1 = new System.Windows.Forms.Button();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.txtMessage2 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoForm1
            // 
            this.GoForm1.Location = new System.Drawing.Point(45, 336);
            this.GoForm1.Name = "GoForm1";
            this.GoForm1.Size = new System.Drawing.Size(75, 23);
            this.GoForm1.TabIndex = 0;
            this.GoForm1.Text = "Go Back";
            this.GoForm1.UseVisualStyleBackColor = true;
            this.GoForm1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle2
            // 
            this.txtTitle2.Location = new System.Drawing.Point(45, 54);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(140, 22);
            this.txtTitle2.TabIndex = 1;
            this.txtTitle2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMessage2
            // 
            this.txtMessage2.Location = new System.Drawing.Point(45, 98);
            this.txtMessage2.Multiline = true;
            this.txtMessage2.Name = "txtMessage2";
            this.txtMessage2.Size = new System.Drawing.Size(640, 197);
            this.txtMessage2.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(610, 336);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(697, 399);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.txtMessage2);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.GoForm1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttnNew;
        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Button BttnRead;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Button GoForm1;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.TextBox txtMessage2;
        private System.Windows.Forms.Button Delete;
    }
}

