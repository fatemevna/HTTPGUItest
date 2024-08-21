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

namespace httmlGUI
{
    public partial class formFirst10Post : Form
    {
        public formFirst10Post()
        {
            InitializeComponent();
        }

        private  async void labelFirst10Post_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                for (int i = 1; i < 11 ; i++)
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                    HttpResponseMessage response = await client.GetAsync($"/posts/{i}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBodey = await response.Content.ReadAsStringAsync();
                        labelFirst10Post.Text = responseBodey;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
            }
        }
    }
}
