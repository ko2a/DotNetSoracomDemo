using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoracomDemo
{
    public partial class FormSoracom : Form
    {
        private static HttpClient client = new HttpClient();
        private const string EndPointHarvest = "http://harvest.soracom.io";

        private string sendData = "{\"element1\":\"{0}\", \"element2\":\"{1}\"}";

        public FormSoracom()
        {
            InitializeComponent();
        }

        /// フォームロードイベント
        private void FormSoracom_Load(object sender, EventArgs e)
        {
            // 要素1・2の値を表示
            DisplayElement1Value();
            DisplayElement2Value();
        }

        /// フォームを閉じるときのイベント
        private void FormSoracom_FormClosing(object sender, FormClosingEventArgs e)
        {
            // HTTPクライアントインスタンスを破棄
            client.Dispose();
        }

        /// 終了ボタンクリックイベント
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            DisplayElement1Value();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            DisplayElement2Value();
        }

        /// 要素1の値表示
        private void DisplayElement1Value()
        {
            lblElem1Value.Text = trackBar1.Value.ToString();
        }

        /// 要素2の値表示
        private void DisplayElement2Value()
        {
            lblElem2Value.Text = trackBar2.Value.ToString();
        }

        // Harvestへ送信
        private async void btnSend_ClickAsync(object sender, EventArgs e)
        {
            txtResponse.Text = string.Empty;

            var json = "{\"element1\":\"" + trackBar1.Value.ToString() + "\", \"element2\":\"" + trackBar2.Value.ToString() + "\"}";
            var content = new StringContent(json, Encoding.UTF8, @"application/json");
            var response = await client.PostAsync(EndPointHarvest, content);

            txtResponse.Text = response.ReasonPhrase;
        }
    }
}
