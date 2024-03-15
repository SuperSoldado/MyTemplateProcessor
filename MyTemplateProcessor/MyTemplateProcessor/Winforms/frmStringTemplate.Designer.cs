namespace WinForms.StringTemplate
{
    partial class frmStringTemplate
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
            txtTemplate = new TextBox();
            btnRun = new Button();
            txtParameters = new TextBox();
            label1 = new Label();
            txtOutput = new TextBox();
            splitContainer1 = new SplitContainer();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTemplate
            // 
            txtTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTemplate.Font = new Font("Courier New", 12F);
            txtTemplate.Location = new Point(3, 25);
            txtTemplate.Multiline = true;
            txtTemplate.Name = "txtTemplate";
            txtTemplate.ScrollBars = ScrollBars.Both;
            txtTemplate.Size = new Size(741, 294);
            txtTemplate.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(9, 14);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtParameters
            // 
            txtParameters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtParameters.Font = new Font("Courier New", 12F);
            txtParameters.Location = new Point(3, 25);
            txtParameters.Multiline = true;
            txtParameters.Name = "txtParameters";
            txtParameters.ScrollBars = ScrollBars.Both;
            txtParameters.Size = new Size(252, 291);
            txtParameters.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Template";
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Font = new Font("Courier New", 15.75F);
            txtOutput.Location = new Point(9, 43);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(1012, 275);
            txtOutput.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(6, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(txtTemplate);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(txtParameters);
            splitContainer1.Size = new Size(1015, 319);
            splitContainer1.SplitterDistance = 747;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(158, 4);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(426, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://cottle.readthedocs.io/en/stable/page/01-overview.html#getting-started";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Parameters";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(1, 4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtOutput);
            splitContainer2.Panel2.Controls.Add(btnRun);
            splitContainer2.Size = new Size(1028, 650);
            splitContainer2.SplitterDistance = 325;
            splitContainer2.TabIndex = 6;
            // 
            // frmStringTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 655);
            Controls.Add(splitContainer2);
            Name = "frmStringTemplate";
            Text = "frmStringTemplate";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTemplate;
        private Button btnRun;
        private TextBox txtParameters;
        private Label label1;
        private TextBox txtOutput;
        private SplitContainer splitContainer1;
        private Label label2;
        private LinkLabel linkLabel1;
        private SplitContainer splitContainer2;
    }
}