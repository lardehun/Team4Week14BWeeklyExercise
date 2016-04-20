namespace G_CSHARP_Team4_Sanity_Archive
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
            this.driverLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.dirListBox = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.xxxxx = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.cutButton = new System.Windows.Forms.Button();
            this.propertiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(12, 34);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(35, 13);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "Driver";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 61);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(53, 31);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(378, 21);
            this.driverComboBox.TabIndex = 2;
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(53, 58);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(378, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // dirListBox
            // 
            this.dirListBox.FormattingEnabled = true;
            this.dirListBox.Location = new System.Drawing.Point(15, 92);
            this.dirListBox.Name = "dirListBox";
            this.dirListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dirListBox.Size = new System.Drawing.Size(416, 212);
            this.dirListBox.TabIndex = 4;
            this.dirListBox.SelectedIndexChanged += new System.EventHandler(this.dirListBox_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 326);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(93, 326);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(75, 23);
            this.compressButton.TabIndex = 6;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(275, 326);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(356, 326);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(75, 23);
            this.pasteButton.TabIndex = 8;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            // 
            // xxxxx
            // 
            this.xxxxx.AutoSize = true;
            this.xxxxx.Location = new System.Drawing.Point(12, 310);
            this.xxxxx.Name = "xxxxx";
            this.xxxxx.Size = new System.Drawing.Size(69, 13);
            this.xxxxx.TabIndex = 9;
            this.xxxxx.Text = "Space Used:";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(87, 310);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(13, 13);
            this.spaceLabel.TabIndex = 10;
            this.spaceLabel.Text = "0";
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(275, 355);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(75, 23);
            this.cutButton.TabIndex = 11;
            this.cutButton.Text = "Cut";
            this.cutButton.UseVisualStyleBackColor = true;
            // 
            // propertiesButton
            // 
            this.propertiesButton.Location = new System.Drawing.Point(12, 355);
            this.propertiesButton.Name = "propertiesButton";
            this.propertiesButton.Size = new System.Drawing.Size(75, 23);
            this.propertiesButton.TabIndex = 12;
            this.propertiesButton.Text = "Properties";
            this.propertiesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 382);
            this.Controls.Add(this.propertiesButton);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.xxxxx);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dirListBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.driverLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ListBox dirListBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Label xxxxx;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.Button propertiesButton;
    }
}

