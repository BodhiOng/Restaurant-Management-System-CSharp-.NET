namespace IOOP_Assignment
{
    partial class AdminViewCustomerFeedbacks
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
            this.lbl_viewfeedbacks = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lbl_viewby = new System.Windows.Forms.Label();
            this.radbtn_unread = new System.Windows.Forms.RadioButton();
            this.radbtn_read = new System.Windows.Forms.RadioButton();
            this.dgv_viewfeedback = new System.Windows.Forms.DataGridView();
            this.btn_markread = new System.Windows.Forms.Button();
            this.btn_markunread = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewfeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_viewfeedbacks
            // 
            this.lbl_viewfeedbacks.AutoSize = true;
            this.lbl_viewfeedbacks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewfeedbacks.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewfeedbacks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewfeedbacks.Location = new System.Drawing.Point(387, 59);
            this.lbl_viewfeedbacks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewfeedbacks.Name = "lbl_viewfeedbacks";
            this.lbl_viewfeedbacks.Size = new System.Drawing.Size(1127, 93);
            this.lbl_viewfeedbacks.TabIndex = 0;
            this.lbl_viewfeedbacks.Text = "View feedback by customers";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_viewfeedbacks);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 22;
            // 
            // lbl_viewby
            // 
            this.lbl_viewby.AutoSize = true;
            this.lbl_viewby.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewby.Location = new System.Drawing.Point(118, 299);
            this.lbl_viewby.Name = "lbl_viewby";
            this.lbl_viewby.Size = new System.Drawing.Size(168, 45);
            this.lbl_viewby.TabIndex = 23;
            this.lbl_viewby.Text = "View by:";
            // 
            // radbtn_unread
            // 
            this.radbtn_unread.AutoSize = true;
            this.radbtn_unread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_unread.Location = new System.Drawing.Point(301, 299);
            this.radbtn_unread.Name = "radbtn_unread";
            this.radbtn_unread.Size = new System.Drawing.Size(383, 36);
            this.radbtn_unread.TabIndex = 24;
            this.radbtn_unread.TabStop = true;
            this.radbtn_unread.Text = "Feedbacks marked \'Unread\'\r\n";
            this.radbtn_unread.UseVisualStyleBackColor = true;
            this.radbtn_unread.CheckedChanged += new System.EventHandler(this.radbtn_unread_CheckedChanged);
            // 
            // radbtn_read
            // 
            this.radbtn_read.AutoSize = true;
            this.radbtn_read.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_read.Location = new System.Drawing.Point(301, 341);
            this.radbtn_read.Name = "radbtn_read";
            this.radbtn_read.Size = new System.Drawing.Size(360, 36);
            this.radbtn_read.TabIndex = 25;
            this.radbtn_read.TabStop = true;
            this.radbtn_read.Text = "Feedbacks marked \'Read\'\r\n";
            this.radbtn_read.UseVisualStyleBackColor = true;
            this.radbtn_read.CheckedChanged += new System.EventHandler(this.radbtn_read_CheckedChanged);
            // 
            // dgv_viewfeedback
            // 
            this.dgv_viewfeedback.AllowUserToAddRows = false;
            this.dgv_viewfeedback.AllowUserToDeleteRows = false;
            this.dgv_viewfeedback.AllowUserToOrderColumns = true;
            this.dgv_viewfeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_viewfeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewfeedback.Location = new System.Drawing.Point(833, 279);
            this.dgv_viewfeedback.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_viewfeedback.Name = "dgv_viewfeedback";
            this.dgv_viewfeedback.ReadOnly = true;
            this.dgv_viewfeedback.RowHeadersWidth = 82;
            this.dgv_viewfeedback.RowTemplate.Height = 33;
            this.dgv_viewfeedback.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_viewfeedback.Size = new System.Drawing.Size(954, 574);
            this.dgv_viewfeedback.TabIndex = 27;
            this.dgv_viewfeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_viewfeedback_CellContentClick);
            // 
            // btn_markread
            // 
            this.btn_markread.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_markread.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_markread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_markread.Location = new System.Drawing.Point(126, 413);
            this.btn_markread.Name = "btn_markread";
            this.btn_markread.Size = new System.Drawing.Size(250, 60);
            this.btn_markread.TabIndex = 28;
            this.btn_markread.Text = "Mark Read";
            this.btn_markread.UseVisualStyleBackColor = false;
            // 
            // btn_markunread
            // 
            this.btn_markunread.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_markunread.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_markunread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markunread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markunread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_markunread.Location = new System.Drawing.Point(392, 413);
            this.btn_markunread.Name = "btn_markunread";
            this.btn_markunread.Size = new System.Drawing.Size(250, 60);
            this.btn_markunread.TabIndex = 29;
            this.btn_markunread.Text = "Mark Unread";
            this.btn_markunread.UseVisualStyleBackColor = false;
            // 
            // AdminViewCustomerFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_markunread);
            this.Controls.Add(this.btn_markread);
            this.Controls.Add(this.dgv_viewfeedback);
            this.Controls.Add(this.radbtn_read);
            this.Controls.Add(this.radbtn_unread);
            this.Controls.Add(this.lbl_viewby);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AdminViewCustomerFeedbacks";
            this.Size = new System.Drawing.Size(1900, 913);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewfeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_viewfeedbacks;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_viewby;
        private System.Windows.Forms.RadioButton radbtn_unread;
        private System.Windows.Forms.RadioButton radbtn_read;
        private System.Windows.Forms.DataGridView dgv_viewfeedback;
        private System.Windows.Forms.Button btn_markread;
        private System.Windows.Forms.Button btn_markunread;
    }
}
