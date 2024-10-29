namespace WinFormsAppSushma
{
    partial class StorePWithMultipleParameters
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtEmpId = new Label();
            txtEmpName = new Label();
            txtEmpDesig = new Label();
            txtEmpDOJ = new Label();
            txtEmpSal = new Label();
            txtEmpDept = new Label();
            textBox6 = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtFind = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(312, 274);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // txtEmpId
            // 
            txtEmpId.AutoSize = true;
            txtEmpId.Location = new Point(68, 34);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(56, 20);
            txtEmpId.TabIndex = 5;
            txtEmpId.Text = "Emp Id";
            // 
            // txtEmpName
            // 
            txtEmpName.AutoSize = true;
            txtEmpName.Location = new Point(64, 96);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(87, 20);
            txtEmpName.TabIndex = 6;
            txtEmpName.Text = "Emp Name ";
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.AutoSize = true;
            txtEmpDesig.Location = new Point(64, 153);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(123, 20);
            txtEmpDesig.TabIndex = 7;
            txtEmpDesig.Text = "Emp Designation";
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.AutoSize = true;
            txtEmpDOJ.Location = new Point(70, 218);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(70, 20);
            txtEmpDOJ.TabIndex = 8;
            txtEmpDOJ.Text = "Emp DOJ";
            // 
            // txtEmpSal
            // 
            txtEmpSal.AutoSize = true;
            txtEmpSal.Location = new Point(64, 274);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(83, 20);
            txtEmpSal.TabIndex = 9;
            txtEmpSal.Text = "Emp Salary";
            // 
            // txtEmpDept
            // 
            txtEmpDept.AutoSize = true;
            txtEmpDept.Location = new Point(64, 337);
            txtEmpDept.Name = "txtEmpDept";
            txtEmpDept.Size = new Size(76, 20);
            txtEmpDept.TabIndex = 10;
            txtEmpDept.Text = "Emp Dept";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(312, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(57, 382);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseMnemonic = false;
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(230, 382);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(57, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 417);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(417, 399);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(94, 29);
            txtFind.TabIndex = 16;
            txtFind.Text = "Find";
            txtFind.UseVisualStyleBackColor = true;
            txtFind.Click += txtFind_Click;
            // 
            // StorePWithMultipleParameters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFind);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBox6);
            Controls.Add(txtEmpDept);
            Controls.Add(txtEmpSal);
            Controls.Add(txtEmpDOJ);
            Controls.Add(txtEmpDesig);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "StorePWithMultipleParameters";
            Text = "StorePWithMultipleParameters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label txtEmpId;
        private Label txtEmpName;
        private Label txtEmpDesig;
        private Label txtEmpDOJ;
        private Label txtEmpSal;
        private Label txtEmpDept;
        private TextBox textBox6;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button txtFind;
    }
}