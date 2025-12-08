using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace pySDyPPForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;
        private readonly string apiUrl = "https://localhost:7112";

        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private async Task<string> GetApiResponse(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
