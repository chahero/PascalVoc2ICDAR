namespace PascalVoc2ICDAR
{
    partial class FormConvertPascalVocToICDAR
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
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.buttonSaveAsICDAR2013Format = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.Location = new System.Drawing.Point(8, 8);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(512, 423);
            this.listViewFiles.TabIndex = 4;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragDrop);
            this.listViewFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragEnter);
            this.listViewFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewFiles_KeyDown);
            // 
            // buttonSaveAsICDAR2013Format
            // 
            this.buttonSaveAsICDAR2013Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAsICDAR2013Format.Location = new System.Drawing.Point(8, 440);
            this.buttonSaveAsICDAR2013Format.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveAsICDAR2013Format.Name = "buttonSaveAsICDAR2013Format";
            this.buttonSaveAsICDAR2013Format.Size = new System.Drawing.Size(511, 26);
            this.buttonSaveAsICDAR2013Format.TabIndex = 3;
            this.buttonSaveAsICDAR2013Format.Text = "Save As ICDAR 2013 Format";
            this.buttonSaveAsICDAR2013Format.UseVisualStyleBackColor = true;
            this.buttonSaveAsICDAR2013Format.Click += new System.EventHandler(this.buttonSaveAsICDAR2013Format_Click);
            // 
            // ConvertPascalVocToICDARForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 475);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.buttonSaveAsICDAR2013Format);
            this.Name = "ConvertPascalVocToICDARForm";
            this.Text = "ConvertPascalVocToICDARForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonSaveAsICDAR2013Format;
    }
}