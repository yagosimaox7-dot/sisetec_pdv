using System.Diagnostics;

namespace sisetec_pdv
{
    public partial class Fr : Form
    {
        public Fr()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimentaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void canalYoutubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string navegador = "\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"";
            string url = "https://www.youtube.com/watch?v=BRCNquRjSwM";
            Process.Start(navegador, url);
        }
    }
}
