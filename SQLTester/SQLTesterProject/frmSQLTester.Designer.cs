namespace SQLTesterProject
{
    partial class frmSQLTester
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvResults = new DataGridView();
            txtQuery = new TextBox();
            btnExecuteQuery = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lblNumRecords = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(54, 36);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(1304, 425);
            dgvResults.TabIndex = 4;
            // 
            // txtQuery
            // 
            txtQuery.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuery.Location = new Point(54, 480);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(831, 224);
            txtQuery.TabIndex = 0;
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExecuteQuery.Location = new Point(941, 480);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new Size(417, 45);
            btnExecuteQuery.TabIndex = 1;
            btnExecuteQuery.Text = "&Execute";
            btnExecuteQuery.UseVisualStyleBackColor = true;
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(941, 659);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(417, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(941, 598);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(417, 45);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblNumRecords
            // 
            lblNumRecords.BackColor = Color.Cyan;
            lblNumRecords.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRecords.Location = new Point(959, 545);
            lblNumRecords.Name = "lblNumRecords";
            lblNumRecords.Size = new Size(98, 36);
            lblNumRecords.TabIndex = 5;
            lblNumRecords.Text = "0";
            lblNumRecords.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Cyan;
            lblTitle.Font = new Font("Arial Narrow", 18.25F, FontStyle.Bold);
            lblTitle.Location = new Point(1078, 545);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 36);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Rows Returned";
            // 
            // frmSQLTester
            // 
            AcceptButton = btnExecuteQuery;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            CancelButton = btnClear;
            ClientSize = new Size(1402, 729);
            Controls.Add(lblTitle);
            Controls.Add(lblNumRecords);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnExecuteQuery);
            Controls.Add(txtQuery);
            Controls.Add(dgvResults);
            Name = "frmSQLTester";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Tester";
            Load += this.frmSQLTester_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResults;
        private TextBox txtQuery;
        private Button btnExecuteQuery;
        private Button btnExit;
        private Button btnClear;
        private Label lblNumRecords;
        private Label lblTitle;
    }
}
