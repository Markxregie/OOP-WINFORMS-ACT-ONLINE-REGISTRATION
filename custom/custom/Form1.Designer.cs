namespace custom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CustomDataGrid = new DataGridView();
            GuestID = new DataGridViewTextBoxColumn();
            GuestName = new DataGridViewTextBoxColumn();
            ContactNo = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CustomDataGrid);
            panel1.Location = new Point(211, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 572);
            panel1.TabIndex = 0;
            // 
            // CustomDataGrid
            // 
            CustomDataGrid.AllowUserToAddRows = false;
            CustomDataGrid.AllowUserToDeleteRows = false;
            CustomDataGrid.AllowUserToResizeColumns = false;
            CustomDataGrid.AllowUserToResizeRows = false;
            CustomDataGrid.BackgroundColor = Color.Gainsboro;
            CustomDataGrid.BorderStyle = BorderStyle.None;
            CustomDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            CustomDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomDataGrid.ColumnHeadersHeight = 50;
            CustomDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CustomDataGrid.Columns.AddRange(new DataGridViewColumn[] { GuestID, GuestName, ContactNo, RoomType, RoomNumber, CheckIn, CheckOut });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            CustomDataGrid.Dock = DockStyle.Fill;
            CustomDataGrid.EnableHeadersVisualStyles = false;
            CustomDataGrid.GridColor = Color.Black;
            CustomDataGrid.Location = new Point(0, 0);
            CustomDataGrid.Margin = new Padding(0);
            CustomDataGrid.MultiSelect = false;
            CustomDataGrid.Name = "CustomDataGrid";
            CustomDataGrid.ReadOnly = true;
            CustomDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CustomDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomDataGrid.Size = new Size(1073, 572);
            CustomDataGrid.TabIndex = 0;
            CustomDataGrid.CellContentClick += CustomDataGrid_CellContentClick;
            // 
            // GuestID
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuestID.DefaultCellStyle = dataGridViewCellStyle1;
            GuestID.HeaderText = "Guest ID";
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Resizable = DataGridViewTriState.True;
            GuestID.Width = 147;
            // 
            // GuestName
            // 
            GuestName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GuestName.HeaderText = "GuestName";
            GuestName.Name = "GuestName";
            GuestName.ReadOnly = true;
            // 
            // ContactNo
            // 
            ContactNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContactNo.HeaderText = "Contact No.";
            ContactNo.Name = "ContactNo";
            ContactNo.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomType.HeaderText = "Room Type";
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // CheckIn
            // 
            CheckIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CheckIn.HeaderText = "Check-In Date and Time";
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            CheckOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CheckOut.HeaderText = "Check-Out Date and Time";
            CheckOut.Name = "CheckOut";
            CheckOut.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 658);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "CustomGrid";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView CustomDataGrid;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn GuestName;
        private DataGridViewTextBoxColumn ContactNo;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
    }
}
