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
public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn10posts_Click(object sender, EventArgs e)
        {
            
            formFirst10Post first10post = new formFirst10Post();
            first10post.Show();
            this.Close();
        }

        private async void btnComments_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                    HttpResponseMessage response = await client.GetAsync("/posts/2/comments");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBodey = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseBodey);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                
            }
        }

        private async void btn10albums_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                for (int i = 1; i <2 ; i++)
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                    HttpResponseMessage response = await client.GetAsync($"/albums/{i}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBodey = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseBodey);
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
