using HomeTools.Utils;

namespace SceneFileMergerUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdscene.Filter = "SCENE files (*.SCENE)|*.SCENE";
            ofdscene.RestoreDirectory = true;
            ofdscene.Multiselect = false;
            ofdscene.FileName = string.Empty;
            if (ofdscene.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofdscene.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdscene.Filter = "SCENE files (*.SCENE)|*.SCENE";
            ofdscene.RestoreDirectory = true;
            ofdscene.Multiselect = false;
            ofdscene.FileName = string.Empty;
            if (ofdscene.ShowDialog() == DialogResult.OK)
                textBox2.Text = ofdscene.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SourceScenePath = textBox1.Text;
            string DestScenePath = textBox2.Text;
            if (!File.Exists(SourceScenePath) || !File.Exists(DestScenePath))
            {
                MessageBox.Show("One of the scene files doesn't exists!", "ERROR");
                return;
            }
            SceneMerger.MergeSceneFiles(SourceScenePath, DestScenePath);
            this.Text = "Merged!";
        }
    }
}
