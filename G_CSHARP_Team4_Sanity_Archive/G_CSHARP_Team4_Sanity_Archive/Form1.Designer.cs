﻿namespace G_CSHARP_Team4_Sanity_Archive
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
            this.explorerPanel = new System.Windows.Forms.Panel();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.removeReadOnlyButton = new System.Windows.Forms.Button();
            this.readOnlyButton = new System.Windows.Forms.Button();
            this.unHideButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.backToExplorerPanel = new System.Windows.Forms.Button();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.explorerPanel.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(3, 6);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(35, 13);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "Driver";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(3, 34);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(43, 4);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(378, 21);
            this.driverComboBox.TabIndex = 2;
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(43, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(378, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // dirListBox
            // 
            this.dirListBox.FormattingEnabled = true;
            this.dirListBox.Location = new System.Drawing.Point(7, 57);
            this.dirListBox.Name = "dirListBox";
            this.dirListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dirListBox.Size = new System.Drawing.Size(416, 212);
            this.dirListBox.TabIndex = 4;
            this.dirListBox.SelectedIndexChanged += new System.EventHandler(this.dirListBox_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(7, 295);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(88, 295);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(75, 23);
            this.compressButton.TabIndex = 6;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(257, 295);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(348, 295);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(75, 23);
            this.pasteButton.TabIndex = 8;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            // 
            // xxxxx
            // 
            this.xxxxx.AutoSize = true;
            this.xxxxx.Location = new System.Drawing.Point(4, 279);
            this.xxxxx.Name = "xxxxx";
            this.xxxxx.Size = new System.Drawing.Size(69, 13);
            this.xxxxx.TabIndex = 9;
            this.xxxxx.Text = "Space Used:";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(79, 279);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(13, 13);
            this.spaceLabel.TabIndex = 10;
            this.spaceLabel.Text = "0";
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(257, 324);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(75, 23);
            this.cutButton.TabIndex = 11;
            this.cutButton.Text = "Cut";
            this.cutButton.UseVisualStyleBackColor = true;
            // 
            // propertiesButton
            // 
            this.propertiesButton.Location = new System.Drawing.Point(7, 324);
            this.propertiesButton.Name = "propertiesButton";
            this.propertiesButton.Size = new System.Drawing.Size(75, 23);
            this.propertiesButton.TabIndex = 12;
            this.propertiesButton.Text = "Properties";
            this.propertiesButton.UseVisualStyleBackColor = true;
            this.propertiesButton.Click += new System.EventHandler(this.propertiesButton_Click);
            // 
            // explorerPanel
            // 
            this.explorerPanel.Controls.Add(this.decrypt_btn);
            this.explorerPanel.Controls.Add(this.encrypt_btn);
            this.explorerPanel.Controls.Add(this.propertiesPanel);
            this.explorerPanel.Controls.Add(this.driverLabel);
            this.explorerPanel.Controls.Add(this.pathLabel);
            this.explorerPanel.Controls.Add(this.driverComboBox);
            this.explorerPanel.Controls.Add(this.cutButton);
            this.explorerPanel.Controls.Add(this.propertiesButton);
            this.explorerPanel.Controls.Add(this.pasteButton);
            this.explorerPanel.Controls.Add(this.copyButton);
            this.explorerPanel.Controls.Add(this.pathTextBox);
            this.explorerPanel.Controls.Add(this.spaceLabel);
            this.explorerPanel.Controls.Add(this.dirListBox);
            this.explorerPanel.Controls.Add(this.compressButton);
            this.explorerPanel.Controls.Add(this.xxxxx);
            this.explorerPanel.Controls.Add(this.openButton);
            this.explorerPanel.Location = new System.Drawing.Point(12, 12);
            this.explorerPanel.Name = "explorerPanel";
            this.explorerPanel.Size = new System.Drawing.Size(426, 347);
            this.explorerPanel.TabIndex = 13;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.Controls.Add(this.removeReadOnlyButton);
            this.propertiesPanel.Controls.Add(this.readOnlyButton);
            this.propertiesPanel.Controls.Add(this.unHideButton);
            this.propertiesPanel.Controls.Add(this.hideButton);
            this.propertiesPanel.Controls.Add(this.backToExplorerPanel);
            this.propertiesPanel.Location = new System.Drawing.Point(233, 57);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(188, 88);
            this.propertiesPanel.TabIndex = 14;
            // 
            // removeReadOnlyButton
            // 
            this.removeReadOnlyButton.Location = new System.Drawing.Point(84, 32);
            this.removeReadOnlyButton.Name = "removeReadOnlyButton";
            this.removeReadOnlyButton.Size = new System.Drawing.Size(101, 23);
            this.removeReadOnlyButton.TabIndex = 4;
            this.removeReadOnlyButton.Text = "RemoveReadOnly";
            this.removeReadOnlyButton.UseVisualStyleBackColor = true;
            this.removeReadOnlyButton.Click += new System.EventHandler(this.removeReadOnlyButton_Click);
            // 
            // readOnlyButton
            // 
            this.readOnlyButton.Location = new System.Drawing.Point(84, 3);
            this.readOnlyButton.Name = "readOnlyButton";
            this.readOnlyButton.Size = new System.Drawing.Size(101, 23);
            this.readOnlyButton.TabIndex = 3;
            this.readOnlyButton.Text = "SetReadOnly";
            this.readOnlyButton.UseVisualStyleBackColor = true;
            this.readOnlyButton.Click += new System.EventHandler(this.readOnlyButton_Click);
            // 
            // unHideButton
            // 
            this.unHideButton.Location = new System.Drawing.Point(3, 32);
            this.unHideButton.Name = "unHideButton";
            this.unHideButton.Size = new System.Drawing.Size(75, 23);
            this.unHideButton.TabIndex = 2;
            this.unHideButton.Text = "Unhide";
            this.unHideButton.UseVisualStyleBackColor = true;
            this.unHideButton.Click += new System.EventHandler(this.unHideButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(3, 3);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 1;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // backToExplorerPanel
            // 
            this.backToExplorerPanel.Location = new System.Drawing.Point(3, 61);
            this.backToExplorerPanel.Name = "backToExplorerPanel";
            this.backToExplorerPanel.Size = new System.Drawing.Size(182, 23);
            this.backToExplorerPanel.TabIndex = 0;
            this.backToExplorerPanel.Text = "Exit";
            this.backToExplorerPanel.UseVisualStyleBackColor = true;
            this.backToExplorerPanel.Click += new System.EventHandler(this.backToExplorerPanel_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(89, 324);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.encrypt_btn.TabIndex = 15;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(348, 324);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.decrypt_btn.TabIndex = 16;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 400);
            this.Controls.Add(this.explorerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.explorerPanel.ResumeLayout(false);
            this.explorerPanel.PerformLayout();
            this.propertiesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel explorerPanel;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.Button backToExplorerPanel;
        private System.Windows.Forms.Button removeReadOnlyButton;
        private System.Windows.Forms.Button readOnlyButton;
        private System.Windows.Forms.Button unHideButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Button encrypt_btn;
    }
}

