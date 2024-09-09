namespace MokhatabMan
{
    public partial class Form1 : Form
    {
        IMokhatabRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new MokhatabRepository();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.Columns[0].Visible = false;
            dgContacts.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            formAddOrEdit frm = new formAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                string name = dgContacts.CurrentRow.Cells[1].Value.ToString();

                string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string fullName = name + family;

                if (MessageBox.Show($"آیا از حذف شدن {fullName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                {
                    int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(contactId);
                    BindGrid();

                }
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                formAddOrEdit frm = new formAddOrEdit();
                frm.contactId = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
