namespace ExecuteSQL
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
            this.rtxtTableView = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReviewTable = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInsertNameID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.txtInsertEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateNameID = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtDeleteNameID = new System.Windows.Forms.TextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateSearch = new System.Windows.Forms.Button();
            this.btnDeleteSearch = new System.Windows.Forms.Button();
            this.btnUpdateApply = new System.Windows.Forms.Button();
            this.btnDeleteApply = new System.Windows.Forms.Button();
            this.btnInsertApply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTableView
            // 
            this.rtxtTableView.Location = new System.Drawing.Point(516, 43);
            this.rtxtTableView.Name = "rtxtTableView";
            this.rtxtTableView.ReadOnly = true;
            this.rtxtTableView.Size = new System.Drawing.Size(170, 362);
            this.rtxtTableView.TabIndex = 0;
            this.rtxtTableView.Text = "";
            this.rtxtTableView.TextChanged += new System.EventHandler(this.rtxtTableView_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connected Server:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connected DB:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSERT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(1, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "DELETE:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "DICYUKIYANO\\SQLEXPRESS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Test";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "UPDATE:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Connected Table:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(208, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "dbo.TestTable";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(68, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "NameID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(68, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(30, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email Address:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(106, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "NameID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(2, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Input new NameID, Name, Email Address.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(2, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(426, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Specifying row by NameID (Primary Key). Before pushing Apply button, the Name ID " +
    "form";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReviewTable
            // 
            this.btnReviewTable.Location = new System.Drawing.Point(549, 14);
            this.btnReviewTable.Name = "btnReviewTable";
            this.btnReviewTable.Size = new System.Drawing.Size(137, 23);
            this.btnReviewTable.TabIndex = 17;
            this.btnReviewTable.Text = "Review the Whole Table";
            this.btnReviewTable.UseVisualStyleBackColor = true;
            this.btnReviewTable.Click += new System.EventHandler(this.btnReviewTable_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(2, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(370, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "must be filled at least. You can search candidates by pushing Search button.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(106, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Name:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(68, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Email Address:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInsertNameID
            // 
            this.txtInsertNameID.Location = new System.Drawing.Point(132, 131);
            this.txtInsertNameID.Name = "txtInsertNameID";
            this.txtInsertNameID.Size = new System.Drawing.Size(226, 20);
            this.txtInsertNameID.TabIndex = 21;
            this.txtInsertNameID.TextChanged += new System.EventHandler(this.txtInsertNameID_TextChanged);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(106, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Name:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(68, 363);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "Email Address:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(132, 154);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(226, 20);
            this.txtInsertName.TabIndex = 25;
            this.txtInsertName.TextChanged += new System.EventHandler(this.txtInsertName_TextChanged);
            // 
            // txtInsertEmail
            // 
            this.txtInsertEmail.Location = new System.Drawing.Point(132, 177);
            this.txtInsertEmail.Name = "txtInsertEmail";
            this.txtInsertEmail.Size = new System.Drawing.Size(226, 20);
            this.txtInsertEmail.TabIndex = 26;
            this.txtInsertEmail.TextChanged += new System.EventHandler(this.txtInsertEmail_TextChanged);
            // 
            // txtUpdateNameID
            // 
            this.txtUpdateNameID.Location = new System.Drawing.Point(170, 237);
            this.txtUpdateNameID.Name = "txtUpdateNameID";
            this.txtUpdateNameID.Size = new System.Drawing.Size(226, 20);
            this.txtUpdateNameID.TabIndex = 28;
            this.txtUpdateNameID.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(170, 261);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(226, 20);
            this.txtUpdateName.TabIndex = 29;
            this.txtUpdateName.TextChanged += new System.EventHandler(this.txtUpdateName_TextChanged);
            // 
            // txtDeleteNameID
            // 
            this.txtDeleteNameID.Location = new System.Drawing.Point(170, 317);
            this.txtDeleteNameID.Name = "txtDeleteNameID";
            this.txtDeleteNameID.Size = new System.Drawing.Size(226, 20);
            this.txtDeleteNameID.TabIndex = 30;
            this.txtDeleteNameID.TextChanged += new System.EventHandler(this.txtDeleteNameID_TextChanged);
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(170, 340);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(226, 20);
            this.txtDeleteName.TabIndex = 32;
            this.txtDeleteName.TextChanged += new System.EventHandler(this.txtDeleteName_TextChanged);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(170, 284);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(226, 20);
            this.txtUpdateEmail.TabIndex = 35;
            this.txtUpdateEmail.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(106, 318);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "Name ID:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.Location = new System.Drawing.Point(170, 363);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.Size = new System.Drawing.Size(226, 20);
            this.txtDeleteEmail.TabIndex = 38;
            this.txtDeleteEmail.TextChanged += new System.EventHandler(this.txtDeleteEmail_TextChanged);
            // 
            // btnUpdateSearch
            // 
            this.btnUpdateSearch.Location = new System.Drawing.Point(402, 236);
            this.btnUpdateSearch.Name = "btnUpdateSearch";
            this.btnUpdateSearch.Size = new System.Drawing.Size(53, 66);
            this.btnUpdateSearch.TabIndex = 39;
            this.btnUpdateSearch.Text = "Search";
            this.btnUpdateSearch.UseVisualStyleBackColor = true;
            this.btnUpdateSearch.Click += new System.EventHandler(this.btnUpdateSearch_Click);
            // 
            // btnDeleteSearch
            // 
            this.btnDeleteSearch.Location = new System.Drawing.Point(402, 318);
            this.btnDeleteSearch.Name = "btnDeleteSearch";
            this.btnDeleteSearch.Size = new System.Drawing.Size(53, 66);
            this.btnDeleteSearch.TabIndex = 40;
            this.btnDeleteSearch.Text = "Search";
            this.btnDeleteSearch.UseVisualStyleBackColor = true;
            this.btnDeleteSearch.Click += new System.EventHandler(this.btnDeleteSearch_Click);
            // 
            // btnUpdateApply
            // 
            this.btnUpdateApply.Location = new System.Drawing.Point(457, 236);
            this.btnUpdateApply.Name = "btnUpdateApply";
            this.btnUpdateApply.Size = new System.Drawing.Size(53, 66);
            this.btnUpdateApply.TabIndex = 41;
            this.btnUpdateApply.Text = "Apply";
            this.btnUpdateApply.UseVisualStyleBackColor = true;
            this.btnUpdateApply.Click += new System.EventHandler(this.btnUpdateApply_Click);
            // 
            // btnDeleteApply
            // 
            this.btnDeleteApply.Location = new System.Drawing.Point(457, 318);
            this.btnDeleteApply.Name = "btnDeleteApply";
            this.btnDeleteApply.Size = new System.Drawing.Size(53, 66);
            this.btnDeleteApply.TabIndex = 42;
            this.btnDeleteApply.Text = "Apply";
            this.btnDeleteApply.UseVisualStyleBackColor = true;
            this.btnDeleteApply.Click += new System.EventHandler(this.btnDeleteApply_Click);
            // 
            // btnInsertApply
            // 
            this.btnInsertApply.Location = new System.Drawing.Point(364, 130);
            this.btnInsertApply.Name = "btnInsertApply";
            this.btnInsertApply.Size = new System.Drawing.Size(53, 66);
            this.btnInsertApply.TabIndex = 43;
            this.btnInsertApply.Text = "Apply";
            this.btnInsertApply.UseVisualStyleBackColor = true;
            this.btnInsertApply.Click += new System.EventHandler(this.btnInsertApply_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Location = new System.Drawing.Point(343, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 91);
            this.button1.TabIndex = 44;
            this.button1.Text = "This button is for the future";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsertApply);
            this.Controls.Add(this.btnDeleteApply);
            this.Controls.Add(this.btnUpdateApply);
            this.Controls.Add(this.btnDeleteSearch);
            this.Controls.Add(this.btnUpdateSearch);
            this.Controls.Add(this.txtDeleteEmail);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtUpdateEmail);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.txtDeleteNameID);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.txtUpdateNameID);
            this.Controls.Add(this.txtInsertEmail);
            this.Controls.Add(this.txtInsertName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtInsertNameID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnReviewTable);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtTableView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTableView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReviewTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInsertNameID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.TextBox txtInsertEmail;
        private System.Windows.Forms.TextBox txtUpdateNameID;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtDeleteNameID;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.Button btnUpdateSearch;
        private System.Windows.Forms.Button btnDeleteSearch;
        private System.Windows.Forms.Button btnUpdateApply;
        private System.Windows.Forms.Button btnDeleteApply;
        private System.Windows.Forms.Button btnInsertApply;
        private System.Windows.Forms.Button button1;
    }
}

