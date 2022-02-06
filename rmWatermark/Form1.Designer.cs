
namespace rmWatermark
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btn_ChoseFile = new System.Windows.Forms.Button();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(3, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(463, 23);
            this.txtPath.TabIndex = 1;
            // 
            // btn_ChoseFile
            // 
            this.btn_ChoseFile.Location = new System.Drawing.Point(472, 12);
            this.btn_ChoseFile.Name = "btn_ChoseFile";
            this.btn_ChoseFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChoseFile.TabIndex = 2;
            this.btn_ChoseFile.Text = "選擇路徑";
            this.btn_ChoseFile.UseVisualStyleBackColor = true;
            this.btn_ChoseFile.Click += new System.EventHandler(this.btn_ChoseFile_Click);
            // 
            // btn_Trans
            // 
            this.btn_Trans.Location = new System.Drawing.Point(472, 41);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(75, 23);
            this.btn_Trans.TabIndex = 3;
            this.btn_Trans.Text = "轉檔";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 68);
            this.Controls.Add(this.btn_Trans);
            this.Controls.Add(this.btn_ChoseFile);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "移除浮水印";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btn_ChoseFile;
        private System.Windows.Forms.Button btn_Trans;
    }
}

