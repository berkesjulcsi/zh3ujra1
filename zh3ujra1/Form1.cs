namespace zh3ujra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void �zletbttn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            �zletekUC �zletekUC = new �zletekUC();
            panel1.Controls.Add(�zletekUC);
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

        private void tudnival�kbttn_Click(object sender, EventArgs e)
        {
            Tudnival�kForm tudnival�kForm = new Tudnival�kForm();
            tudnival�kForm.ShowDialog();
        }

        private void �gyfelekbttn_Click(object sender, EventArgs e)
        {
            �gyfelekForm �gyfelekForm = new �gyfelekForm();
            �gyfelekForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Be szeretn�d z�rni a Formot?", "Form bez�r�sa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}