using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Web_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath + WayName();
            
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonDwnld_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                errorProvider1.SetError(textBox1, "Le chemin indiqué n'existe pas");
            }
            else
            {
                errorProvider1.Dispose();
                WebClient web = new WebClient();
                web.DownloadProgressChanged += DownloadProgressChanges;
                web.DownloadFileCompleted += DownloadDone;
                Uri uri;
                try
                {
                    uri = new Uri(textBoxURL.Text);
                    WebRequest tryCreate = WebRequest.Create(uri);
                    WebResponse webResponse = await tryCreate.GetResponseAsync();
                    if (File.Exists(folderBrowserDialog1.SelectedPath + WayName()))
                    {
                        File.Delete(folderBrowserDialog1.SelectedPath + WayName());
                        web.DownloadFileAsync(uri, folderBrowserDialog1.SelectedPath + WayName());
                    }
                    else
                        web.DownloadFileAsync(uri, folderBrowserDialog1.SelectedPath + WayName());
                }
                catch (UriFormatException _e)
                {
                    MessageBox.Show(_e.Message.ToString());
                }
                catch (NotSupportedException _e)
                {
                    MessageBox.Show(_e.Message.ToString());
                }
                catch (WebException _e)
                {
                    MessageBox.Show(_e.Message.ToString());
                }
                catch (Exception _e)
                {
                    MessageBox.Show(_e.Message.ToString());
                }

            }

         
        }

        private void DownloadDone(object sender, AsyncCompletedEventArgs e)
        {
            if (progressBar1.Value == 100)
                MessageBox.Show("Téléchargement terminé");
        }

        private void DownloadProgressChanges(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void buttonRecharger_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        public string WayName()
        {
            string chemin = string.Empty;
            char[] tab = textBoxURL.Text.ToCharArray();
            List<string> result = new List<string>();
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                if (tab[i].ToString() != "/")
                    result.Add(tab[i].ToString());
                else
                    break;
            }
            result.Reverse();
            for (int y = 0; y < result.Count; y++)
            {
                chemin =  chemin + result[y].ToString();
            }
            return @"\" + chemin;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
