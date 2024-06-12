using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_UI___ROOM
{
    public partial class UIROOM : Form
    {
        public UIROOM()
        {
            InitializeComponent();
            SetDataGridViewStyles();
        }

        private void SetDataGridViewStyles()
        {
            Font dataGridFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ececec");

            // Set the font for the entire DataGridView
            dataGridView1.Font = dataGridFont;

            // Set the font for all cells
            dataGridView1.DefaultCellStyle.Font = dataGridFont;
        }

        private void UIROOM_Load(object sender, EventArgs e)
        {
            
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void roomTypeComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Load(object sender, EventArgs e)
        {

        }

        private void EditRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomData obj = addRoomDataBindingSource.Current as AddRoomData;
            if (obj != null)
            {
                using(ADD_ROOM_PAGE frm = new ADD_ROOM_PAGE() { GetDataRoom = obj })
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        addRoomDataBindingSource.EndEdit();
                        EditRoomButton.Focus();
                    }
                }
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (ADD_ROOM_PAGE frm = new ADD_ROOM_PAGE() { GetDataRoom = new AddRoomData() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    addRoomDataBindingSource.Add(frm.GetDataRoom);
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
