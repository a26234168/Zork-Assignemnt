namespace Zork.Builder
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
            System.Windows.Forms.Label startLocationLabel;
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label selectRoomLabel;
            System.Windows.Forms.Label roomDescriptionLabel;
            System.Windows.Forms.Label neighborsLabel;
            System.Windows.Forms.Label editRoomNameLabel;
            System.Windows.Forms.Label exitMessageLabel;
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileSpearator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLocationDropDown = new System.Windows.Forms.ComboBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startingRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.roomsGroup = new System.Windows.Forms.GroupBox();
            this.currentRoomTextbox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomProperties = new System.Windows.Forms.GroupBox();
            this.downNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.upNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.westNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.southNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.eastNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.northNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editRoomNameText = new System.Windows.Forms.TextBox();
            this.selectDropDown = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.projectSettings = new System.Windows.Forms.TabPage();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            menuStrip = new System.Windows.Forms.MenuStrip();
            newGameFile = new System.Windows.Forms.ToolStripMenuItem();
            openGameFile = new System.Windows.Forms.ToolStripMenuItem();
            saveGameFile = new System.Windows.Forms.ToolStripMenuItem();
            saveGameFileAs = new System.Windows.Forms.ToolStripMenuItem();
            quitFile = new System.Windows.Forms.ToolStripMenuItem();
            startLocationLabel = new System.Windows.Forms.Label();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            selectRoomLabel = new System.Windows.Forms.Label();
            roomDescriptionLabel = new System.Windows.Forms.Label();
            neighborsLabel = new System.Windows.Forms.Label();
            editRoomNameLabel = new System.Windows.Forms.Label();
            exitMessageLabel = new System.Windows.Forms.Label();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.projectTab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.roomsGroup.SuspendLayout();
            this.roomProperties.SuspendLayout();
            this.projectSettings.SuspendLayout();
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
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameFile
            // 
            newGameFile.Name = "newGameFile";
            newGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newGameFile.Size = new System.Drawing.Size(189, 22);
            newGameFile.Text = "&New Game";
            newGameFile.Click += new System.EventHandler(this.newGameFile_Click);
            // 
            // openGameFile
            // 
            openGameFile.Name = "openGameFile";
            openGameFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openGameFile.Size = new System.Drawing.Size(189, 22);
            openGameFile.Text = "&Open Game...";
            openGameFile.Click += new System.EventHandler(this.OpenGameFile_Click);
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
            saveGameFile.Text = "&Save Game";
            saveGameFile.Click += new System.EventHandler(this.SaveGameFile_Click);
            // 
            // saveGameFileAs
            // 
            saveGameFileAs.Name = "saveGameFileAs";
            saveGameFileAs.Size = new System.Drawing.Size(189, 22);
            saveGameFileAs.Text = "Save &As...";
            saveGameFileAs.Click += new System.EventHandler(this.SaveGameFileAs_Click);
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
            quitFile.Click += new System.EventHandler(this.QuitFile_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zorkMapToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // zorkMapToolStripMenuItem
            // 
            this.zorkMapToolStripMenuItem.Name = "zorkMapToolStripMenuItem";
            this.zorkMapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zorkMapToolStripMenuItem.Text = "Zork Map...";
            // 
            // startLocationLabel
            // 
            startLocationLabel.AutoSize = true;
            startLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startLocationLabel.Location = new System.Drawing.Point(16, 14);
            startLocationLabel.Name = "startLocationLabel";
            startLocationLabel.Size = new System.Drawing.Size(109, 20);
            startLocationLabel.TabIndex = 0;
            startLocationLabel.Text = "Start Location";
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            welcomeMessageLabel.Location = new System.Drawing.Point(16, 82);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(152, 20);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome Message :";
            // 
            // selectRoomLabel
            // 
            selectRoomLabel.AutoSize = true;
            selectRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selectRoomLabel.Location = new System.Drawing.Point(5, 14);
            selectRoomLabel.Name = "selectRoomLabel";
            selectRoomLabel.Size = new System.Drawing.Size(101, 20);
            selectRoomLabel.TabIndex = 0;
            selectRoomLabel.Text = "Select Room";
            // 
            // roomDescriptionLabel
            // 
            roomDescriptionLabel.AutoSize = true;
            roomDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomDescriptionLabel.Location = new System.Drawing.Point(4, 107);
            roomDescriptionLabel.Name = "roomDescriptionLabel";
            roomDescriptionLabel.Size = new System.Drawing.Size(136, 20);
            roomDescriptionLabel.TabIndex = 8;
            roomDescriptionLabel.Text = "Room Description";
            // 
            // neighborsLabel
            // 
            neighborsLabel.AutoSize = true;
            neighborsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            neighborsLabel.Location = new System.Drawing.Point(4, 249);
            neighborsLabel.Name = "neighborsLabel";
            neighborsLabel.Size = new System.Drawing.Size(81, 20);
            neighborsLabel.TabIndex = 10;
            neighborsLabel.Text = "Neighbors";
            // 
            // editRoomNameLabel
            // 
            editRoomNameLabel.AutoSize = true;
            editRoomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editRoomNameLabel.Location = new System.Drawing.Point(217, 14);
            editRoomNameLabel.Name = "editRoomNameLabel";
            editRoomNameLabel.Size = new System.Drawing.Size(130, 20);
            editRoomNameLabel.TabIndex = 4;
            editRoomNameLabel.Text = "Edit Room Name";
            // 
            // exitMessageLabel
            // 
            exitMessageLabel.AutoSize = true;
            exitMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exitMessageLabel.Location = new System.Drawing.Point(16, 208);
            exitMessageLabel.Name = "exitMessageLabel";
            exitMessageLabel.Size = new System.Drawing.Size(112, 20);
            exitMessageLabel.TabIndex = 6;
            exitMessageLabel.Text = "Exit Message :";
            // 
            // startLocationDropDown
            // 
            this.startLocationDropDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "StartingLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startLocationDropDown.DataSource = this.startingRoomBindingSource;
            this.startLocationDropDown.DisplayMember = "Name";
            this.startLocationDropDown.FormattingEnabled = true;
            this.startLocationDropDown.Location = new System.Drawing.Point(20, 40);
            this.startLocationDropDown.Name = "startLocationDropDown";
            this.startLocationDropDown.Size = new System.Drawing.Size(151, 21);
            this.startLocationDropDown.TabIndex = 1;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // startingRoomBindingSource
            // 
            this.startingRoomBindingSource.DataMember = "Rooms";
            this.startingRoomBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(20, 114);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(354, 80);
            this.welcomeMessageTextBox.TabIndex = 5;
            // 
            // neighborsBindingSource
            // 
            this.neighborsBindingSource.DataSource = this.roomsBindingSource;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
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
            this.projectTab.TabIndex = 1;
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
            this.roomsGroup.Controls.Add(this.currentRoomTextbox);
            this.roomsGroup.Controls.Add(this.label11);
            this.roomsGroup.Controls.Add(this.label10);
            this.roomsGroup.Controls.Add(this.label9);
            this.roomsGroup.Controls.Add(this.label4);
            this.roomsGroup.Controls.Add(this.label3);
            this.roomsGroup.Controls.Add(this.label2);
            this.roomsGroup.Location = new System.Drawing.Point(3, 398);
            this.roomsGroup.Name = "roomsGroup";
            this.roomsGroup.Size = new System.Drawing.Size(397, 127);
            this.roomsGroup.TabIndex = 1;
            this.roomsGroup.TabStop = false;
            this.roomsGroup.Text = "Rooms in The World";
            // 
            // currentRoomTextbox
            // 
            this.currentRoomTextbox.DataSource = this.roomsBindingSource;
            this.currentRoomTextbox.DisplayMember = "Name";
            this.currentRoomTextbox.FormattingEnabled = true;
            this.currentRoomTextbox.Location = new System.Drawing.Point(7, 17);
            this.currentRoomTextbox.Name = "currentRoomTextbox";
            this.currentRoomTextbox.Size = new System.Drawing.Size(380, 95);
            this.currentRoomTextbox.TabIndex = 6;
            this.currentRoomTextbox.SelectedIndexChanged += new System.EventHandler(this.CurrentRoomTextbox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // roomProperties
            // 
            this.roomProperties.Controls.Add(this.downNeighborsControl);
            this.roomProperties.Controls.Add(this.upNeighborsControl);
            this.roomProperties.Controls.Add(this.westNeighborsControl);
            this.roomProperties.Controls.Add(this.southNeighborsControl);
            this.roomProperties.Controls.Add(this.eastNeighborsControl);
            this.roomProperties.Controls.Add(this.northNeighborsControl);
            this.roomProperties.Controls.Add(selectRoomLabel);
            this.roomProperties.Controls.Add(roomDescriptionLabel);
            this.roomProperties.Controls.Add(neighborsLabel);
            this.roomProperties.Controls.Add(this.roomDescriptionTextBox);
            this.roomProperties.Controls.Add(this.clearButton);
            this.roomProperties.Controls.Add(this.okButton);
            this.roomProperties.Controls.Add(this.addButton);
            this.roomProperties.Controls.Add(this.editRoomNameText);
            this.roomProperties.Controls.Add(editRoomNameLabel);
            this.roomProperties.Controls.Add(this.selectDropDown);
            this.roomProperties.Controls.Add(this.removeButton);
            this.roomProperties.Location = new System.Drawing.Point(3, 6);
            this.roomProperties.Name = "roomProperties";
            this.roomProperties.Size = new System.Drawing.Size(397, 386);
            this.roomProperties.TabIndex = 0;
            this.roomProperties.TabStop = false;
            this.roomProperties.Text = "Room Edit";
            // 
            // downNeighborsControl
            // 
            this.downNeighborsControl.CurrentNeighbor = null;
            this.downNeighborsControl.Location = new System.Drawing.Point(200, 338);
            this.downNeighborsControl.Name = "downNeighborsControl";
            this.downNeighborsControl.NeighborsDirection = Zork.Common.Direction.DOWN;
            this.downNeighborsControl.Room = null;
            this.downNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.downNeighborsControl.TabIndex = 16;
            // 
            // upNeighborsControl
            // 
            this.upNeighborsControl.CurrentNeighbor = null;
            this.upNeighborsControl.Location = new System.Drawing.Point(200, 304);
            this.upNeighborsControl.Name = "upNeighborsControl";
            this.upNeighborsControl.NeighborsDirection = Zork.Common.Direction.UP;
            this.upNeighborsControl.Room = null;
            this.upNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.upNeighborsControl.TabIndex = 15;
            // 
            // westNeighborsControl
            // 
            this.westNeighborsControl.CurrentNeighbor = null;
            this.westNeighborsControl.Location = new System.Drawing.Point(200, 272);
            this.westNeighborsControl.Name = "westNeighborsControl";
            this.westNeighborsControl.NeighborsDirection = Zork.Common.Direction.WEST;
            this.westNeighborsControl.Room = null;
            this.westNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.westNeighborsControl.TabIndex = 14;
            // 
            // southNeighborsControl
            // 
            this.southNeighborsControl.CurrentNeighbor = null;
            this.southNeighborsControl.ForeColor = System.Drawing.Color.DarkGray;
            this.southNeighborsControl.Location = new System.Drawing.Point(5, 338);
            this.southNeighborsControl.Name = "southNeighborsControl";
            this.southNeighborsControl.NeighborsDirection = Zork.Common.Direction.SOUTH;
            this.southNeighborsControl.Room = null;
            this.southNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.southNeighborsControl.TabIndex = 13;
            // 
            // eastNeighborsControl
            // 
            this.eastNeighborsControl.CurrentNeighbor = null;
            this.eastNeighborsControl.Location = new System.Drawing.Point(5, 304);
            this.eastNeighborsControl.Name = "eastNeighborsControl";
            this.eastNeighborsControl.NeighborsDirection = Zork.Common.Direction.EAST;
            this.eastNeighborsControl.Room = null;
            this.eastNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.eastNeighborsControl.TabIndex = 12;
            // 
            // northNeighborsControl
            // 
            this.northNeighborsControl.CurrentNeighbor = null;
            this.northNeighborsControl.Location = new System.Drawing.Point(5, 272);
            this.northNeighborsControl.Name = "northNeighborsControl";
            this.northNeighborsControl.NeighborsDirection = Zork.Common.Direction.NORTH;
            this.northNeighborsControl.Room = null;
            this.northNeighborsControl.Size = new System.Drawing.Size(192, 26);
            this.northNeighborsControl.TabIndex = 11;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(5, 130);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(387, 103);
            this.roomDescriptionTextBox.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(302, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 26);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(207, 71);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 26);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 26);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editRoomNameText
            // 
            this.editRoomNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editRoomNameText.Location = new System.Drawing.Point(207, 37);
            this.editRoomNameText.Multiline = true;
            this.editRoomNameText.Name = "editRoomNameText";
            this.editRoomNameText.Size = new System.Drawing.Size(184, 21);
            this.editRoomNameText.TabIndex = 5;
            this.editRoomNameText.TextChanged += new System.EventHandler(this.EditRoomNameText_TextChanged);
            // 
            // selectDropDown
            // 
            this.selectDropDown.DataSource = this.roomsBindingSource;
            this.selectDropDown.DisplayMember = "Name";
            this.selectDropDown.FormattingEnabled = true;
            this.selectDropDown.Location = new System.Drawing.Point(6, 37);
            this.selectDropDown.Name = "selectDropDown";
            this.selectDropDown.Size = new System.Drawing.Size(184, 21);
            this.selectDropDown.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(101, 71);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 26);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // projectSettings
            // 
            this.projectSettings.Controls.Add(this.exitMessageTextBox);
            this.projectSettings.Controls.Add(exitMessageLabel);
            this.projectSettings.Controls.Add(startLocationLabel);
            this.projectSettings.Controls.Add(this.startLocationDropDown);
            this.projectSettings.Controls.Add(welcomeMessageLabel);
            this.projectSettings.Controls.Add(this.welcomeMessageTextBox);
            this.projectSettings.Location = new System.Drawing.Point(4, 22);
            this.projectSettings.Name = "projectSettings";
            this.projectSettings.Padding = new System.Windows.Forms.Padding(3);
            this.projectSettings.Size = new System.Drawing.Size(419, 524);
            this.projectSettings.TabIndex = 1;
            this.projectSettings.Text = "Project Settings";
            this.projectSettings.UseVisualStyleBackColor = true;
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "ExitMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitMessageTextBox.Location = new System.Drawing.Point(20, 240);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(354, 80);
            this.exitMessageTextBox.TabIndex = 7;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files|*.json";
            this.saveFileDialog.Title = "Save World as";
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
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.projectTab.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.roomsGroup.ResumeLayout(false);
            this.roomsGroup.PerformLayout();
            this.roomProperties.ResumeLayout(false);
            this.roomProperties.PerformLayout();
            this.projectSettings.ResumeLayout(false);
            this.projectSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorkMapToolStripMenuItem;
        private System.Windows.Forms.ComboBox startLocationDropDown;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.TabControl projectTab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage projectSettings;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox selectDropDown;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
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
        private System.Windows.Forms.ToolStripSeparator FileSpearator;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ListBox currentRoomTextbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource neighborsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource startingRoomBindingSource;
        private Controls.NeighborsControl northNeighborsControl;
        private Controls.NeighborsControl downNeighborsControl;
        private Controls.NeighborsControl upNeighborsControl;
        private Controls.NeighborsControl westNeighborsControl;
        private Controls.NeighborsControl southNeighborsControl;
        private Controls.NeighborsControl eastNeighborsControl;
    }
}