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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_viewby = new System.Windows.Forms.Label();
            this.radbtn_unread = new System.Windows.Forms.RadioButton();
            this.radbtn_read = new System.Windows.Forms.RadioButton();
            this.dgv_viewfeedback = new System.Windows.Forms.DataGridView();
            this.btn_markread = new System.Windows.Forms.Button();
            this.btn_markunread = new System.Windows.Forms.Button();
            this.lbl_select = new System.Windows.Forms.Label();
            this.txtbx_selectedid = new System.Windows.Forms.TextBox();
            this.richtxtbx_displaymsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showmsg = new System.Windows.Forms.Button();
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
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.lbl_viewfeedbacks);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            this.dgv_viewfeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_viewfeedback.Size = new System.Drawing.Size(954, 574);
            this.dgv_viewfeedback.TabIndex = 27;
            // 
            // btn_markread
            // 
            this.btn_markread.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_markread.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_markread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_markread.Location = new System.Drawing.Point(120, 485);
            this.btn_markread.Name = "btn_markread";
            this.btn_markread.Size = new System.Drawing.Size(322, 60);
            this.btn_markread.TabIndex = 28;
            this.btn_markread.Text = "Mark Read";
            this.btn_markread.UseVisualStyleBackColor = false;
            this.btn_markread.Click += new System.EventHandler(this.btn_markread_Click);
            // 
            // btn_markunread
            // 
            this.btn_markunread.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_markunread.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_markunread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_markunread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markunread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_markunread.Location = new System.Drawing.Point(448, 485);
            this.btn_markunread.Name = "btn_markunread";
            this.btn_markunread.Size = new System.Drawing.Size(307, 60);
            this.btn_markunread.TabIndex = 29;
            this.btn_markunread.Text = "Mark Unread";
            this.btn_markunread.UseVisualStyleBackColor = false;
            this.btn_markunread.Click += new System.EventHandler(this.btn_markunread_Click);
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.Location = new System.Drawing.Point(124, 423);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(366, 45);
            this.lbl_select.TabIndex = 30;
            this.lbl_select.Text = "Select feedback_id:";
            // 
            // txtbx_selectedid
            // 
            this.txtbx_selectedid.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_selectedid.Location = new System.Drawing.Point(496, 415);
            this.txtbx_selectedid.Name = "txtbx_selectedid";
            this.txtbx_selectedid.Size = new System.Drawing.Size(100, 53);
            this.txtbx_selectedid.TabIndex = 31;
            // 
            // richtxtbx_displaymsg
            // 
            this.richtxtbx_displaymsg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtbx_displaymsg.Location = new System.Drawing.Point(120, 632);
            this.richtxtbx_displaymsg.Name = "richtxtbx_displaymsg";
            this.richtxtbx_displaymsg.Size = new System.Drawing.Size(635, 221);
            this.richtxtbx_displaymsg.TabIndex = 32;
            this.richtxtbx_displaymsg.Text = "1. Select your feedback_id\n2. Click the show message button \n3. Full message will" +
    " be printed in this text box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(120, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "*Switch radio buttons to refresh the table";
            // 
            // btn_showmsg
            // 
            this.btn_showmsg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_showmsg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_showmsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showmsg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showmsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showmsg.Location = new System.Drawing.Point(120, 551);
            this.btn_showmsg.Name = "btn_showmsg";
            this.btn_showmsg.Size = new System.Drawing.Size(635, 60);
            this.btn_showmsg.TabIndex = 34;
            this.btn_showmsg.Text = "Show message";
            this.btn_showmsg.UseVisualStyleBackColor = false;
            this.btn_showmsg.Click += new System.EventHandler(this.btn_showmsg_Click);
            // 
            // AdminViewCustomerFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_showmsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtbx_displaymsg);
            this.Controls.Add(this.txtbx_selectedid);
            this.Controls.Add(this.lbl_select);
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
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.TextBox txtbx_selectedid;
        private System.Windows.Forms.RichTextBox richtxtbx_displaymsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showmsg;
    }
}
