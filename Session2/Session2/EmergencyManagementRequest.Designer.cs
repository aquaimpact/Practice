namespace Session2
{
    partial class EmergencyManagementRequest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.RichTextBox();
            this.other = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SendReq = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dept);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.other);
            this.groupBox2.Controls.Add(this.Desc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Report:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset SN:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(327, 46);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(46, 17);
            this.Name.TabIndex = 1;
            this.Name.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asset Name:";
            // 
            // SN
            // 
            this.SN.AutoSize = true;
            this.SN.Location = new System.Drawing.Point(111, 46);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(46, 17);
            this.SN.TabIndex = 3;
            this.SN.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(588, 46);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(46, 17);
            this.dept.TabIndex = 5;
            this.dept.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Other Considerations:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description of Emergency:";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(19, 109);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(723, 51);
            this.Desc.TabIndex = 9;
            this.Desc.Text = "";
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(19, 192);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(723, 51);
            this.other.TabIndex = 10;
            this.other.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // SendReq
            // 
            this.SendReq.Location = new System.Drawing.Point(126, 440);
            this.SendReq.Name = "SendReq";
            this.SendReq.Size = new System.Drawing.Size(125, 36);
            this.SendReq.TabIndex = 2;
            this.SendReq.Text = "Send Request";
            this.SendReq.UseVisualStyleBackColor = true;
            this.SendReq.Click += new System.EventHandler(this.SendReq_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(389, 440);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 36);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EmergencyManagementRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SendReq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            //this.Name = "EmergencyManagementRequest";
            this.Text = "EmergencyManagementRequest";
            this.Load += new System.EventHandler(this.EmergencyManagementRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox other;
        private System.Windows.Forms.RichTextBox Desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendReq;
        private System.Windows.Forms.Button Cancel;
    }
}