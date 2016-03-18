namespace Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReturnType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl = new System.Windows.Forms.DataGridView();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXECUTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultText
            // 
            this.txtResultText.Location = new System.Drawing.Point(12, 181);
            this.txtResultText.Multiline = true;
            this.txtResultText.Name = "txtResultText";
            this.txtResultText.Size = new System.Drawing.Size(588, 191);
            this.txtResultText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result JSON / XML";
            // 
            // cmbReturnType
            // 
            this.cmbReturnType.FormattingEnabled = true;
            this.cmbReturnType.Items.AddRange(new object[] {
            "JSON",
            "DataTable",
            "List - Disctionary"});
            this.cmbReturnType.Location = new System.Drawing.Point(284, 17);
            this.cmbReturnType.Name = "cmbReturnType";
            this.cmbReturnType.Size = new System.Drawing.Size(121, 21);
            this.cmbReturnType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Return Type";
            // 
            // tbl
            // 
            this.tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl.Location = new System.Drawing.Point(12, 416);
            this.tbl.Name = "tbl";
            this.tbl.Size = new System.Drawing.Size(591, 271);
            this.tbl.TabIndex = 7;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Items.AddRange(new object[] {
            "MySql",
            "Oracle",
            "SqlServer"});
            this.cmbDatabase.Location = new System.Drawing.Point(479, 17);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(121, 21);
            this.cmbDatabase.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Database : ";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(12, 44);
            this.txtConnString.Multiline = true;
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(588, 99);
            this.txtConnString.TabIndex = 10;
            this.txtConnString.Text = "Server = DESKTOP-2OBTFN2\\\\SQLEXPRESS; Database = ipss_tes; User Id = sertac;Passw" +
    "ord = exitexit1;\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Conn String : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Result DataTable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Result List Object : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(132, 728);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Result List Object : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 781);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbReturnType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReturnType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbl;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
    }
}

