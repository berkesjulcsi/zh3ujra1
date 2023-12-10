namespace zh3ujra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void üzletbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ÜzletekUC üzletekUC = new ÜzletekUC();
            panel1.Controls.Add(üzletekUC);
            panel1.Dock = DockStyle.Fill;

        }

        private void csomagokbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CsomagokUC csomagokUC = new CsomagokUC();
            panel1.Controls.Add(csomagokUC);
            panel1.Dock = DockStyle.Fill;
        }

        private void excelbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ExcelUC excelUC = new ExcelUC();
            panel1.Controls.Add(excelUC);
            panel1.Dock = DockStyle.Fill;
        }

        private void tudnivalókbttn_Click(object sender, EventArgs e)
        {
            TudnivalókForm tudnivalókForm = new TudnivalókForm();
            tudnivalókForm.ShowDialog();
        }

        private void ügyfelekbttn_Click(object sender, EventArgs e)
        {
            ÜgyfelekForm ügyfelekForm = new ÜgyfelekForm();
            ügyfelekForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Be szeretnéd zárni a Formot?", "Form bezárása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}