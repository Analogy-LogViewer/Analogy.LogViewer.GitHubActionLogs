namespace Analogy.LogViewer.GitHubActionLogs
{
    partial class SettingsForm
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
            this.listboxLogLevel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listTextsForLogLevel = new System.Windows.Forms.ListBox();
            this.textForLog = new System.Windows.Forms.TextBox();
            this.lblCurrentLogLevel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSelectedText = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxLogLevel
            // 
            this.listboxLogLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxLogLevel.FormattingEnabled = true;
            this.listboxLogLevel.ItemHeight = 16;
            this.listboxLogLevel.Location = new System.Drawing.Point(0, 17);
            this.listboxLogLevel.Name = "listboxLogLevel";
            this.listboxLogLevel.Size = new System.Drawing.Size(230, 433);
            this.listboxLogLevel.TabIndex = 0;
            this.listboxLogLevel.SelectedIndexChanged += new System.EventHandler(this.listboxLogLevel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log Levels:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listboxLogLevel);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSelection);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.lblSelectedText);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentLogLevel);
            this.splitContainer1.Panel2.Controls.Add(this.textForLog);
            this.splitContainer1.Panel2.Controls.Add(this.listTextsForLogLevel);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 450);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // listTextsForLogLevel
            // 
            this.listTextsForLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTextsForLogLevel.FormattingEnabled = true;
            this.listTextsForLogLevel.ItemHeight = 16;
            this.listTextsForLogLevel.Location = new System.Drawing.Point(2, 36);
            this.listTextsForLogLevel.Name = "listTextsForLogLevel";
            this.listTextsForLogLevel.Size = new System.Drawing.Size(921, 372);
            this.listTextsForLogLevel.TabIndex = 0;
            this.listTextsForLogLevel.SelectedIndexChanged += new System.EventHandler(this.listTextsForLogLevel_SelectedIndexChanged);
            // 
            // textForLog
            // 
            this.textForLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textForLog.Location = new System.Drawing.Point(264, 8);
            this.textForLog.Name = "textForLog";
            this.textForLog.Size = new System.Drawing.Size(578, 22);
            this.textForLog.TabIndex = 1;
            // 
            // lblCurrentLogLevel
            // 
            this.lblCurrentLogLevel.AutoSize = true;
            this.lblCurrentLogLevel.Location = new System.Drawing.Point(3, 11);
            this.lblCurrentLogLevel.Name = "lblCurrentLogLevel";
            this.lblCurrentLogLevel.Size = new System.Drawing.Size(170, 17);
            this.lblCurrentLogLevel.TabIndex = 2;
            this.lblCurrentLogLevel.Text = "Add new Text for log level";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(848, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSelectedText
            // 
            this.lblSelectedText.Location = new System.Drawing.Point(150, 411);
            this.lblSelectedText.Name = "lblSelectedText";
            this.lblSelectedText.Size = new System.Drawing.Size(692, 31);
            this.lblSelectedText.TabIndex = 4;
            this.lblSelectedText.Text = "N/A";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(848, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.Location = new System.Drawing.Point(3, 411);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(119, 31);
            this.lblSelection.TabIndex = 6;
            this.lblSelection.Text = "Selection:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxLogLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listTextsForLogLevel;
        private System.Windows.Forms.Label lblCurrentLogLevel;
        private System.Windows.Forms.TextBox textForLog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSelectedText;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelection;
    }
}

