using System;
using System.Drawing; // Add this using directive for Font and Color
using System.Windows.Forms;

namespace custom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            CustomDataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00072d");
            CustomDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void CustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
