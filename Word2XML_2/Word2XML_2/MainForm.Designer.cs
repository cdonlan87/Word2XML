namespace Word2XML_2
{
    partial class MainForm
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.extractButtonXML = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.fileSelectedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSavedTextBox = new System.Windows.Forms.TextBox();
            this.extractButtonXML2 = new System.Windows.Forms.Button();
            this.extractButtonJSON = new System.Windows.Forms.Button();
            this.extractButtonJSON2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Extract a Word Document, Select a file, Extract, and Save the new XML document" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Selected:";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(351, 72);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(111, 23);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // extractButtonXML
            // 
            this.extractButtonXML.Enabled = false;
            this.extractButtonXML.Location = new System.Drawing.Point(351, 101);
            this.extractButtonXML.Name = "extractButtonXML";
            this.extractButtonXML.Size = new System.Drawing.Size(111, 23);
            this.extractButtonXML.TabIndex = 3;
            this.extractButtonXML.Text = "Extract File XML";
            this.extractButtonXML.UseVisualStyleBackColor = true;
            this.extractButtonXML.Click += new System.EventHandler(this.extractButtonXML_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Enabled = false;
            this.saveFileButton.Location = new System.Drawing.Point(351, 159);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(111, 23);
            this.saveFileButton.TabIndex = 4;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // fileSelectedTextBox
            // 
            this.fileSelectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileSelectedTextBox.Location = new System.Drawing.Point(89, 75);
            this.fileSelectedTextBox.Name = "fileSelectedTextBox";
            this.fileSelectedTextBox.ReadOnly = true;
            this.fileSelectedTextBox.Size = new System.Drawing.Size(187, 20);
            this.fileSelectedTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Saved:";
            // 
            // fileSavedTextBox
            // 
            this.fileSavedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileSavedTextBox.Location = new System.Drawing.Point(89, 128);
            this.fileSavedTextBox.Name = "fileSavedTextBox";
            this.fileSavedTextBox.ReadOnly = true;
            this.fileSavedTextBox.Size = new System.Drawing.Size(187, 20);
            this.fileSavedTextBox.TabIndex = 7;
            // 
            // extractButtonXML2
            // 
            this.extractButtonXML2.Enabled = false;
            this.extractButtonXML2.Location = new System.Drawing.Point(481, 101);
            this.extractButtonXML2.Name = "extractButtonXML2";
            this.extractButtonXML2.Size = new System.Drawing.Size(120, 23);
            this.extractButtonXML2.TabIndex = 9;
            this.extractButtonXML2.Text = "Extract File XML2";
            this.extractButtonXML2.UseVisualStyleBackColor = true;
            this.extractButtonXML2.Click += new System.EventHandler(this.extractButtonXML2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 261);
            this.Controls.Add(this.extractButtonJSON2);
            this.Controls.Add(this.extractButtonJSON);
            this.Controls.Add(this.extractButtonXML2);
            this.Controls.Add(this.fileSavedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileSelectedTextBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.extractButtonXML);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button extractButtonXML;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TextBox fileSelectedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileSavedTextBox;
        private System.Windows.Forms.Button extractButtonXML2;
        private System.Windows.Forms.Button extractButtonJSON;
        private System.Windows.Forms.Button extractButtonJSON2;
    }
}

