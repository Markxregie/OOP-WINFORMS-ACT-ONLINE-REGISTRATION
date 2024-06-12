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

    public partial class ADD_ROOM_PAGE : Form
    {
        public AddRoomData GetDataRoom { get; set; }
        public ADD_ROOM_PAGE()
        {
            InitializeComponent();
        }

        private void SaveAddRoomButton_Click(object sender, EventArgs e)
        {
            GetDataRoom.RmNumber = TextBoxRoomNumber.Texts;
            GetDataRoom.RmType = roomTypeComboBoxAdd.Texts;
            GetDataRoom.RmStatus = roomStatusComboBoxAdd.Texts;
            GetDataRoom.RmPrice = PricePNComboBox.Texts;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADD_ROOM_PAGE_Load(object sender, EventArgs e)
        {
            if (GetDataRoom != null)
            {
                TextBoxRoomNumber.Texts = GetDataRoom.RmNumber;
                roomTypeComboBoxAdd.Texts = GetDataRoom.RmType;
                roomStatusComboBoxAdd.Texts = GetDataRoom.RmStatus;
                PricePNComboBox.Texts = GetDataRoom.RmPrice;
            }
        }

        private void LabelRoomNumber_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Load(object sender, EventArgs e)
        {

        }

        private void PricePNComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomStatusComboBoxAdd_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomTypeComboBoxAdd_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
