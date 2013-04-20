﻿namespace Skyrim.Game.Config
{
    partial class Play
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
            System.Windows.Forms.ColumnHeader populationHeader;
            System.Windows.Forms.ColumnHeader maximumHeader;
            this.disableButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.selectedServerKey = new System.Windows.Forms.Label();
            populationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            maximumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // populationHeader
            // 
            populationHeader.Tag = "populationHeader";
            populationHeader.Text = "Population";
            populationHeader.Width = 78;
            // 
            // maximumHeader
            // 
            maximumHeader.Tag = "maximumHeader";
            maximumHeader.Text = "Maximum";
            maximumHeader.Width = 66;
            // 
            // disableButton
            // 
            this.disableButton.Location = new System.Drawing.Point(359, 296);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(147, 23);
            this.disableButton.TabIndex = 0;
            this.disableButton.Text = "Single player";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(359, 325);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(147, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Join server";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // serverList
            // 
            this.serverList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.serverList.AutoArrange = false;
            this.serverList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            populationHeader,
            maximumHeader});
            this.serverList.FullRowSelect = true;
            this.serverList.GridLines = true;
            this.serverList.Location = new System.Drawing.Point(12, 40);
            this.serverList.MultiSelect = false;
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(341, 308);
            this.serverList.TabIndex = 2;
            this.serverList.UseCompatibleStateImageBehavior = false;
            this.serverList.View = System.Windows.Forms.View.Details;
            this.serverList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.serverList_ColumnClick);
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.Tag = "nameHeader";
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 193;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server list :";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(359, 56);
            this.playerNameBox.MaxLength = 100;
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(147, 20);
            this.playerNameBox.TabIndex = 4;
            this.playerNameBox.TextChanged += new System.EventHandler(this.playerNameBox_TextChanged);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(360, 40);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(100, 13);
            this.playerNameLabel.TabIndex = 5;
            this.playerNameLabel.Text = "Input Player Name :";
            // 
            // selectedServerKey
            // 
            this.selectedServerKey.AutoSize = true;
            this.selectedServerKey.Location = new System.Drawing.Point(79, 12);
            this.selectedServerKey.Name = "selectedServerKey";
            this.selectedServerKey.Size = new System.Drawing.Size(0, 13);
            this.selectedServerKey.TabIndex = 6;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 360);
            this.ControlBox = false;
            this.Controls.Add(this.selectedServerKey);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.disableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(534, 398);
            this.MinimumSize = new System.Drawing.Size(534, 398);
            this.Name = "Play";
            this.Text = "Skyrim Online - Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ListView serverList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label selectedServerKey;
    }
}