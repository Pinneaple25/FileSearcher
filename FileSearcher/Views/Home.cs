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
            var form = new Search();
            form.ShowDialog();
        }
    }
}
