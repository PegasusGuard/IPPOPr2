namespace IPPOPr2
{
    partial class MailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailClient));
            this.addressLbl = new System.Windows.Forms.Label();
            this.topicLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.msgTopic = new System.Windows.Forms.TextBox();
            this.msgBody = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addrTo = new System.Windows.Forms.DomainUpDown();
            this.serverLbl = new System.Windows.Forms.Label();
            this.addrToLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.fileLbl = new System.Windows.Forms.Label();
            this.serverList = new System.Windows.Forms.ComboBox();
            this.addrFrom = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.fileListLbl = new System.Windows.Forms.Label();
            this.selectFilesBtn = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(13, 288);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(98, 13);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Адрес получателя";
            // 
            // topicLbl
            // 
            this.topicLbl.AutoSize = true;
            this.topicLbl.Location = new System.Drawing.Point(13, 322);
            this.topicLbl.Name = "topicLbl";
            this.topicLbl.Size = new System.Drawing.Size(34, 13);
            this.topicLbl.TabIndex = 1;
            this.topicLbl.Text = "Тема";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(13, 354);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(87, 13);
            this.messageLbl.TabIndex = 2;
            this.messageLbl.Text = "Текст отправки";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(13, 516);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgTopic
            // 
            this.msgTopic.Location = new System.Drawing.Point(144, 319);
            this.msgTopic.Name = "msgTopic";
            this.msgTopic.Size = new System.Drawing.Size(232, 20);
            this.msgTopic.TabIndex = 6;
            // 
            // msgBody
            // 
            this.msgBody.Location = new System.Drawing.Point(144, 351);
            this.msgBody.Multiline = true;
            this.msgBody.Name = "msgBody";
            this.msgBody.Size = new System.Drawing.Size(232, 188);
            this.msgBody.TabIndex = 7;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton1.Text = "Пишите здесь";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addrTo
            // 
            this.addrTo.Location = new System.Drawing.Point(144, 286);
            this.addrTo.Name = "addrTo";
            this.addrTo.Size = new System.Drawing.Size(232, 20);
            this.addrTo.TabIndex = 5;
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(12, 39);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(44, 13);
            this.serverLbl.TabIndex = 9;
            this.serverLbl.Text = "Сервер";
            // 
            // addrToLbl
            // 
            this.addrToLbl.AutoSize = true;
            this.addrToLbl.Location = new System.Drawing.Point(12, 72);
            this.addrToLbl.Name = "addrToLbl";
            this.addrToLbl.Size = new System.Drawing.Size(105, 13);
            this.addrToLbl.TabIndex = 10;
            this.addrToLbl.Text = "Адрес отправителя";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(12, 107);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(45, 13);
            this.passLbl.TabIndex = 11;
            this.passLbl.Text = "Пароль";
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(13, 141);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(80, 13);
            this.fileLbl.TabIndex = 12;
            this.fileLbl.Text = "Выбрать файл";
            // 
            // serverList
            // 
            this.serverList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.serverList.FormattingEnabled = true;
            this.serverList.Items.AddRange(new object[] {
            "gmail",
            "mail",
            "yandex"});
            this.serverList.SelectedIndex = 0;
            this.serverList.Location = new System.Drawing.Point(144, 36);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(121, 21);
            this.serverList.TabIndex = 13;
            // 
            // addrFrom
            // 
            this.addrFrom.Location = new System.Drawing.Point(144, 69);
            this.addrFrom.Name = "addrFrom";
            this.addrFrom.Size = new System.Drawing.Size(232, 20);
            this.addrFrom.TabIndex = 14;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(144, 104);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 20);
            this.password.TabIndex = 15;
            // 
            // fileListLbl
            // 
            this.fileListLbl.AutoSize = true;
            this.fileListLbl.Location = new System.Drawing.Point(13, 170);
            this.fileListLbl.Name = "fileListLbl";
            this.fileListLbl.Size = new System.Drawing.Size(85, 13);
            this.fileListLbl.TabIndex = 16;
            this.fileListLbl.Text = "Список файлов";
            // 
            // selectFilesBtn
            // 
            this.selectFilesBtn.Location = new System.Drawing.Point(144, 136);
            this.selectFilesBtn.Name = "selectFilesBtn";
            this.selectFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFilesBtn.TabIndex = 17;
            this.selectFilesBtn.Text = "Открыть";
            this.selectFilesBtn.UseVisualStyleBackColor = true;
            this.selectFilesBtn.Click += new System.EventHandler(this.selectFilesBtn_Click);
            // 
            // fileListView
            // 
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(16, 193);
            this.fileListView.MultiSelect = false;
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(360, 77);
            this.fileListView.TabIndex = 18;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.List;
            this.fileListView.SelectedIndexChanged += new System.EventHandler(this.fileListView_SelectedIndexChanged);
            this.fileListView.DoubleClick += new System.EventHandler(this.fileListView_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 560);
            this.Controls.Add(this.fileListView);
            this.Controls.Add(this.selectFilesBtn);
            this.Controls.Add(this.fileListLbl);
            this.Controls.Add(this.password);
            this.Controls.Add(this.addrFrom);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.addrToLbl);
            this.Controls.Add(this.serverLbl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msgBody);
            this.Controls.Add(this.msgTopic);
            this.Controls.Add(this.addrTo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.topicLbl);
            this.Controls.Add(this.addressLbl);
            this.Name = "MailClient";
            this.Text = "Почтовый клиент";
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label topicLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox msgTopic;
        private System.Windows.Forms.TextBox msgBody;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DomainUpDown addrTo;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.Label addrToLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.ComboBox serverList;
        private System.Windows.Forms.TextBox addrFrom;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label fileListLbl;
        private System.Windows.Forms.Button selectFilesBtn;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

