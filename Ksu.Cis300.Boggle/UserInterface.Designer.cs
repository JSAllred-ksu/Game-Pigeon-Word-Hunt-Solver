﻿namespace Ksu.Cis300.Boggle
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxWordsFound = new System.Windows.Forms.ListBox();
            this.uxWordsFoundLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxMenuBar = new System.Windows.Forms.ToolStrip();
            this.uxNewBoard = new System.Windows.Forms.ToolStripButton();
            this.uxFindWords = new System.Windows.Forms.ToolStripButton();
            this.uxBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.uxRow0 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxDie01 = new System.Windows.Forms.Button();
            this.uxDie02 = new System.Windows.Forms.Button();
            this.uxDie03 = new System.Windows.Forms.Button();
            this.uxRow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxDie10 = new System.Windows.Forms.Button();
            this.uxDie11 = new System.Windows.Forms.Button();
            this.uxDie12 = new System.Windows.Forms.Button();
            this.uxDie13 = new System.Windows.Forms.Button();
            this.uxRow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxDie20 = new System.Windows.Forms.Button();
            this.uxDie21 = new System.Windows.Forms.Button();
            this.uxDie22 = new System.Windows.Forms.Button();
            this.uxDie23 = new System.Windows.Forms.Button();
            this.uxRow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxDie30 = new System.Windows.Forms.Button();
            this.uxDie31 = new System.Windows.Forms.Button();
            this.uxDie32 = new System.Windows.Forms.Button();
            this.uxDie33 = new System.Windows.Forms.Button();
            this.uxRow4 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxMenuBar.SuspendLayout();
            this.uxBoard.SuspendLayout();
            this.uxRow0.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.uxRow2.SuspendLayout();
            this.uxRow3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxWordsFound
            // 
            this.uxWordsFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWordsFound.FormattingEnabled = true;
            this.uxWordsFound.ItemHeight = 29;
            this.uxWordsFound.Location = new System.Drawing.Point(597, 58);
            this.uxWordsFound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxWordsFound.Name = "uxWordsFound";
            this.uxWordsFound.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxWordsFound.Size = new System.Drawing.Size(296, 439);
            this.uxWordsFound.TabIndex = 25;
            // 
            // uxWordsFoundLabel
            // 
            this.uxWordsFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWordsFoundLabel.AutoSize = true;
            this.uxWordsFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWordsFoundLabel.Location = new System.Drawing.Point(591, 26);
            this.uxWordsFoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxWordsFoundLabel.Name = "uxWordsFoundLabel";
            this.uxWordsFoundLabel.Size = new System.Drawing.Size(164, 29);
            this.uxWordsFoundLabel.TabIndex = 24;
            this.uxWordsFoundLabel.Text = "Words Found:";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Title = "Select Word List File";
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNewBoard,
            this.uxFindWords});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.uxMenuBar.Size = new System.Drawing.Size(904, 27);
            this.uxMenuBar.TabIndex = 26;
            this.uxMenuBar.Text = "toolStrip1";
            // 
            // uxNewBoard
            // 
            this.uxNewBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxNewBoard.Image = ((System.Drawing.Image)(resources.GetObject("uxNewBoard.Image")));
            this.uxNewBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxNewBoard.Name = "uxNewBoard";
            this.uxNewBoard.Size = new System.Drawing.Size(47, 24);
            this.uxNewBoard.Text = "Clear";
            this.uxNewBoard.Click += new System.EventHandler(this.uxNewBoard_Click);
            // 
            // uxFindWords
            // 
            this.uxFindWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxFindWords.Image = ((System.Drawing.Image)(resources.GetObject("uxFindWords.Image")));
            this.uxFindWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxFindWords.Name = "uxFindWords";
            this.uxFindWords.Size = new System.Drawing.Size(87, 24);
            this.uxFindWords.Text = "Find Words";
            this.uxFindWords.Click += new System.EventHandler(this.uxFindWords_Click);
            // 
            // uxBoard
            // 
            this.uxBoard.Controls.Add(this.uxRow0);
            this.uxBoard.Controls.Add(this.flowLayoutPanel2);
            this.uxBoard.Controls.Add(this.uxRow2);
            this.uxBoard.Controls.Add(this.uxRow3);
            this.uxBoard.Location = new System.Drawing.Point(16, 34);
            this.uxBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxBoard.Name = "uxBoard";
            this.uxBoard.Size = new System.Drawing.Size(545, 503);
            this.uxBoard.TabIndex = 27;
            // 
            // uxRow0
            // 
            this.uxRow0.Controls.Add(this.uxDie01);
            this.uxRow0.Controls.Add(this.uxDie02);
            this.uxRow0.Controls.Add(this.uxDie03);
            this.uxRow0.Controls.Add(this.uxRow1);
            this.uxRow0.Location = new System.Drawing.Point(0, 0);
            this.uxRow0.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow0.Name = "uxRow0";
            this.uxRow0.Size = new System.Drawing.Size(544, 126);
            this.uxRow0.TabIndex = 0;
            // 
            // uxDie01
            // 
            this.uxDie01.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie01.Location = new System.Drawing.Point(0, 0);
            this.uxDie01.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie01.Name = "uxDie01";
            this.uxDie01.Size = new System.Drawing.Size(136, 126);
            this.uxDie01.TabIndex = 1;
            this.uxDie01.UseVisualStyleBackColor = true;
            // 
            // uxDie02
            // 
            this.uxDie02.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie02.Location = new System.Drawing.Point(136, 0);
            this.uxDie02.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie02.Name = "uxDie02";
            this.uxDie02.Size = new System.Drawing.Size(136, 126);
            this.uxDie02.TabIndex = 2;
            this.uxDie02.UseVisualStyleBackColor = true;
            // 
            // uxDie03
            // 
            this.uxDie03.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie03.Location = new System.Drawing.Point(272, 0);
            this.uxDie03.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie03.Name = "uxDie03";
            this.uxDie03.Size = new System.Drawing.Size(136, 126);
            this.uxDie03.TabIndex = 3;
            this.uxDie03.UseVisualStyleBackColor = true;
            // 
            // uxRow1
            // 
            this.uxRow1.Location = new System.Drawing.Point(0, 126);
            this.uxRow1.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow1.Name = "uxRow1";
            this.uxRow1.Size = new System.Drawing.Size(680, 126);
            this.uxRow1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.uxDie10);
            this.flowLayoutPanel2.Controls.Add(this.uxDie11);
            this.flowLayoutPanel2.Controls.Add(this.uxDie12);
            this.flowLayoutPanel2.Controls.Add(this.uxDie13);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(544, 126);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // uxDie10
            // 
            this.uxDie10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie10.Location = new System.Drawing.Point(0, 0);
            this.uxDie10.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie10.Name = "uxDie10";
            this.uxDie10.Size = new System.Drawing.Size(136, 126);
            this.uxDie10.TabIndex = 1;
            this.uxDie10.UseVisualStyleBackColor = true;
            // 
            // uxDie11
            // 
            this.uxDie11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie11.Location = new System.Drawing.Point(136, 0);
            this.uxDie11.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie11.Name = "uxDie11";
            this.uxDie11.Size = new System.Drawing.Size(136, 126);
            this.uxDie11.TabIndex = 2;
            this.uxDie11.UseVisualStyleBackColor = true;
            // 
            // uxDie12
            // 
            this.uxDie12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie12.Location = new System.Drawing.Point(272, 0);
            this.uxDie12.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie12.Name = "uxDie12";
            this.uxDie12.Size = new System.Drawing.Size(136, 126);
            this.uxDie12.TabIndex = 3;
            this.uxDie12.UseVisualStyleBackColor = true;
            // 
            // uxDie13
            // 
            this.uxDie13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie13.Location = new System.Drawing.Point(408, 0);
            this.uxDie13.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie13.Name = "uxDie13";
            this.uxDie13.Size = new System.Drawing.Size(136, 126);
            this.uxDie13.TabIndex = 4;
            this.uxDie13.UseVisualStyleBackColor = true;
            // 
            // uxRow2
            // 
            this.uxRow2.Controls.Add(this.uxDie20);
            this.uxRow2.Controls.Add(this.uxDie21);
            this.uxRow2.Controls.Add(this.uxDie22);
            this.uxRow2.Controls.Add(this.uxDie23);
            this.uxRow2.Location = new System.Drawing.Point(0, 252);
            this.uxRow2.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow2.Name = "uxRow2";
            this.uxRow2.Size = new System.Drawing.Size(544, 126);
            this.uxRow2.TabIndex = 7;
            // 
            // uxDie20
            // 
            this.uxDie20.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie20.Location = new System.Drawing.Point(0, 0);
            this.uxDie20.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie20.Name = "uxDie20";
            this.uxDie20.Size = new System.Drawing.Size(136, 126);
            this.uxDie20.TabIndex = 2;
            this.uxDie20.UseVisualStyleBackColor = true;
            // 
            // uxDie21
            // 
            this.uxDie21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie21.Location = new System.Drawing.Point(136, 0);
            this.uxDie21.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie21.Name = "uxDie21";
            this.uxDie21.Size = new System.Drawing.Size(136, 126);
            this.uxDie21.TabIndex = 3;
            this.uxDie21.UseVisualStyleBackColor = true;
            // 
            // uxDie22
            // 
            this.uxDie22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie22.Location = new System.Drawing.Point(272, 0);
            this.uxDie22.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie22.Name = "uxDie22";
            this.uxDie22.Size = new System.Drawing.Size(136, 126);
            this.uxDie22.TabIndex = 4;
            this.uxDie22.UseVisualStyleBackColor = true;
            // 
            // uxDie23
            // 
            this.uxDie23.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie23.Location = new System.Drawing.Point(408, 0);
            this.uxDie23.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie23.Name = "uxDie23";
            this.uxDie23.Size = new System.Drawing.Size(136, 126);
            this.uxDie23.TabIndex = 5;
            this.uxDie23.UseVisualStyleBackColor = true;
            // 
            // uxRow3
            // 
            this.uxRow3.Controls.Add(this.uxDie30);
            this.uxRow3.Controls.Add(this.uxDie31);
            this.uxRow3.Controls.Add(this.uxDie32);
            this.uxRow3.Controls.Add(this.uxDie33);
            this.uxRow3.Controls.Add(this.uxRow4);
            this.uxRow3.Location = new System.Drawing.Point(0, 378);
            this.uxRow3.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow3.Name = "uxRow3";
            this.uxRow3.Size = new System.Drawing.Size(544, 126);
            this.uxRow3.TabIndex = 8;
            // 
            // uxDie30
            // 
            this.uxDie30.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie30.Location = new System.Drawing.Point(0, 0);
            this.uxDie30.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie30.Name = "uxDie30";
            this.uxDie30.Size = new System.Drawing.Size(136, 126);
            this.uxDie30.TabIndex = 0;
            this.uxDie30.UseVisualStyleBackColor = true;
            // 
            // uxDie31
            // 
            this.uxDie31.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie31.Location = new System.Drawing.Point(136, 0);
            this.uxDie31.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie31.Name = "uxDie31";
            this.uxDie31.Size = new System.Drawing.Size(136, 126);
            this.uxDie31.TabIndex = 1;
            this.uxDie31.UseVisualStyleBackColor = true;
            // 
            // uxDie32
            // 
            this.uxDie32.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie32.Location = new System.Drawing.Point(272, 0);
            this.uxDie32.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie32.Name = "uxDie32";
            this.uxDie32.Size = new System.Drawing.Size(136, 126);
            this.uxDie32.TabIndex = 2;
            this.uxDie32.UseVisualStyleBackColor = true;
            // 
            // uxDie33
            // 
            this.uxDie33.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDie33.Location = new System.Drawing.Point(408, 0);
            this.uxDie33.Margin = new System.Windows.Forms.Padding(0);
            this.uxDie33.Name = "uxDie33";
            this.uxDie33.Size = new System.Drawing.Size(136, 126);
            this.uxDie33.TabIndex = 3;
            this.uxDie33.UseVisualStyleBackColor = true;
            // 
            // uxRow4
            // 
            this.uxRow4.Location = new System.Drawing.Point(0, 126);
            this.uxRow4.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow4.Name = "uxRow4";
            this.uxRow4.Size = new System.Drawing.Size(680, 126);
            this.uxRow4.TabIndex = 5;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(904, 554);
            this.Controls.Add(this.uxBoard);
            this.Controls.Add(this.uxWordsFound);
            this.Controls.Add(this.uxWordsFoundLabel);
            this.Controls.Add(this.uxMenuBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInterface";
            this.Text = "Word Hunt Solver";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.uxBoard.ResumeLayout(false);
            this.uxRow0.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.uxRow2.ResumeLayout(false);
            this.uxRow3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox uxWordsFound;
        private System.Windows.Forms.Label uxWordsFoundLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.ToolStrip uxMenuBar;
        private System.Windows.Forms.ToolStripButton uxNewBoard;
        private System.Windows.Forms.ToolStripButton uxFindWords;
        private System.Windows.Forms.FlowLayoutPanel uxBoard;
        private System.Windows.Forms.FlowLayoutPanel uxRow0;
        private System.Windows.Forms.Button uxDie01;
        private System.Windows.Forms.Button uxDie02;
        private System.Windows.Forms.Button uxDie03;
        private System.Windows.Forms.FlowLayoutPanel uxRow1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button uxDie10;
        private System.Windows.Forms.Button uxDie11;
        private System.Windows.Forms.Button uxDie12;
        private System.Windows.Forms.Button uxDie13;
        private System.Windows.Forms.FlowLayoutPanel uxRow2;
        private System.Windows.Forms.Button uxDie20;
        private System.Windows.Forms.Button uxDie21;
        private System.Windows.Forms.Button uxDie22;
        private System.Windows.Forms.Button uxDie23;
        private System.Windows.Forms.FlowLayoutPanel uxRow3;
        private System.Windows.Forms.Button uxDie30;
        private System.Windows.Forms.Button uxDie31;
        private System.Windows.Forms.Button uxDie32;
        private System.Windows.Forms.Button uxDie33;
        private System.Windows.Forms.FlowLayoutPanel uxRow4;
    }
}

