namespace Programming
{
    partial class ZorkGUI
    {

        private System.ComponentModel.IContainer components = null;


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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTab = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Startlocations = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WestDropList = new System.Windows.Forms.ComboBox();
            this.EastDropList = new System.Windows.Forms.ComboBox();
            this.SouthDropList = new System.Windows.Forms.ComboBox();
            this.NorthDropList = new System.Windows.Forms.ComboBox();
            this.West = new System.Windows.Forms.Label();
            this.East = new System.Windows.Forms.Label();
            this.South = new System.Windows.Forms.Label();
            this.North = new System.Windows.Forms.Label();
            this.RoomProperties = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.RoomsGroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomProperty = new System.Windows.Forms.GroupBox();
            this.DownDropList = new System.Windows.Forms.ComboBox();
            this.UpDropList = new System.Windows.Forms.ComboBox();
            this.Down = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Label();
            this.SelectRoom = new System.Windows.Forms.Label();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.Neighbors = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.EditRoomNameText = new System.Windows.Forms.TextBox();
            this.EditRoomName = new System.Windows.Forms.Label();
            this.SelectDropDown = new System.Windows.Forms.ComboBox();
            this.Remove = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Roomnumber = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.FileSpearator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.RoomProperties.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.RoomsGroup.SuspendLayout();
            this.RoomProperty.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roomnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.HelpTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameFile,
            this.OpenGameFile,
            this.SaveGameFile,
            this.SaveGameFileAs,
            this.FileSpearator,
            this.Quit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewGameFile
            // 
            this.NewGameFile.Name = "NewGameFile";
            this.NewGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGameFile.Size = new System.Drawing.Size(202, 22);
            this.NewGameFile.Text = "&New Game";
            // 
            // OpenGameFile
            // 
            this.OpenGameFile.Name = "OpenGameFile";
            this.OpenGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenGameFile.Size = new System.Drawing.Size(202, 22);
            this.OpenGameFile.Text = "&Open Game...";
            this.OpenGameFile.Click += new System.EventHandler(this.OpenGameFile_Click);
            // 
            // SaveGameFile
            // 
            this.SaveGameFile.Name = "SaveGameFile";
            this.SaveGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveGameFile.Size = new System.Drawing.Size(202, 22);
            this.SaveGameFile.Text = "Save Game";
            // 
            // SaveGameFileAs
            // 
            this.SaveGameFileAs.Name = "SaveGameFileAs";
            this.SaveGameFileAs.Size = new System.Drawing.Size(202, 22);
            this.SaveGameFileAs.Text = "Save As...";
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Quit.Size = new System.Drawing.Size(202, 22);
            this.Quit.Text = "&Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // HelpTab
            // 
            this.HelpTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zorkMapToolStripMenuItem});
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Size = new System.Drawing.Size(47, 21);
            this.HelpTab.Text = "Help";
            // 
            // zorkMapToolStripMenuItem
            // 
            this.zorkMapToolStripMenuItem.Name = "zorkMapToolStripMenuItem";
            this.zorkMapToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.zorkMapToolStripMenuItem.Text = "Zork Map...";
            // 
            // Startlocations
            // 
            this.Startlocations.AutoSize = true;
            this.Startlocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startlocations.Location = new System.Drawing.Point(16, 14);
            this.Startlocations.Name = "Startlocations";
            this.Startlocations.Size = new System.Drawing.Size(109, 20);
            this.Startlocations.TabIndex = 1;
            this.Startlocations.Text = "Start Location";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "West of House",
            "North of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing"});
            this.comboBox1.Location = new System.Drawing.Point(20, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Welcome Message :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 80);
            this.textBox1.TabIndex = 4;
            // 
            // WestDropList
            // 
            this.WestDropList.FormattingEnabled = true;
            this.WestDropList.Items.AddRange(new object[] {
            "North of House",
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "                     "});
            this.WestDropList.Location = new System.Drawing.Point(255, 280);
            this.WestDropList.Name = "WestDropList";
            this.WestDropList.Size = new System.Drawing.Size(127, 21);
            this.WestDropList.TabIndex = 7;
            // 
            // EastDropList
            // 
            this.EastDropList.FormattingEnabled = true;
            this.EastDropList.Items.AddRange(new object[] {
            "North of House",
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "                     "});
            this.EastDropList.Location = new System.Drawing.Point(59, 345);
            this.EastDropList.Name = "EastDropList";
            this.EastDropList.Size = new System.Drawing.Size(126, 21);
            this.EastDropList.TabIndex = 6;
            // 
            // SouthDropList
            // 
            this.SouthDropList.FormattingEnabled = true;
            this.SouthDropList.Items.AddRange(new object[] {
            "North of House",
            "West of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "            "});
            this.SouthDropList.Location = new System.Drawing.Point(59, 312);
            this.SouthDropList.Name = "SouthDropList";
            this.SouthDropList.Size = new System.Drawing.Size(127, 21);
            this.SouthDropList.TabIndex = 5;
            // 
            // NorthDropList
            // 
            this.NorthDropList.FormattingEnabled = true;
            this.NorthDropList.Items.AddRange(new object[] {
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "              "});
            this.NorthDropList.Location = new System.Drawing.Point(59, 280);
            this.NorthDropList.Name = "NorthDropList";
            this.NorthDropList.Size = new System.Drawing.Size(127, 21);
            this.NorthDropList.TabIndex = 4;
            // 
            // West
            // 
            this.West.AutoSize = true;
            this.West.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.West.Location = new System.Drawing.Point(203, 278);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(46, 20);
            this.West.TabIndex = 3;
            this.West.Text = "West";
            // 
            // East
            // 
            this.East.AutoSize = true;
            this.East.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.East.Location = new System.Drawing.Point(6, 343);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(42, 20);
            this.East.TabIndex = 2;
            this.East.Text = "East";
            // 
            // South
            // 
            this.South.AutoSize = true;
            this.South.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.South.Location = new System.Drawing.Point(6, 310);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(52, 20);
            this.South.TabIndex = 1;
            this.South.Text = "South";
            // 
            // North
            // 
            this.North.AutoSize = true;
            this.North.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.North.Location = new System.Drawing.Point(6, 278);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(48, 20);
            this.North.TabIndex = 0;
            this.North.Text = "North";
            // 
            // RoomProperties
            // 
            this.RoomProperties.Controls.Add(this.tabPage5);
            this.RoomProperties.Controls.Add(this.tabPage6);
            this.RoomProperties.Location = new System.Drawing.Point(12, 28);
            this.RoomProperties.Name = "RoomProperties";
            this.RoomProperties.SelectedIndex = 0;
            this.RoomProperties.Size = new System.Drawing.Size(418, 606);
            this.RoomProperties.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.RoomsGroup);
            this.tabPage5.Controls.Add(this.RoomProperty);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(410, 580);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Room Properties";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // RoomsGroup
            // 
            this.RoomsGroup.Controls.Add(this.label11);
            this.RoomsGroup.Controls.Add(this.label10);
            this.RoomsGroup.Controls.Add(this.label9);
            this.RoomsGroup.Controls.Add(this.label4);
            this.RoomsGroup.Controls.Add(this.label3);
            this.RoomsGroup.Controls.Add(this.label2);
            this.RoomsGroup.Location = new System.Drawing.Point(8, 446);
            this.RoomsGroup.Name = "RoomsGroup";
            this.RoomsGroup.Size = new System.Drawing.Size(389, 123);
            this.RoomsGroup.TabIndex = 23;
            this.RoomsGroup.TabStop = false;
            this.RoomsGroup.Text = "Rooms in The World";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Forest3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Forest2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Forest1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Behine House";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "South of House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "North of House";
            // 
            // RoomProperty
            // 
            this.RoomProperty.Controls.Add(this.DownDropList);
            this.RoomProperty.Controls.Add(this.UpDropList);
            this.RoomProperty.Controls.Add(this.Down);
            this.RoomProperty.Controls.Add(this.Up);
            this.RoomProperty.Controls.Add(this.WestDropList);
            this.RoomProperty.Controls.Add(this.SelectRoom);
            this.RoomProperty.Controls.Add(this.RoomDescription);
            this.RoomProperty.Controls.Add(this.Neighbors);
            this.RoomProperty.Controls.Add(this.EastDropList);
            this.RoomProperty.Controls.Add(this.DescriptionBox);
            this.RoomProperty.Controls.Add(this.SouthDropList);
            this.RoomProperty.Controls.Add(this.NorthDropList);
            this.RoomProperty.Controls.Add(this.Clear);
            this.RoomProperty.Controls.Add(this.West);
            this.RoomProperty.Controls.Add(this.OK);
            this.RoomProperty.Controls.Add(this.East);
            this.RoomProperty.Controls.Add(this.Add);
            this.RoomProperty.Controls.Add(this.South);
            this.RoomProperty.Controls.Add(this.EditRoomNameText);
            this.RoomProperty.Controls.Add(this.North);
            this.RoomProperty.Controls.Add(this.EditRoomName);
            this.RoomProperty.Controls.Add(this.SelectDropDown);
            this.RoomProperty.Controls.Add(this.Remove);
            this.RoomProperty.Location = new System.Drawing.Point(10, 6);
            this.RoomProperty.Name = "RoomProperty";
            this.RoomProperty.Size = new System.Drawing.Size(393, 424);
            this.RoomProperty.TabIndex = 22;
            this.RoomProperty.TabStop = false;
            this.RoomProperty.Text = "Room Edit";
            // 
            // DownDropList
            // 
            this.DownDropList.FormattingEnabled = true;
            this.DownDropList.Items.AddRange(new object[] {
            "North of House",
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "                     "});
            this.DownDropList.Location = new System.Drawing.Point(255, 345);
            this.DownDropList.Name = "DownDropList";
            this.DownDropList.Size = new System.Drawing.Size(127, 21);
            this.DownDropList.TabIndex = 25;
            // 
            // UpDropList
            // 
            this.UpDropList.FormattingEnabled = true;
            this.UpDropList.Items.AddRange(new object[] {
            "North of House",
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "                     "});
            this.UpDropList.Location = new System.Drawing.Point(255, 312);
            this.UpDropList.Name = "UpDropList";
            this.UpDropList.Size = new System.Drawing.Size(127, 21);
            this.UpDropList.TabIndex = 24;
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Down.Location = new System.Drawing.Point(199, 343);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(50, 20);
            this.Down.TabIndex = 23;
            this.Down.Text = "Down";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up.Location = new System.Drawing.Point(203, 310);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(30, 20);
            this.Up.TabIndex = 22;
            this.Up.Text = "Up";
            // 
            // SelectRoom
            // 
            this.SelectRoom.AutoSize = true;
            this.SelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRoom.Location = new System.Drawing.Point(5, 14);
            this.SelectRoom.Name = "SelectRoom";
            this.SelectRoom.Size = new System.Drawing.Size(101, 20);
            this.SelectRoom.TabIndex = 12;
            this.SelectRoom.Text = "Select Room";
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDescription.Location = new System.Drawing.Point(-3, 110);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(136, 20);
            this.RoomDescription.TabIndex = 19;
            this.RoomDescription.Text = "Room Description";
            // 
            // Neighbors
            // 
            this.Neighbors.AutoSize = true;
            this.Neighbors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neighbors.Location = new System.Drawing.Point(5, 247);
            this.Neighbors.Name = "Neighbors";
            this.Neighbors.Size = new System.Drawing.Size(81, 20);
            this.Neighbors.TabIndex = 21;
            this.Neighbors.Text = "Neighbors";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(1, 141);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(387, 103);
            this.DescriptionBox.TabIndex = 20;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(311, 71);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 26);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(207, 71);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 26);
            this.OK.TabIndex = 17;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1, 71);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 26);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // EditRoomNameText
            // 
            this.EditRoomNameText.Location = new System.Drawing.Point(207, 37);
            this.EditRoomNameText.Multiline = true;
            this.EditRoomNameText.Name = "EditRoomNameText";
            this.EditRoomNameText.Size = new System.Drawing.Size(184, 21);
            this.EditRoomNameText.TabIndex = 16;
            // 
            // EditRoomName
            // 
            this.EditRoomName.AutoSize = true;
            this.EditRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoomName.Location = new System.Drawing.Point(217, 14);
            this.EditRoomName.Name = "EditRoomName";
            this.EditRoomName.Size = new System.Drawing.Size(130, 20);
            this.EditRoomName.TabIndex = 15;
            this.EditRoomName.Text = "Edit Room Name";
            // 
            // SelectDropDown
            // 
            this.SelectDropDown.FormattingEnabled = true;
            this.SelectDropDown.Items.AddRange(new object[] {
            "Sourth of House",
            "Behind House",
            "Forest 1",
            "Forest 2",
            "Forest 3",
            "Clearing",
            "              "});
            this.SelectDropDown.Location = new System.Drawing.Point(1, 37);
            this.SelectDropDown.Name = "SelectDropDown";
            this.SelectDropDown.Size = new System.Drawing.Size(184, 21);
            this.SelectDropDown.TabIndex = 8;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(96, 71);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(89, 26);
            this.Remove.TabIndex = 14;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Roomnumber);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.Startlocations);
            this.tabPage6.Controls.Add(this.comboBox1);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(410, 580);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Project Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Roomnumber
            // 
            this.Roomnumber.Location = new System.Drawing.Point(342, 40);
            this.Roomnumber.Name = "Roomnumber";
            this.Roomnumber.Size = new System.Drawing.Size(44, 20);
            this.Roomnumber.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 240);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 80);
            this.textBox2.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Game Exit Message :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(198, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "Number of Rooms";
            // 
            // FileSpearator
            // 
            this.FileSpearator.Name = "FileSpearator";
            this.FileSpearator.Size = new System.Drawing.Size(199, 6);
            // 
            // ZorkGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 641);
            this.Controls.Add(this.RoomProperties);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkGUI";
            this.Text = "Zork Game Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RoomProperties.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.RoomsGroup.ResumeLayout(false);
            this.RoomsGroup.PerformLayout();
            this.RoomProperty.ResumeLayout(false);
            this.RoomProperty.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roomnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameFile;
        private System.Windows.Forms.ToolStripMenuItem OpenGameFile;
        private System.Windows.Forms.ToolStripMenuItem SaveGameFile;
        private System.Windows.Forms.ToolStripMenuItem SaveGameFileAs;
        private System.Windows.Forms.ToolStripMenuItem HelpTab;
        private System.Windows.Forms.ToolStripMenuItem zorkMapToolStripMenuItem;
        private System.Windows.Forms.Label Startlocations;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.Label West;
        private System.Windows.Forms.Label East;
        private System.Windows.Forms.Label South;
        private System.Windows.Forms.Label North;
        private System.Windows.Forms.ComboBox WestDropList;
        private System.Windows.Forms.ComboBox EastDropList;
        private System.Windows.Forms.ComboBox SouthDropList;
        private System.Windows.Forms.ComboBox NorthDropList;
        private System.Windows.Forms.TabControl RoomProperties;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label EditRoomName;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox SelectDropDown;
        private System.Windows.Forms.Label SelectRoom;
        private System.Windows.Forms.NumericUpDown Roomnumber;
        private System.Windows.Forms.Label Neighbors;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox EditRoomNameText;
        private System.Windows.Forms.GroupBox RoomsGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox RoomProperty;
        private System.Windows.Forms.ComboBox DownDropList;
        private System.Windows.Forms.ComboBox UpDropList;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.ToolStripSeparator FileSpearator;
    }
}

