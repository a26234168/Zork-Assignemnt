﻿namespace Zork.Builder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.ToolStripMenuItem newGameFile;
            System.Windows.Forms.ToolStripMenuItem openGameFile;
            System.Windows.Forms.ToolStripMenuItem saveGameFile;
            System.Windows.Forms.ToolStripMenuItem saveGameFileAs;
            System.Windows.Forms.ToolStripMenuItem quitFile;
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileSpearator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLocationLabel = new System.Windows.Forms.Label();
            this.startLocationDropDown = new System.Windows.Forms.ComboBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.WestDropList = new System.Windows.Forms.ComboBox();
            this.EastDropList = new System.Windows.Forms.ComboBox();
            this.SouthDropList = new System.Windows.Forms.ComboBox();
            this.NorthDropList = new System.Windows.Forms.ComboBox();
            this.westLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.northLabel = new System.Windows.Forms.Label();
            this.projectTab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.roomsGroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomProperties = new System.Windows.Forms.GroupBox();
            this.DownDropList = new System.Windows.Forms.ComboBox();
            this.UpDropList = new System.Windows.Forms.ComboBox();
            this.downLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.selectRoomLabel = new System.Windows.Forms.Label();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.neighborsLabel = new System.Windows.Forms.Label();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editRoomNameText = new System.Windows.Forms.TextBox();
            this.editRoomNameLabel = new System.Windows.Forms.Label();
            this.selectDropDown = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.projectSettings = new System.Windows.Forms.TabPage();
            this.numberRoomsTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.numberRoomsLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            menuStrip = new System.Windows.Forms.MenuStrip();
            newGameFile = new System.Windows.Forms.ToolStripMenuItem();
            openGameFile = new System.Windows.Forms.ToolStripMenuItem();
            saveGameFile = new System.Windows.Forms.ToolStripMenuItem();
            saveGameFileAs = new System.Windows.Forms.ToolStripMenuItem();
            quitFile = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip.SuspendLayout();
            this.projectTab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.roomsGroup.SuspendLayout();
            this.roomProperties.SuspendLayout();
            this.projectSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(427, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newGameFile,
            openGameFile,
            this.menuSeparator,
            saveGameFile,
            saveGameFileAs,
            this.FileSpearator,
            quitFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameFile
            // 
            newGameFile.Name = "newGameFile";
            newGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newGameFile.Size = new System.Drawing.Size(189, 22);
            newGameFile.Text = "&New Game";
            // 
            // openGameFile
            // 
            openGameFile.Name = "openGameFile";
            openGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openGameFile.Size = new System.Drawing.Size(189, 22);
            openGameFile.Text = "&Open Game...";
            openGameFile.Click += new System.EventHandler(this.openGameFile_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(186, 6);
            // 
            // saveGameFile
            // 
            saveGameFile.Name = "saveGameFile";
            saveGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveGameFile.Size = new System.Drawing.Size(189, 22);
            saveGameFile.Text = "Save Game";
            // 
            // saveGameFileAs
            // 
            saveGameFileAs.Name = "saveGameFileAs";
            saveGameFileAs.Size = new System.Drawing.Size(189, 22);
            saveGameFileAs.Text = "Save As...";
            // 
            // FileSpearator
            // 
            this.FileSpearator.Name = "FileSpearator";
            this.FileSpearator.Size = new System.Drawing.Size(186, 6);
            // 
            // quitFile
            // 
            quitFile.Name = "quitFile";
            quitFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            quitFile.Size = new System.Drawing.Size(189, 22);
            quitFile.Text = "&Quit";
            quitFile.Click += new System.EventHandler(this.quitFile_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zorkMapToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // zorkMapToolStripMenuItem
            // 
            this.zorkMapToolStripMenuItem.Name = "zorkMapToolStripMenuItem";
            this.zorkMapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zorkMapToolStripMenuItem.Text = "Zork Map...";
            // 
            // startLocationLabel
            // 
            this.startLocationLabel.AutoSize = true;
            this.startLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLocationLabel.Location = new System.Drawing.Point(16, 14);
            this.startLocationLabel.Name = "startLocationLabel";
            this.startLocationLabel.Size = new System.Drawing.Size(109, 20);
            this.startLocationLabel.TabIndex = 1;
            this.startLocationLabel.Text = "Start Location";
            // 
            // startLocationDropDown
            // 
            this.startLocationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startLocationDropDown.FormattingEnabled = true;
            this.startLocationDropDown.Location = new System.Drawing.Point(20, 40);
            this.startLocationDropDown.Name = "startLocationDropDown";
            this.startLocationDropDown.Size = new System.Drawing.Size(151, 21);
            this.startLocationDropDown.TabIndex = 2;
            this.startLocationDropDown.ValueMember = "Rooms";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageLabel.Location = new System.Drawing.Point(16, 82);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(152, 20);
            this.welcomeMessageLabel.TabIndex = 3;
            this.welcomeMessageLabel.Text = "Welcome Message :";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(20, 114);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(354, 80);
            this.welcomeMessageTextBox.TabIndex = 4;
            // 
            // WestDropList
            // 
            this.WestDropList.FormattingEnabled = true;
            this.WestDropList.Location = new System.Drawing.Point(255, 280);
            this.WestDropList.Name = "WestDropList";
            this.WestDropList.Size = new System.Drawing.Size(127, 21);
            this.WestDropList.TabIndex = 7;
            this.WestDropList.ValueMember = "Description";
            // 
            // EastDropList
            // 
            this.EastDropList.FormattingEnabled = true;
            this.EastDropList.Location = new System.Drawing.Point(59, 345);
            this.EastDropList.Name = "EastDropList";
            this.EastDropList.Size = new System.Drawing.Size(126, 21);
            this.EastDropList.TabIndex = 6;
            this.EastDropList.ValueMember = "Description";
            // 
            // SouthDropList
            // 
            this.SouthDropList.FormattingEnabled = true;
            this.SouthDropList.Location = new System.Drawing.Point(59, 312);
            this.SouthDropList.Name = "SouthDropList";
            this.SouthDropList.Size = new System.Drawing.Size(127, 21);
            this.SouthDropList.TabIndex = 5;
            this.SouthDropList.ValueMember = "Description";
            // 
            // NorthDropList
            // 
            this.NorthDropList.FormattingEnabled = true;
            this.NorthDropList.Location = new System.Drawing.Point(59, 280);
            this.NorthDropList.Name = "NorthDropList";
            this.NorthDropList.Size = new System.Drawing.Size(127, 21);
            this.NorthDropList.TabIndex = 4;
            this.NorthDropList.ValueMember = "Description";
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.westLabel.Location = new System.Drawing.Point(203, 278);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(46, 20);
            this.westLabel.TabIndex = 3;
            this.westLabel.Text = "West";
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eastLabel.Location = new System.Drawing.Point(6, 343);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(42, 20);
            this.eastLabel.TabIndex = 2;
            this.eastLabel.Text = "East";
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southLabel.Location = new System.Drawing.Point(6, 310);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(52, 20);
            this.southLabel.TabIndex = 1;
            this.southLabel.Text = "South";
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northLabel.Location = new System.Drawing.Point(6, 278);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(48, 20);
            this.northLabel.TabIndex = 0;
            this.northLabel.Text = "North";
            // 
            // projectTab
            // 
            this.projectTab.Controls.Add(this.tabPage5);
            this.projectTab.Controls.Add(this.projectSettings);
            this.projectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTab.Location = new System.Drawing.Point(0, 24);
            this.projectTab.Name = "projectTab";
            this.projectTab.SelectedIndex = 0;
            this.projectTab.Size = new System.Drawing.Size(427, 550);
            this.projectTab.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.roomsGroup);
            this.tabPage5.Controls.Add(this.roomProperties);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(419, 524);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Room Properties";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // roomsGroup
            // 
            this.roomsGroup.Controls.Add(this.label11);
            this.roomsGroup.Controls.Add(this.label10);
            this.roomsGroup.Controls.Add(this.label9);
            this.roomsGroup.Controls.Add(this.label4);
            this.roomsGroup.Controls.Add(this.label3);
            this.roomsGroup.Controls.Add(this.label2);
            this.roomsGroup.Location = new System.Drawing.Point(3, 398);
            this.roomsGroup.Name = "roomsGroup";
            this.roomsGroup.Size = new System.Drawing.Size(410, 123);
            this.roomsGroup.TabIndex = 23;
            this.roomsGroup.TabStop = false;
            this.roomsGroup.Text = "Rooms in The World";
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
            // roomProperties
            // 
            this.roomProperties.Controls.Add(this.DownDropList);
            this.roomProperties.Controls.Add(this.UpDropList);
            this.roomProperties.Controls.Add(this.downLabel);
            this.roomProperties.Controls.Add(this.upLabel);
            this.roomProperties.Controls.Add(this.WestDropList);
            this.roomProperties.Controls.Add(this.selectRoomLabel);
            this.roomProperties.Controls.Add(this.roomDescriptionLabel);
            this.roomProperties.Controls.Add(this.neighborsLabel);
            this.roomProperties.Controls.Add(this.EastDropList);
            this.roomProperties.Controls.Add(this.roomDescriptionTextBox);
            this.roomProperties.Controls.Add(this.SouthDropList);
            this.roomProperties.Controls.Add(this.NorthDropList);
            this.roomProperties.Controls.Add(this.clearButton);
            this.roomProperties.Controls.Add(this.westLabel);
            this.roomProperties.Controls.Add(this.okButton);
            this.roomProperties.Controls.Add(this.eastLabel);
            this.roomProperties.Controls.Add(this.addButton);
            this.roomProperties.Controls.Add(this.southLabel);
            this.roomProperties.Controls.Add(this.editRoomNameText);
            this.roomProperties.Controls.Add(this.northLabel);
            this.roomProperties.Controls.Add(this.editRoomNameLabel);
            this.roomProperties.Controls.Add(this.selectDropDown);
            this.roomProperties.Controls.Add(this.removeButton);
            this.roomProperties.Location = new System.Drawing.Point(3, 6);
            this.roomProperties.Name = "roomProperties";
            this.roomProperties.Size = new System.Drawing.Size(474, 386);
            this.roomProperties.TabIndex = 22;
            this.roomProperties.TabStop = false;
            this.roomProperties.Text = "Room Edit";
            // 
            // DownDropList
            // 
            this.DownDropList.FormattingEnabled = true;
            this.DownDropList.Location = new System.Drawing.Point(255, 345);
            this.DownDropList.Name = "DownDropList";
            this.DownDropList.Size = new System.Drawing.Size(127, 21);
            this.DownDropList.TabIndex = 25;
            this.DownDropList.ValueMember = "Description";
            // 
            // UpDropList
            // 
            this.UpDropList.FormattingEnabled = true;
            this.UpDropList.Location = new System.Drawing.Point(255, 312);
            this.UpDropList.Name = "UpDropList";
            this.UpDropList.Size = new System.Drawing.Size(127, 21);
            this.UpDropList.TabIndex = 24;
            this.UpDropList.ValueMember = "Description";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLabel.Location = new System.Drawing.Point(199, 343);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(50, 20);
            this.downLabel.TabIndex = 23;
            this.downLabel.Text = "Down";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLabel.Location = new System.Drawing.Point(203, 310);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(30, 20);
            this.upLabel.TabIndex = 22;
            this.upLabel.Text = "Up";
            // 
            // selectRoomLabel
            // 
            this.selectRoomLabel.AutoSize = true;
            this.selectRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomLabel.Location = new System.Drawing.Point(5, 14);
            this.selectRoomLabel.Name = "selectRoomLabel";
            this.selectRoomLabel.Size = new System.Drawing.Size(101, 20);
            this.selectRoomLabel.TabIndex = 12;
            this.selectRoomLabel.Text = "Select Room";
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescriptionLabel.Location = new System.Drawing.Point(3, 109);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(136, 20);
            this.roomDescriptionLabel.TabIndex = 19;
            this.roomDescriptionLabel.Text = "Room Description";
            // 
            // neighborsLabel
            // 
            this.neighborsLabel.AutoSize = true;
            this.neighborsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neighborsLabel.Location = new System.Drawing.Point(5, 247);
            this.neighborsLabel.Name = "neighborsLabel";
            this.neighborsLabel.Size = new System.Drawing.Size(81, 20);
            this.neighborsLabel.TabIndex = 21;
            this.neighborsLabel.Text = "Neighbors";
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(6, 141);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(387, 103);
            this.roomDescriptionTextBox.TabIndex = 20;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(311, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 26);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(207, 71);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 26);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 26);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "&Add...";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editRoomNameText
            // 
            this.editRoomNameText.Location = new System.Drawing.Point(207, 37);
            this.editRoomNameText.Multiline = true;
            this.editRoomNameText.Name = "editRoomNameText";
            this.editRoomNameText.Size = new System.Drawing.Size(184, 21);
            this.editRoomNameText.TabIndex = 16;
            // 
            // editRoomNameLabel
            // 
            this.editRoomNameLabel.AutoSize = true;
            this.editRoomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomNameLabel.Location = new System.Drawing.Point(217, 14);
            this.editRoomNameLabel.Name = "editRoomNameLabel";
            this.editRoomNameLabel.Size = new System.Drawing.Size(130, 20);
            this.editRoomNameLabel.TabIndex = 15;
            this.editRoomNameLabel.Text = "Edit Room Name";
            // 
            // selectDropDown
            // 
            this.selectDropDown.DataSource = this.roomsBindingSource;
            this.selectDropDown.DisplayMember = "Name";
            this.selectDropDown.FormattingEnabled = true;
            this.selectDropDown.Location = new System.Drawing.Point(6, 37);
            this.selectDropDown.Name = "selectDropDown";
            this.selectDropDown.Size = new System.Drawing.Size(184, 21);
            this.selectDropDown.TabIndex = 8;
            this.selectDropDown.ValueMember = "Description";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(96, 71);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 26);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // projectSettings
            // 
            this.projectSettings.Controls.Add(this.numberRoomsTextBox);
            this.projectSettings.Controls.Add(this.exitMessageTextBox);
            this.projectSettings.Controls.Add(this.exitMessageLabel);
            this.projectSettings.Controls.Add(this.numberRoomsLabel);
            this.projectSettings.Controls.Add(this.startLocationLabel);
            this.projectSettings.Controls.Add(this.startLocationDropDown);
            this.projectSettings.Controls.Add(this.welcomeMessageLabel);
            this.projectSettings.Controls.Add(this.welcomeMessageTextBox);
            this.projectSettings.Location = new System.Drawing.Point(4, 22);
            this.projectSettings.Name = "projectSettings";
            this.projectSettings.Padding = new System.Windows.Forms.Padding(3);
            this.projectSettings.Size = new System.Drawing.Size(419, 524);
            this.projectSettings.TabIndex = 1;
            this.projectSettings.Text = "Project Settings";
            this.projectSettings.UseVisualStyleBackColor = true;
            // 
            // numberRoomsTextBox
            // 
            this.numberRoomsTextBox.Location = new System.Drawing.Point(342, 41);
            this.numberRoomsTextBox.Name = "numberRoomsTextBox";
            this.numberRoomsTextBox.Size = new System.Drawing.Size(44, 20);
            this.numberRoomsTextBox.TabIndex = 8;
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.Location = new System.Drawing.Point(20, 240);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(354, 80);
            this.exitMessageTextBox.TabIndex = 6;
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMessageLabel.Location = new System.Drawing.Point(16, 208);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(112, 20);
            this.exitMessageLabel.TabIndex = 5;
            this.exitMessageLabel.Text = "Exit Message :";
            // 
            // numberRoomsLabel
            // 
            this.numberRoomsLabel.AutoSize = true;
            this.numberRoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRoomsLabel.Location = new System.Drawing.Point(198, 41);
            this.numberRoomsLabel.Name = "numberRoomsLabel";
            this.numberRoomsLabel.Size = new System.Drawing.Size(138, 20);
            this.numberRoomsLabel.TabIndex = 3;
            this.numberRoomsLabel.Text = "Number of Rooms";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Common.Room);
            // 
            // ZorkGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 574);
            this.Controls.Add(this.projectTab);
            this.Controls.Add(menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip;
            this.MaximizeBox = false;
            this.Name = "ZorkGUI";
            this.Text = "Zork Game Editor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            this.projectTab.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.roomsGroup.ResumeLayout(false);
            this.roomsGroup.PerformLayout();
            this.roomProperties.ResumeLayout(false);
            this.roomProperties.PerformLayout();
            this.projectSettings.ResumeLayout(false);
            this.projectSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorkMapToolStripMenuItem;
        private System.Windows.Forms.Label startLocationLabel;
        private System.Windows.Forms.ComboBox startLocationDropDown;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.ComboBox WestDropList;
        private System.Windows.Forms.ComboBox EastDropList;
        private System.Windows.Forms.ComboBox SouthDropList;
        private System.Windows.Forms.ComboBox NorthDropList;
        private System.Windows.Forms.TabControl projectTab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage projectSettings;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.Label numberRoomsLabel;
        private System.Windows.Forms.Label editRoomNameLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox selectDropDown;
        private System.Windows.Forms.Label selectRoomLabel;
        private System.Windows.Forms.Label neighborsLabel;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox editRoomNameText;
        private System.Windows.Forms.GroupBox roomsGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox roomProperties;
        private System.Windows.Forms.ComboBox DownDropList;
        private System.Windows.Forms.ComboBox UpDropList;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.ToolStripSeparator FileSpearator;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.TextBox numberRoomsTextBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

