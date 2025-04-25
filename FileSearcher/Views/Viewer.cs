namespace FileSearcher.Views
{
    public partial class Viewer : Form
    {
        public Viewer(Uri file)
        {
            InitializeComponent();
            web1.Source = file;
        }
    }
}
