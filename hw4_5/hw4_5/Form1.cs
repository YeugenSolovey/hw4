namespace hw4_5
{
    public partial class Form1 : Form
    {
        private const int _row = 0;
        private const int _minColumns = 6;
        private const int _rowHeaderSize = 80;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView(_row, _minColumns);
        }
        private void HeaderTable()
        {
            var nameCol = new List<string> { "Name", "Cost", "Description", "Count", "Country", "Type"};
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = nameCol[col.Index];
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        private void InitializeDataGridView(int rowCount, int columnCount)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowCount = rowCount;
            dataGridView1.ColumnCount = columnCount;

            HeaderTable();

            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersWidth = _rowHeaderSize;
            dataGridView1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//add bttn
        {
            float _cost = float.Parse(textBox2.Text);
            int _count = Convert.ToInt32(textBox4.Text);

            if (_count <= 0 || _cost <= 0)
            {
                MessageBox.Show("Error", "Error");
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (textBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                }
                else
                {
                    MessageBox.Show("THIS PRODUCT IS ALREADY IN THE TABLE");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//delete bttn
        {
            int countRow = dataGridView1.RowCount;
            int countColumn = dataGridView1.ColumnCount;
            string deleteRowInfo = "you can't choose less than 0";
            string HeaderOfMesageBox = "Warning";
            string deleteShure = "Are you shure?";

            DialogResult result = MessageBox.Show(deleteShure, HeaderOfMesageBox, MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (countRow > 0)
                {
                    InitializeDataGridView(countRow - 1, countColumn);
                }
                else
                {
                    MessageBox.Show(deleteRowInfo, HeaderOfMesageBox);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}