using System;

namespace krisParserApp
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
            this.parseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadFilesButton = new System.Windows.Forms.Button();
            this.loadedFilesListBox = new System.Windows.Forms.ListBox();
            this.selectFilesToParseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lexis Nexis File Parser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // parseButton
            // 
            this.parseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parseButton.Location = new System.Drawing.Point(448, 365);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(157, 38);
            this.parseButton.TabIndex = 4;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(173, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "S";
            this.openFileDialog1.Multiselect = true;
            // 
            // button1
            // 
            this.loadFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFilesButton.Location = new System.Drawing.Point(308, 57);
            this.loadFilesButton.Name = "loadFiles";
            this.loadFilesButton.Size = new System.Drawing.Size(157, 38);
            this.loadFilesButton.TabIndex = 6;
            this.loadFilesButton.Text = "Load Files";
            this.loadFilesButton.UseVisualStyleBackColor = true;
            this.loadFilesButton.Click += new System.EventHandler(this.loadFilesButton_Click);
            // 
            // listBox1
            // 
            this.loadedFilesListBox.FormattingEnabled = true;
            this.loadedFilesListBox.ItemHeight = 16;
            this.loadedFilesListBox.Location = new System.Drawing.Point(220, 149);
            this.loadedFilesListBox.Name = "loadedFilesListBox";
            this.loadedFilesListBox.Size = new System.Drawing.Size(340, 196);
            this.loadedFilesListBox.TabIndex = 7;
            this.loadedFilesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.selectFilesToParseLabel.AutoSize = true;
            this.selectFilesToParseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectFilesToParseLabel.Location = new System.Drawing.Point(215, 121);
            this.selectFilesToParseLabel.Name = "selectFilesToParseLabel";
            this.selectFilesToParseLabel.Size = new System.Drawing.Size(198, 25);
            this.selectFilesToParseLabel.TabIndex = 8;
            this.selectFilesToParseLabel.Text = "Select Files To Parse";
            this.selectFilesToParseLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ParserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectFilesToParseLabel);
            this.Controls.Add(this.loadedFilesListBox);
            this.Controls.Add(this.loadFilesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.label1);
            this.Name = "ParserUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loadFilesButton;
        private System.Windows.Forms.ListBox loadedFilesListBox;
        private System.Windows.Forms.Label selectFilesToParseLabel;
    }
}

