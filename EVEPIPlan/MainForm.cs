namespace EVEPIPlan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addPIInfoBtn_Click(object sender, EventArgs e)
        {
            (new PIInfo(this)).Show();
        }

        public void UpdatePIList()
        {

        }
    }
}