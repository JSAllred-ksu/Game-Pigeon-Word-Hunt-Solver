namespace Ksu.Cis300.Boggle
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
            this.uxRow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxRow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxRow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxRow4 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxMenuBar.SuspendLayout();
            this.uxBoard.SuspendLayout();
            this.uxRow0.SuspendLayout();
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
            this.uxWordsFound.Margin = new System.Windows.Forms.Padding(4);
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
            this.uxBoard.Margin = new System.Windows.Forms.Padding(4);
            this.uxBoard.Name = "uxBoard";
            this.uxBoard.Size = new System.Drawing.Size(545, 503);
            this.uxBoard.TabIndex = 27;
            // 
            // uxRow0
            // 
            this.uxRow0.Controls.Add(this.uxRow1);
            this.uxRow0.Location = new System.Drawing.Point(0, 0);
            this.uxRow0.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow0.Name = "uxRow0";
            this.uxRow0.Size = new System.Drawing.Size(544, 126);
            this.uxRow0.TabIndex = 0;
            // 
            // uxRow1
            // 
            this.uxRow1.Location = new System.Drawing.Point(0, 0);
            this.uxRow1.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow1.Name = "uxRow1";
            this.uxRow1.Size = new System.Drawing.Size(680, 126);
            this.uxRow1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(544, 126);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // uxRow2
            // 
            this.uxRow2.Location = new System.Drawing.Point(0, 252);
            this.uxRow2.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow2.Name = "uxRow2";
            this.uxRow2.Size = new System.Drawing.Size(544, 126);
            this.uxRow2.TabIndex = 7;
            // 
            // uxRow3
            // 
            this.uxRow3.Controls.Add(this.uxRow4);
            this.uxRow3.Location = new System.Drawing.Point(0, 378);
            this.uxRow3.Margin = new System.Windows.Forms.Padding(0);
            this.uxRow3.Name = "uxRow3";
            this.uxRow3.Size = new System.Drawing.Size(544, 126);
            this.uxRow3.TabIndex = 8;
            // 
            // uxRow4
            // 
            this.uxRow4.Location = new System.Drawing.Point(0, 0);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInterface";
            this.Text = "Game Pigeon: Word Hunt Solver";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.uxBoard.ResumeLayout(false);
            this.uxRow0.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel uxRow1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel uxRow2;
        private System.Windows.Forms.FlowLayoutPanel uxRow3;
        private System.Windows.Forms.FlowLayoutPanel uxRow4;
    }
}

