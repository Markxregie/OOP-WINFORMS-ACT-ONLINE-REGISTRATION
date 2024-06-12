namespace NEW_UI___ROOM
{
    partial class ADD_ROOM_PAGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_ROOM_PAGE));
            SaveAddRoomButton = new RoundedButtonVer2();
            CancelButton = new RoundedButtonVer2();
            roundedPanel1 = new RoundedPanel();
            panel2 = new Panel();
            label5 = new Label();
            PricePNComboBox = new CustomComboBox();
            label4 = new Label();
            roomStatusComboBoxAdd = new CustomComboBox();
            label3 = new Label();
            roomTypeComboBoxAdd = new CustomComboBox();
            label2 = new Label();
            TextBoxRoomNumber = new TextBox();
            label1 = new Label();
            addRoomDataBindingSource = new BindingSource(components);
            panel1 = new Panel();
            roundedPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SaveAddRoomButton
            // 
            SaveAddRoomButton.BackColor = Color.FromArgb(248, 248, 248);
            SaveAddRoomButton.BackgroundColor = Color.FromArgb(248, 248, 248);
            SaveAddRoomButton.BorderColor = Color.FromArgb(248, 248, 248);
            SaveAddRoomButton.BorderRadius = 10;
            SaveAddRoomButton.BorderSize = 0;
            SaveAddRoomButton.DialogResult = DialogResult.OK;
            SaveAddRoomButton.FlatAppearance.BorderSize = 0;
            SaveAddRoomButton.FlatStyle = FlatStyle.Flat;
            SaveAddRoomButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAddRoomButton.ForeColor = Color.Black;
            SaveAddRoomButton.Location = new Point(298, 401);
            SaveAddRoomButton.Name = "SaveAddRoomButton";
            SaveAddRoomButton.Size = new Size(96, 37);
            SaveAddRoomButton.TabIndex = 3;
            SaveAddRoomButton.Text = "Save";
            SaveAddRoomButton.TextColor = Color.Black;
            SaveAddRoomButton.UseVisualStyleBackColor = false;
            SaveAddRoomButton.Click += SaveAddRoomButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(248, 248, 248);
            CancelButton.BackgroundColor = Color.FromArgb(248, 248, 248);
            CancelButton.BorderColor = Color.FromArgb(248, 248, 248);
            CancelButton.BorderRadius = 10;
            CancelButton.BorderSize = 0;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(399, 401);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(96, 37);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.TextColor = Color.Black;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(248, 248, 248);
            roundedPanel1.BorderColor = Color.FromArgb(248, 248, 248);
            roundedPanel1.Controls.Add(panel2);
            roundedPanel1.Controls.Add(PricePNComboBox);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(roomStatusComboBoxAdd);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(roomTypeComboBoxAdd);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(TextBoxRoomNumber);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(41, 79);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 25;
            roundedPanel1.Size = new Size(723, 316);
            roundedPanel1.TabIndex = 5;
            roundedPanel1.Thickness = 5F;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(115, 115, 115, 115);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 50);
            panel2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(247, 11);
            label5.Name = "label5";
            label5.Size = new Size(205, 29);
            label5.TabIndex = 12;
            label5.Text = "ROOM DETAILS";
            label5.Click += label5_Click;
            // 
            // PricePNComboBox
            // 
            PricePNComboBox.BackColor = Color.FromArgb(248, 248, 248);
            PricePNComboBox.BorderColor = Color.FromArgb(115, 115, 115);
            PricePNComboBox.BorderSize = 2;
            PricePNComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            PricePNComboBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PricePNComboBox.ForeColor = Color.FromArgb(115, 115, 115);
            PricePNComboBox.IconColor = Color.FromArgb(115, 115, 115);
            PricePNComboBox.Items.AddRange(new object[] { "1,899/night - FOR STANDARD", "2,899/night - FOR DELUXE", "3,899/night - FOR SUITE" });
            PricePNComboBox.ListBackColor = Color.FromArgb(248, 248, 248);
            PricePNComboBox.ListTextColor = Color.Black;
            PricePNComboBox.Location = new Point(229, 233);
            PricePNComboBox.MinimumSize = new Size(200, 30);
            PricePNComboBox.Name = "PricePNComboBox";
            PricePNComboBox.Padding = new Padding(2);
            PricePNComboBox.Size = new Size(317, 30);
            PricePNComboBox.TabIndex = 11;
            PricePNComboBox.Texts = "Price Per Night";
            PricePNComboBox.OnSelectedIndexChanged += PricePNComboBox_OnSelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(80, 129, 145);
            label4.Location = new Point(29, 239);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 10;
            label4.Text = "Price per night:";
            label4.Click += label4_Click;
            // 
            // roomStatusComboBoxAdd
            // 
            roomStatusComboBoxAdd.BackColor = Color.FromArgb(248, 248, 248);
            roomStatusComboBoxAdd.BorderColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBoxAdd.BorderSize = 2;
            roomStatusComboBoxAdd.DropDownStyle = ComboBoxStyle.DropDown;
            roomStatusComboBoxAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomStatusComboBoxAdd.ForeColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBoxAdd.IconColor = Color.FromArgb(115, 115, 115);
            roomStatusComboBoxAdd.Items.AddRange(new object[] { "Available ", "Occupied", "Under Maintenance" });
            roomStatusComboBoxAdd.ListBackColor = Color.FromArgb(248, 248, 248);
            roomStatusComboBoxAdd.ListTextColor = Color.Black;
            roomStatusComboBoxAdd.Location = new Point(229, 185);
            roomStatusComboBoxAdd.MinimumSize = new Size(200, 30);
            roomStatusComboBoxAdd.Name = "roomStatusComboBoxAdd";
            roomStatusComboBoxAdd.Padding = new Padding(2);
            roomStatusComboBoxAdd.Size = new Size(200, 30);
            roomStatusComboBoxAdd.TabIndex = 11;
            roomStatusComboBoxAdd.Texts = "Room Status";
            roomStatusComboBoxAdd.OnSelectedIndexChanged += roomStatusComboBoxAdd_OnSelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(80, 129, 145);
            label3.Location = new Point(29, 191);
            label3.Name = "label3";
            label3.Size = new Size(167, 24);
            label3.TabIndex = 8;
            label3.Text = "Add room status:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // roomTypeComboBoxAdd
            // 
            roomTypeComboBoxAdd.BackColor = Color.FromArgb(248, 248, 248);
            roomTypeComboBoxAdd.BorderColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBoxAdd.BorderSize = 2;
            roomTypeComboBoxAdd.DropDownStyle = ComboBoxStyle.DropDown;
            roomTypeComboBoxAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeComboBoxAdd.ForeColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBoxAdd.IconColor = Color.FromArgb(115, 115, 115);
            roomTypeComboBoxAdd.Items.AddRange(new object[] { "Standard Room", "Deluxe Room", "Suite Room" });
            roomTypeComboBoxAdd.ListBackColor = Color.FromArgb(248, 248, 248);
            roomTypeComboBoxAdd.ListTextColor = Color.Black;
            roomTypeComboBoxAdd.Location = new Point(229, 137);
            roomTypeComboBoxAdd.MinimumSize = new Size(200, 30);
            roomTypeComboBoxAdd.Name = "roomTypeComboBoxAdd";
            roomTypeComboBoxAdd.Padding = new Padding(2);
            roomTypeComboBoxAdd.Size = new Size(200, 30);
            roomTypeComboBoxAdd.TabIndex = 11;
            roomTypeComboBoxAdd.Texts = "Room Type";
            roomTypeComboBoxAdd.OnSelectedIndexChanged += roomTypeComboBoxAdd_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(80, 129, 145);
            label2.Location = new Point(29, 143);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 6;
            label2.Text = "Add room type:";
            label2.Click += label2_Click;
            // 
            // TextBoxRoomNumber
            // 
            TextBoxRoomNumber.BackColor = Color.FromArgb(248, 248, 248);
            TextBoxRoomNumber.BorderColor = Color.FromArgb(115, 115, 115);
            TextBoxRoomNumber.BorderFocusColor = Color.FromArgb(115, 115, 115);
            TextBoxRoomNumber.BorderRadius = 5;
            TextBoxRoomNumber.BorderSize = 2;
            TextBoxRoomNumber.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBoxRoomNumber.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxRoomNumber.Location = new Point(229, 85);
            TextBoxRoomNumber.Margin = new Padding(4);
            TextBoxRoomNumber.Multiline = false;
            TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            TextBoxRoomNumber.Padding = new Padding(10, 7, 10, 7);
            TextBoxRoomNumber.PasswordChar = false;
            TextBoxRoomNumber.PlaceholderColor = Color.DarkGray;
            TextBoxRoomNumber.PlaceholderText = "Add Room Number";
            TextBoxRoomNumber.Size = new Size(203, 33);
            TextBoxRoomNumber.TabIndex = 5;
            TextBoxRoomNumber.Texts = "";
            TextBoxRoomNumber.UnderlinedStyle = false;
            TextBoxRoomNumber.Load += LabelRoomNumber_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 129, 145);
            label1.Location = new Point(29, 94);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 0;
            label1.Text = "Add room number:";
            label1.Click += label1_Click;
            // 
            // addRoomDataBindingSource
            // 
            addRoomDataBindingSource.DataSource = typeof(AddRoomData);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(359, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 67);
            panel1.TabIndex = 6;
            // 
            // ADD_ROOM_PAGE
            // 
            AcceptButton = SaveAddRoomButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 129, 145);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(roundedPanel1);
            Controls.Add(CancelButton);
            Controls.Add(SaveAddRoomButton);
            Name = "ADD_ROOM_PAGE";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ADD_ROOM_PAGE";
            Load += ADD_ROOM_PAGE_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addRoomDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButtonVer2 SaveAddRoomButton;
        private RoundedButtonVer2 CancelButton;
        private RoundedPanel roundedPanel1;
        private Panel panel1;
        private Label label1;
        private TextBox TextBoxRoomNumber;
        private Label label2;
        private Label label3;
        private CustomComboBox roomTypeComboBoxAdd;
        private CustomComboBox PricePNComboBox;
        private Label label4;
        private CustomComboBox roomStatusComboBoxAdd;
        private BindingSource addRoomDataBindingSource;
        private Panel panel2;
        private Label label5;
    }
}