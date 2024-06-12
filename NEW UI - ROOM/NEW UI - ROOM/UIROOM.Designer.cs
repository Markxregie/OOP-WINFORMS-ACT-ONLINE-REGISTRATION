namespace NEW_UI___ROOM
{
    partial class UIROOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            roundedPanel1 = new RoundedPanel();
            SearchButton = new FontAwesome.Sharp.IconButton();
            SearchTextBox = new TextBox();
            roomTypeComboBox = new CustomComboBox();
            roomStatusComboBox = new CustomComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            rmNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rmTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rmStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rmPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addRoomDataBindingSource = new BindingSource(components);
            addRoomDataBindingSource1 = new BindingSource(components);
            AddRoomButton = new RoundedButtonVer2();
            EditRoomButton = new RoundedButtonVer2();
            DeleteRoomButton = new RoundedButtonVer2();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(248, 248, 248);
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(SearchButton);
            roundedPanel1.Controls.Add(SearchTextBox);
            roundedPanel1.Controls.Add(roomTypeComboBox);
            roundedPanel1.Controls.Add(roomStatusComboBox);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(dataGridView1);
            roundedPanel1.Location = new Point(194, 56);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 20;
            roundedPanel1.Size = new Size(1121, 574);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Thickness = 5F;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            SearchButton.IconColor = Color.FromArgb(80, 129, 145);
            SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchButton.IconSize = 20;
            SearchButton.Location = new Point(553, 18);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(27, 20);
            SearchButton.TabIndex = 5;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(248, 248, 248);
            SearchTextBox.BorderColor = Color.FromArgb(115, 115, 115);
            SearchTextBox.BorderFocusColor = Color.FromArgb(115, 115, 115);
            SearchTextBox.BorderRadius = 5;
            SearchTextBox.BorderSize = 2;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            SearchTextBox.Location = new Point(273, 13);
            SearchTextBox.Margin = new Padding(4);
            SearchTextBox.Multiline = false;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Padding = new Padding(10, 7, 10, 7);
            SearchTextBox.PasswordChar = false;
            SearchTextBox.PlaceholderColor = Color.DarkGray;
            SearchTextBox.PlaceholderText = "Search for room number";
            SearchTextBox.Size = new Size(310, 31);
            SearchTextBox.TabIndex = 4;
            SearchTextBox.Texts = "";
            SearchTextBox.UnderlinedStyle = false;
            SearchTextBox.Load += textBox1_Load;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.BackColor = Color.FromArgb(248, 248, 248);
            roomTypeComboBox.BorderColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBox.BorderSize = 2;
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            roomTypeComboBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeComboBox.ForeColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBox.IconColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBox.Items.AddRange(new object[] { "Standard Room", "Deluxe Room", "Suite Room" });
            roomTypeComboBox.ListBackColor = Color.FromArgb(248, 248, 248);
            roomTypeComboBox.ListTextColor = Color.Black;
            roomTypeComboBox.Location = new Point(673, 14);
            roomTypeComboBox.MinimumSize = new Size(200, 30);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Padding = new Padding(2);
            roomTypeComboBox.Size = new Size(200, 30);
            roomTypeComboBox.TabIndex = 3;
            roomTypeComboBox.Texts = "Room Type";
            roomTypeComboBox.OnSelectedIndexChanged += roomTypeComboBox_OnSelectedIndexChanged;
            // 
            // roomStatusComboBox
            // 
            roomStatusComboBox.BackColor = Color.FromArgb(248, 248, 248);
            roomStatusComboBox.BorderColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBox.BorderSize = 2;
            roomStatusComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            roomStatusComboBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomStatusComboBox.ForeColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBox.IconColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBox.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            roomStatusComboBox.ListBackColor = Color.FromArgb(248, 248, 248);
            roomStatusComboBox.ListTextColor = Color.Black;
            roomStatusComboBox.Location = new Point(889, 14);
            roomStatusComboBox.MinimumSize = new Size(200, 30);
            roomStatusComboBox.Name = "roomStatusComboBox";
            roomStatusComboBox.Padding = new Padding(2);
            roomStatusComboBox.Size = new Size(200, 30);
            roomStatusComboBox.TabIndex = 2;
            roomStatusComboBox.Texts = "Room Status";
            roomStatusComboBox.OnSelectedIndexChanged += customComboBox1_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 129, 145);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 1;
            label1.Text = "Room List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 248, 248);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(115, 115, 115, 115);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { rmNumberDataGridViewTextBoxColumn, rmTypeDataGridViewTextBoxColumn, rmStatusDataGridViewTextBoxColumn, rmPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = addRoomDataBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DividerHeight = 2;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1121, 517);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // rmNumberDataGridViewTextBoxColumn
            // 
            rmNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rmNumberDataGridViewTextBoxColumn.DataPropertyName = "RmNumber";
            rmNumberDataGridViewTextBoxColumn.FillWeight = 150F;
            rmNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            rmNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            rmNumberDataGridViewTextBoxColumn.Name = "rmNumberDataGridViewTextBoxColumn";
            rmNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rmTypeDataGridViewTextBoxColumn
            // 
            rmTypeDataGridViewTextBoxColumn.DataPropertyName = "RmType";
            rmTypeDataGridViewTextBoxColumn.FillWeight = 150F;
            rmTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            rmTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            rmTypeDataGridViewTextBoxColumn.Name = "rmTypeDataGridViewTextBoxColumn";
            rmTypeDataGridViewTextBoxColumn.ReadOnly = true;
            rmTypeDataGridViewTextBoxColumn.Width = 260;
            // 
            // rmStatusDataGridViewTextBoxColumn
            // 
            rmStatusDataGridViewTextBoxColumn.DataPropertyName = "RmStatus";
            rmStatusDataGridViewTextBoxColumn.FillWeight = 150F;
            rmStatusDataGridViewTextBoxColumn.HeaderText = "Room Status";
            rmStatusDataGridViewTextBoxColumn.MinimumWidth = 10;
            rmStatusDataGridViewTextBoxColumn.Name = "rmStatusDataGridViewTextBoxColumn";
            rmStatusDataGridViewTextBoxColumn.ReadOnly = true;
            rmStatusDataGridViewTextBoxColumn.Width = 260;
            // 
            // rmPriceDataGridViewTextBoxColumn
            // 
            rmPriceDataGridViewTextBoxColumn.DataPropertyName = "RmPrice";
            rmPriceDataGridViewTextBoxColumn.FillWeight = 150F;
            rmPriceDataGridViewTextBoxColumn.HeaderText = "Room Price";
            rmPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            rmPriceDataGridViewTextBoxColumn.Name = "rmPriceDataGridViewTextBoxColumn";
            rmPriceDataGridViewTextBoxColumn.ReadOnly = true;
            rmPriceDataGridViewTextBoxColumn.Width = 260;
            // 
            // addRoomDataBindingSource
            // 
            addRoomDataBindingSource.DataSource = typeof(AddRoomData);
            // 
            // addRoomDataBindingSource1
            // 
            addRoomDataBindingSource1.DataSource = typeof(AddRoomData);
            // 
            // AddRoomButton
            // 
            AddRoomButton.BackColor = Color.FromArgb(248, 248, 248);
            AddRoomButton.BackgroundColor = Color.FromArgb(248, 248, 248);
            AddRoomButton.BorderColor = Color.FromArgb(248, 248, 248);
            AddRoomButton.BorderRadius = 10;
            AddRoomButton.BorderSize = 0;
            AddRoomButton.FlatAppearance.BorderSize = 0;
            AddRoomButton.FlatStyle = FlatStyle.Flat;
            AddRoomButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRoomButton.ForeColor = Color.Black;
            AddRoomButton.Location = new Point(913, 648);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(123, 37);
            AddRoomButton.TabIndex = 1;
            AddRoomButton.Text = "Add Room";
            AddRoomButton.TextColor = Color.Black;
            AddRoomButton.UseVisualStyleBackColor = false;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // EditRoomButton
            // 
            EditRoomButton.BackColor = Color.FromArgb(248, 248, 248);
            EditRoomButton.BackgroundColor = Color.FromArgb(248, 248, 248);
            EditRoomButton.BorderColor = Color.FromArgb(248, 248, 248);
            EditRoomButton.BorderRadius = 10;
            EditRoomButton.BorderSize = 0;
            EditRoomButton.FlatAppearance.BorderSize = 0;
            EditRoomButton.FlatStyle = FlatStyle.Flat;
            EditRoomButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditRoomButton.ForeColor = Color.Black;
            EditRoomButton.Location = new Point(1044, 648);
            EditRoomButton.Name = "EditRoomButton";
            EditRoomButton.Size = new Size(123, 37);
            EditRoomButton.TabIndex = 2;
            EditRoomButton.Text = "Edit Room";
            EditRoomButton.TextColor = Color.Black;
            EditRoomButton.UseVisualStyleBackColor = false;
            EditRoomButton.Click += EditRoomButton_Click;
            // 
            // DeleteRoomButton
            // 
            DeleteRoomButton.BackColor = Color.FromArgb(248, 248, 248);
            DeleteRoomButton.BackgroundColor = Color.FromArgb(248, 248, 248);
            DeleteRoomButton.BorderColor = Color.FromArgb(248, 248, 248);
            DeleteRoomButton.BorderRadius = 10;
            DeleteRoomButton.BorderSize = 0;
            DeleteRoomButton.FlatAppearance.BorderSize = 0;
            DeleteRoomButton.FlatStyle = FlatStyle.Flat;
            DeleteRoomButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteRoomButton.ForeColor = Color.Black;
            DeleteRoomButton.Location = new Point(1174, 648);
            DeleteRoomButton.Name = "DeleteRoomButton";
            DeleteRoomButton.Size = new Size(123, 37);
            DeleteRoomButton.TabIndex = 3;
            DeleteRoomButton.Text = "Delete Room";
            DeleteRoomButton.TextColor = Color.Black;
            DeleteRoomButton.UseVisualStyleBackColor = false;
            DeleteRoomButton.Click += DeleteRoomButton_Click;
            // 
            // UIROOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 129, 145);
            ClientSize = new Size(1325, 702);
            Controls.Add(DeleteRoomButton);
            Controls.Add(EditRoomButton);
            Controls.Add(AddRoomButton);
            Controls.Add(roundedPanel1);
            Name = "UIROOM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UIROOM";
            Load += UIROOM_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private DataGridView dataGridView1;
        private Label label1;
        private CustomComboBox roomStatusComboBox;
        private CustomComboBox roomTypeComboBox;
        private TextBox SearchTextBox;
        private FontAwesome.Sharp.IconButton SearchButton;
        private RoundedButtonVer2 AddRoomButton;
        private RoundedButtonVer2 EditRoomButton;
        private RoundedButtonVer2 DeleteRoomButton;
        private BindingSource addRoomDataBindingSource;
        private DataGridViewTextBoxColumn rmNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rmTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rmStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rmPriceDataGridViewTextBoxColumn;
        private BindingSource addRoomDataBindingSource1;
    }
}