namespace FileSearcher.Views
{
    public partial class Search : Form
    {
        private readonly string[] Files;
        private readonly Panel[] Panels;
        private readonly LinkLabel[] Links;

        public Search(string[] files)
        {
            InitializeComponent();
            Panels = [Panel1, Panel2, Panel3, Panel4, Panel5];
            Links = [Link1, Link2, Link3, Link4, Link5];
            Files = files;
            for (int i = 0; i < files.Length; i++)
            {
                Panels[i].Visible = true;
                Links[i].Text = files[i];
                Links[i].LinkClicked += (sender, e) =>
                {
                    if (sender is not LinkLabel link) return;

                    link.LinkVisited = true;
                    var uri = new Uri(link.Text);
                    var form = new Viewer(uri);
                    form.ShowDialog();
                };
            }
        }

        private void Click(string file)
        {

        }
    }
}
