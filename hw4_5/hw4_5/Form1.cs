namespace hw4_5
{
    public partial class Form1 : Form
    {
        private const int _row = 0;
        private const int _minColumns = 5;
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
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = (col.Index + 1).ToString();
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
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
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
    }
}