using FileSearcher.Views;

namespace FileSearcher
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = OpenFolder.SelectedPath;
                string[] files = [.. Directory.GetFiles(path, "*.pdf").Where(Filter)];
                var form = new Search(files);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            OpenFolder.ShowDialog(this);
        }

        private bool Filter(string file) => file
            .Split('\\')[^1]
            .Replace(".pdf", "")
            .Contains(TxtBuscar.Text ?? "", StringComparison.CurrentCultureIgnoreCase);
    }
}
