namespace NotesApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BttnNew = new System.Windows.Forms.Button();
            this.BttnSave = new System.Windows.Forms.Button();
            this.BttnRead = new System.Windows.Forms.Button();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.GoForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(112, 110);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.Location = new System.Drawing.Point(112, 149);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(331, 185);
            this.txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 4;
            // 
            // BttnNew
            // 
            this.BttnNew.Location = new System.Drawing.Point(112, 385);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Size = new System.Drawing.Size(100, 28);
            this.BttnNew.TabIndex = 5;
            this.BttnNew.Text = "New";
            this.BttnNew.UseVisualStyleBackColor = true;
            this.BttnNew.Click += new System.EventHandler(this.BttnNew_Click);
            // 
            // BttnSave
            // 
            this.BttnSave.Location = new System.Drawing.Point(368, 385);
            this.BttnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(100, 28);
            this.BttnSave.TabIndex = 6;
            this.BttnSave.Text = "Save";
            this.BttnSave.UseVisualStyleBackColor = true;
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // BttnRead
            // 
            this.BttnRead.Location = new System.Drawing.Point(477, 385);
            this.BttnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnRead.Name = "BttnRead";
            this.BttnRead.Size = new System.Drawing.Size(100, 28);
            this.BttnRead.TabIndex = 7;
            this.BttnRead.Text = "Read";
            this.BttnRead.UseVisualStyleBackColor = true;
            this.BttnRead.Click += new System.EventHandler(this.BttnRead_Click);
            // 
            // BttnDelete
            // 
            this.BttnDelete.Location = new System.Drawing.Point(699, 385);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(100, 28);
            this.BttnDelete.TabIndex = 8;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // GoForm2
            // 
            this.GoForm2.Location = new System.Drawing.Point(112, 22);
            this.GoForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoForm2.Name = "GoForm2";
            this.GoForm2.Size = new System.Drawing.Size(232, 28);
            this.GoForm2.TabIndex = 9;
            this.GoForm2.Text = "Open Second Form";
            this.GoForm2.UseVisualStyleBackColor = true;
            this.GoForm2.Click += new System.EventHandler(this.GoForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 471);
            this.Controls.Add(this.GoForm2);
            this.Controls.Add(this.BttnDelete);
            this.Controls.Add(this.BttnRead);
            this.Controls.Add(this.BttnSave);
            this.Controls.Add(this.BttnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.SandyBrown;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button GoForm2;
    }
}

