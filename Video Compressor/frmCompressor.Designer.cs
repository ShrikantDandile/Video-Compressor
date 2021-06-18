
namespace Video_Compressor
{
   partial class Compressor
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
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.btnBrowseOutputPath = new System.Windows.Forms.Button();
         this.btnCompress = new System.Windows.Forms.Button();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(136, 15);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(779, 56);
         this.textBox1.TabIndex = 0;
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(913, 14);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(94, 57);
         this.btnBrowse.TabIndex = 1;
         this.btnBrowse.Text = "Browse";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(102, 20);
         this.label1.TabIndex = 2;
         this.label1.Text = "Input File Path";
         // 
         // btnBrowseOutputPath
         // 
         this.btnBrowseOutputPath.Location = new System.Drawing.Point(555, 89);
         this.btnBrowseOutputPath.Name = "btnBrowseOutputPath";
         this.btnBrowseOutputPath.Size = new System.Drawing.Size(231, 56);
         this.btnBrowseOutputPath.TabIndex = 4;
         this.btnBrowseOutputPath.Text = "Open";
         this.btnBrowseOutputPath.UseVisualStyleBackColor = true;
         this.btnBrowseOutputPath.Click += new System.EventHandler(this.btnBrowseOutputPath_Click);
         // 
         // btnCompress
         // 
         this.btnCompress.Location = new System.Drawing.Point(270, 89);
         this.btnCompress.Name = "btnCompress";
         this.btnCompress.Size = new System.Drawing.Size(231, 56);
         this.btnCompress.TabIndex = 6;
         this.btnCompress.Text = "Compress Video";
         this.btnCompress.UseVisualStyleBackColor = true;
         this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(12, 175);
         this.textBox3.Multiline = true;
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(995, 175);
         this.textBox3.TabIndex = 7;
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(12, 356);
         this.textBox4.Multiline = true;
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(409, 105);
         this.textBox4.TabIndex = 8;
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(427, 356);
         this.textBox5.Multiline = true;
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(580, 105);
         this.textBox5.TabIndex = 9;
         // 
         // Compressor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1019, 471);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.btnCompress);
         this.Controls.Add(this.btnBrowseOutputPath);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnBrowse);
         this.Controls.Add(this.textBox1);
         this.ForeColor = System.Drawing.SystemColors.Highlight;
         this.Name = "Compressor";
         this.Text = "Compressor";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnBrowseOutputPath;
      private System.Windows.Forms.Button btnCompress;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox5;
   }
}

