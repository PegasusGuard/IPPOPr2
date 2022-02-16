using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;


namespace IPPOPr2
{
    public partial class MailClient : Form
    {
        private MailMessage message = new MailMessage();
        
        public MailClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MailClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            switch (serverList.SelectedIndex)
            {
                case 1:
                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    break;
                case 2:
                    client.Host = "smtp.yandex.ru";
                    client.Port = 587;
                    break;
                default:
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    break;
            }
            client.Credentials = new NetworkCredential($"{addrFrom.Text}", $"{password.Text}");
            client.EnableSsl = true;
            MailAddress from = new MailAddress($"{addrFrom.Text}", "PegasusGuard");
            MailAddress to = new MailAddress($"{addrTo.Text}");
            message.From = from;
            message.To.Add(to);
            message.Subject = msgTopic.Text;
            message.Body = msgBody.Text;
            topicLbl.Text = msgTopic.Text;
            messageLbl.Text = msgBody.Text;

            try
            {
                LogicMethods.SendEmailAsync(message, client).GetAwaiter().OnCompleted(() =>
                {
                    message.Dispose();
                    message = new MailMessage();
                });
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
                                
        }

        private void selectFilesBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Activate();
            string[] files = openFileDialog1.FileNames;
            foreach (string file in files)
            {
                fileListView.Items.Add(new ListViewItem(file));
                message.Attachments.Add(new Attachment(file, MediaTypeNames.Application.Octet));
            }

            

        }

        private void fileListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fileListView_DoubleClick(object sender, EventArgs e)
        {
            string file = fileListView.SelectedItems[0].Text;

            try
            {
                if (System.IO.File.Exists(file))
                {
                    System.Diagnostics.Process.Start(file);
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файл не найден и юудет удалён из списка прикрепленных файлов");
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("Невозможно открыть файл");
            }
        }
    }
}
