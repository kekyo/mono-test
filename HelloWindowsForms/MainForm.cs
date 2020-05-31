using System;
using System.Windows.Forms;

using HelloWindowsForms.Models;

namespace HelloWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void fetchButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            try
            {
                // Uses Reddit API
                var reddits = await Reddit.FetchNewPostsAsync("r/aww");

                this.itemsList.Items.Clear();
                this.imageList.Images.Clear();

                foreach (var reddit in reddits)
                {
                    this.imageList.Images.Add(await Reddit.FetchImageAsync(reddit.Url));
                    this.itemsList.Items.Add(reddit.Title, this.imageList.Images.Count - 1);
                }
            }
            finally
            {
                this.Enabled = true;
            }
        }
    }
}
