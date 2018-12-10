namespace CreatePPT
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
            this.button1 = new System.Windows.Forms.Button();
            this.fbDDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.selectSource = new System.Windows.Forms.Button();
            this.txtSourceImages = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextFrame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(490, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 415);
            this.button1.TabIndex = 0;
            this.button1.Text = "CreatePPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the Folder of Source Images";
            // 
            // selectSource
            // 
            this.selectSource.BackColor = System.Drawing.SystemColors.ControlDark;
            this.selectSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSource.Location = new System.Drawing.Point(298, 90);
            this.selectSource.Name = "selectSource";
            this.selectSource.Size = new System.Drawing.Size(131, 25);
            this.selectSource.TabIndex = 3;
            this.selectSource.Text = "Select Folder";
            this.selectSource.UseVisualStyleBackColor = false;
            this.selectSource.Click += new System.EventHandler(this.selectSource_Click);
            // 
            // txtSourceImages
            // 
            this.txtSourceImages.Location = new System.Drawing.Point(19, 93);
            this.txtSourceImages.Name = "txtSourceImages";
            this.txtSourceImages.Size = new System.Drawing.Size(269, 22);
            this.txtSourceImages.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 244);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Add Title in the Slide";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(19, 278);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(251, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please select the Folder of Target Presentation";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(16, 184);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(274, 22);
            this.txtTarget.TabIndex = 8;
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarget.Location = new System.Drawing.Point(298, 182);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(131, 25);
            this.btnTarget.TabIndex = 9;
            this.btnTarget.Text = "Select Target";
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Give Filename which needs to be saved";
            // 
            // txtfileName
            // 
            this.txtfileName.Location = new System.Drawing.Point(16, 374);
            this.txtfileName.Name = "txtfileName";
            this.txtfileName.Size = new System.Drawing.Size(255, 22);
            this.txtfileName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TextFrame Text";
            // 
            // txtTextFrame
            // 
            this.txtTextFrame.Location = new System.Drawing.Point(16, 450);
            this.txtTextFrame.Name = "txtTextFrame";
            this.txtTextFrame.Size = new System.Drawing.Size(254, 22);
            this.txtTextFrame.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 485);
            this.Controls.Add(this.txtTextFrame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSourceImages);
            this.Controls.Add(this.selectSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPT Designer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog fbDDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectSource;
        private System.Windows.Forms.TextBox txtSourceImages;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextFrame;
    }
}

