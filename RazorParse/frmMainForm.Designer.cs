namespace RazorParse
{
    partial class frmMainForm
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
            this.rtbSourceRazor = new System.Windows.Forms.RichTextBox();
            this.rtbParseResult = new System.Windows.Forms.RichTextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSourceRazor
            // 
            this.rtbSourceRazor.Location = new System.Drawing.Point(12, 12);
            this.rtbSourceRazor.Name = "rtbSourceRazor";
            this.rtbSourceRazor.Size = new System.Drawing.Size(346, 514);
            this.rtbSourceRazor.TabIndex = 0;
            this.rtbSourceRazor.Text = "";
            // 
            // rtbParseResult
            // 
            this.rtbParseResult.Location = new System.Drawing.Point(476, 12);
            this.rtbParseResult.Name = "rtbParseResult";
            this.rtbParseResult.Size = new System.Drawing.Size(346, 514);
            this.rtbParseResult.TabIndex = 1;
            this.rtbParseResult.Text = "";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(380, 12);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 589);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.rtbParseResult);
            this.Controls.Add(this.rtbSourceRazor);
            this.Name = "frmMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourceRazor;
        private System.Windows.Forms.RichTextBox rtbParseResult;
        private System.Windows.Forms.Button btnParse;
    }
}

