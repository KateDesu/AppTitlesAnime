namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }
         
        private void BtnShowTitles_Click(object sender, EventArgs e)
        {
            FormListTitles formListTitles = new FormListTitles();
            formListTitles.Show();
        }
    }
}
