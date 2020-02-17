namespace CopyFiles
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFromPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToPath = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRefSource = new System.Windows.Forms.Button();
            this.btnRefDistination = new System.Windows.Forms.Button();
            this.folderBrowserDialogDistination = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtFromPath
            // 
            this.txtFromPath.Location = new System.Drawing.Point(74, 19);
            this.txtFromPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFromPath.Name = "txtFromPath";
            this.txtFromPath.Size = new System.Drawing.Size(330, 20);
            this.txtFromPath.TabIndex = 0;
            this.txtFromPath.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToPath
            // 
            this.txtToPath.Location = new System.Drawing.Point(74, 70);
            this.txtToPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtToPath.Name = "txtToPath";
            this.txtToPath.Size = new System.Drawing.Size(330, 20);
            this.txtToPath.TabIndex = 4;
            this.txtToPath.TextChanged += new System.EventHandler(this.txtDistination_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(349, 103);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(54, 28);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // folderBrowserDialogSource
            // 
            this.folderBrowserDialogSource.Description = "Select source folder";
            // 
            // btnRefSource
            // 
            this.btnRefSource.Location = new System.Drawing.Point(406, 14);
            this.btnRefSource.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefSource.Name = "btnRefSource";
            this.btnRefSource.Size = new System.Drawing.Size(56, 29);
            this.btnRefSource.TabIndex = 6;
            this.btnRefSource.Text = "Ref";
            this.btnRefSource.UseVisualStyleBackColor = true;
            this.btnRefSource.Click += new System.EventHandler(this.btnRefSource_Click);
            // 
            // btnRefDistination
            // 
            this.btnRefDistination.Location = new System.Drawing.Point(407, 64);
            this.btnRefDistination.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefDistination.Name = "btnRefDistination";
            this.btnRefDistination.Size = new System.Drawing.Size(56, 29);
            this.btnRefDistination.TabIndex = 7;
            this.btnRefDistination.Text = "Ref";
            this.btnRefDistination.UseVisualStyleBackColor = true;
            this.btnRefDistination.Click += new System.EventHandler(this.btnRefDistination_Click);
            // 
            // folderBrowserDialogDistination
            // 
            this.folderBrowserDialogDistination.Description = "Select distination folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 140);
            this.Controls.Add(this.btnRefDistination);
            this.Controls.Add(this.btnRefSource);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtToPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFromPath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Copy ALL Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToPath;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.Button btnRefSource;
        private System.Windows.Forms.Button btnRefDistination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDistination;
    }
}

