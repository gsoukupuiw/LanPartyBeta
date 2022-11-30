namespace LanPartyBeta
{
    partial class Form1
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
            this.msgOut = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFriend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRmName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.txtFriendName = new System.Windows.Forms.TextBox();
            this.txtFriendIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgOut
            // 
            this.msgOut.Location = new System.Drawing.Point(6, 360);
            this.msgOut.Name = "msgOut";
            this.msgOut.Size = new System.Drawing.Size(665, 27);
            this.msgOut.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(682, 358);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(773, 329);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 445);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.msgOut);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friends";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveFriend);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRmName);
            this.groupBox2.Location = new System.Drawing.Point(334, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 89);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Friend";
            // 
            // btnRemoveFriend
            // 
            this.btnRemoveFriend.Location = new System.Drawing.Point(311, 46);
            this.btnRemoveFriend.Name = "btnRemoveFriend";
            this.btnRemoveFriend.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveFriend.TabIndex = 9;
            this.btnRemoveFriend.Text = "Remove";
            this.btnRemoveFriend.UseVisualStyleBackColor = true;
            this.btnRemoveFriend.Click += new System.EventHandler(this.btnRemoveFriend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nick Name";
            // 
            // txtRmName
            // 
            this.txtRmName.Location = new System.Drawing.Point(151, 46);
            this.txtRmName.Name = "txtRmName";
            this.txtRmName.Size = new System.Drawing.Size(125, 27);
            this.txtRmName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddFriend);
            this.groupBox1.Controls.Add(this.txtFriendName);
            this.groupBox1.Controls.Add(this.txtFriendIp);
            this.groupBox1.Location = new System.Drawing.Point(334, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Friend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nick Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(311, 45);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(94, 29);
            this.btnAddFriend.TabIndex = 2;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // txtFriendName
            // 
            this.txtFriendName.Location = new System.Drawing.Point(151, 47);
            this.txtFriendName.Name = "txtFriendName";
            this.txtFriendName.Size = new System.Drawing.Size(125, 27);
            this.txtFriendName.TabIndex = 1;
            // 
            // txtFriendIp
            // 
            this.txtFriendIp.Location = new System.Drawing.Point(6, 47);
            this.txtFriendIp.Name = "txtFriendIp";
            this.txtFriendIp.Size = new System.Drawing.Size(125, 27);
            this.txtFriendIp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "My Friends";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(27, 53);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(301, 328);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lan Party!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox msgOut;
        private Button btnSend;
        private RichTextBox richTextBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnAddFriend;
        private TextBox txtFriendName;
        private TextBox txtFriendIp;
        private Button btnRemoveFriend;
        private Label label4;
        private TextBox txtRmName;
        private Label label3;
        private RichTextBox richTextBox2;
        private GroupBox groupBox2;
    }
}