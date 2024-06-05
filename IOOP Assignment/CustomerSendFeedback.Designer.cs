namespace IOOP_Assignment
{
    partial class CustomerSendFeedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGreetings = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblSendFeedback = new System.Windows.Forms.Label();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(57, 209);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(1190, 55);
            this.lblGreetings.TabIndex = 33;
            this.lblGreetings.Text = "Good day customer, we hope thou grant us a feedback\r\n";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblSendFeedback);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 165);
            this.panel_header.TabIndex = 31;
            // 
            // lblSendFeedback
            // 
            this.lblSendFeedback.AutoSize = true;
            this.lblSendFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblSendFeedback.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSendFeedback.Location = new System.Drawing.Point(660, 39);
            this.lblSendFeedback.Name = "lblSendFeedback";
            this.lblSendFeedback.Size = new System.Drawing.Size(624, 93);
            this.lblSendFeedback.TabIndex = 0;
            this.lblSendFeedback.Text = "Send Feedback";
            this.lblSendFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSendFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSendFeedback.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.Transparent;
            this.btnSendFeedback.Location = new System.Drawing.Point(1380, 799);
            this.btnSendFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(434, 92);
            this.btnSendFeedback.TabIndex = 34;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbFeedback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFeedback.Location = new System.Drawing.Point(67, 291);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(1747, 485);
            this.rtbFeedback.TabIndex = 32;
            this.rtbFeedback.Text = "";
            // 
            // CustomerSendFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.rtbFeedback);
            this.Name = "CustomerSendFeedback";
            this.Size = new System.Drawing.Size(1900, 913);
            this.Load += new System.EventHandler(this.CustomerSendFeedback_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblSendFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.RichTextBox rtbFeedback;
    }
}
