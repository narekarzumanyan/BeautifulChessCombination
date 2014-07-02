using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Chess
{
	/// <summary>
	/// Summary description for ChessMain.
	/// </summary>
	public class ChessMain : System.Windows.Forms.Form
    {
        #region privateelements
        private GameUI GameObj;		// The Game UI object
		public System.Windows.Forms.Label BlackPlayerTime;
        public System.Windows.Forms.ListView lstHistory;
        
		private System.Windows.Forms.MainMenu MainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem mnuNewGame;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuItem14;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem mnuEditUndoMove;
		private System.Windows.Forms.MenuItem mnuEditRedoMove;
		private System.Windows.Forms.MenuItem mnuEditShowLog;
        private System.Windows.Forms.MenuItem mnuShowLog;
		private System.Windows.Forms.ColumnHeader LstIndex;
        private System.Windows.Forms.ColumnHeader lstMove;
        private MenuItem mnuSaveGame;
        private MenuItem mnuLoadGame;
        private ColumnHeader LegalMovesCount;
        private Button button2;
        private Button button1;
        public Label label5;
        public Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public ListView listView1;
        public Label label6;
        private ColumnHeader columnHeader1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
		private System.Windows.Forms.MenuItem mnuShowMoveHelp;
        #endregion privateelements

        public ChessMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessMain));
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuLoadGame = new System.Windows.Forms.MenuItem();
            this.mnuSaveGame = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuEditShowLog = new System.Windows.Forms.MenuItem();
            this.mnuEditUndoMove = new System.Windows.Forms.MenuItem();
            this.mnuEditRedoMove = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.mnuShowLog = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.mnuShowMoveHelp = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.LstIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LegalMovesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlackPlayerTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuEditShowLog});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewGame,
            this.mnuLoadGame,
            this.mnuSaveGame,
            this.menuItem9,
            this.mnuFileExit});
            this.menuItem1.Text = "Մենյու";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 0;
            this.mnuNewGame.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNewGame.Text = "Նոր խաղ";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuLoadGame
            // 
            this.mnuLoadGame.Index = 1;
            this.mnuLoadGame.Text = "Բեռնել խաղը";
            this.mnuLoadGame.Click += new System.EventHandler(this.mnuLoadGame_Click);
            // 
            // mnuSaveGame
            // 
            this.mnuSaveGame.Enabled = false;
            this.mnuSaveGame.Index = 2;
            this.mnuSaveGame.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSaveGame.Text = "Պահպանել խաղը";
            this.mnuSaveGame.Click += new System.EventHandler(this.mnuSaveGame_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 4;
            this.mnuFileExit.Text = "Դուրս գալ";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEditShowLog
            // 
            this.mnuEditShowLog.Index = 1;
            this.mnuEditShowLog.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditUndoMove,
            this.mnuEditRedoMove,
            this.menuItem11,
            this.mnuShowLog,
            this.menuItem14,
            this.mnuShowMoveHelp});
            this.mnuEditShowLog.Text = "Խմբագրել";
            // 
            // mnuEditUndoMove
            // 
            this.mnuEditUndoMove.Index = 0;
            this.mnuEditUndoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.mnuEditUndoMove.Text = "Հետ";
            this.mnuEditUndoMove.Click += new System.EventHandler(this.mnuEditUndoMove_Click);
            // 
            // mnuEditRedoMove
            // 
            this.mnuEditRedoMove.Index = 1;
            this.mnuEditRedoMove.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.mnuEditRedoMove.Text = "Առաջ";
            this.mnuEditRedoMove.Click += new System.EventHandler(this.mnuEditRedoMove_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "-";
            // 
            // mnuShowLog
            // 
            this.mnuShowLog.Checked = true;
            this.mnuShowLog.Index = 3;
            this.mnuShowLog.Text = "Ցուցադրել քայլերը";
            this.mnuShowLog.Click += new System.EventHandler(this.mnuShowLog_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 4;
            this.menuItem14.Text = "-";
            // 
            // mnuShowMoveHelp
            // 
            this.mnuShowMoveHelp.Index = 5;
            this.mnuShowMoveHelp.Text = "Ցուցադրել հնարավոր խաղերը";
            this.mnuShowMoveHelp.Click += new System.EventHandler(this.mnuShowMoveHelp_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = -1;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = -1;
            this.menuItem6.Text = "";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = -1;
            this.menuItem7.Text = "";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = -1;
            this.menuItem8.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lstHistory);
            this.panel1.Controls.Add(this.BlackPlayerTime);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(507, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 515);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "∆V(R)-ի փոփոխությունը\r\n յուրաքանչյուր քայլին";
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(8, 119);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(190, 144);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "∆V(R)=";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Սև";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Սպիտակ";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(94, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Առաջ >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.AllowColumnReorder = true;
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LstIndex,
            this.lstMove,
            this.LegalMovesCount});
            this.lstHistory.GridLines = true;
            this.lstHistory.HideSelection = false;
            this.lstHistory.LabelEdit = true;
            this.lstHistory.Location = new System.Drawing.Point(8, 263);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(0);
            this.lstHistory.MultiSelect = false;
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(190, 216);
            this.lstHistory.TabIndex = 6;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            // 
            // LstIndex
            // 
            this.LstIndex.Text = "No.";
            this.LstIndex.Width = 35;
            // 
            // lstMove
            // 
            this.lstMove.Text = "Քայլ";
            this.lstMove.Width = 90;
            // 
            // BlackPlayerTime
            // 
            this.BlackPlayerTime.AutoEllipsis = true;
            this.BlackPlayerTime.BackColor = System.Drawing.Color.White;
            this.BlackPlayerTime.Font = new System.Drawing.Font("Verdana", 8.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackPlayerTime.ForeColor = System.Drawing.Color.Black;
            this.BlackPlayerTime.Location = new System.Drawing.Point(73, 9);
            this.BlackPlayerTime.Name = "BlackPlayerTime";
            this.BlackPlayerTime.Size = new System.Drawing.Size(125, 25);
            this.BlackPlayerTime.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "<< Հետ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(272, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "E";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(215, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(161, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(106, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(51, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(440, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "H";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(383, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "G";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(327, 476);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "F";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(8, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "8";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(9, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(9, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.Location = new System.Drawing.Point(10, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.Location = new System.Drawing.Point(11, 281);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.Location = new System.Drawing.Point(12, 336);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(12, 388);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
            this.label22.Location = new System.Drawing.Point(12, 439);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "1";
            // 
            // ChessMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 509);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.MainMenu;
            this.Name = "ChessMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChessMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new ChessMain());
		}

        /// <summary>
        /// Enable the Save Menu
        /// </summary>
        public void EnableSaveMenu()
        {
            mnuSaveGame.Enabled = true;
        }

      
		// Chess board load event. Initialize all the chess positions
		private void ChessMain_Load(object sender, System.EventArgs e)
		{
            this.listView1.ResetText();
			GameObj = new GameUI(this);
			this.mnuShowMoveHelp.Checked = GameObj.ShowMoveHelp;	// Show the check box
		}

		// Menu Handler
		private void mnuNewGame_Click(object sender, System.EventArgs e)
		{
            this.listView1.ResetText();
			GameObj.NewGame();	// Initialize the new game
           
           

		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();		// Send the terminate signal to all running threads
		}

        private void mnuShowMoveHelp_Click(object sender, System.EventArgs e)
        {
            GameObj.ShowMoveHelp = !GameObj.ShowMoveHelp;	// Reverse the show help check box state
            this.mnuShowMoveHelp.Checked = GameObj.ShowMoveHelp;	// Show the check box
        }

     

		private void mnuEditUndoMove_Click(object sender, System.EventArgs e)
		{
			if (GameObj.IsRunning)	// game is in active state
			{
				GameObj.UndoMove();
			}		
		}

		private void mnuEditRedoMove_Click(object sender, System.EventArgs e)
		{
			if (GameObj.IsRunning)	// game is in active state
			{
				GameObj.RedoMove();
			}			
		}

		private void mnuShowLog_Click(object sender, System.EventArgs e)
		{
			mnuShowLog.Checked = !mnuShowLog.Checked;

			if (mnuShowLog.Checked)	// Need to show the log
			{
				this.Width +=190;
				this.Height +=96;
			}
			else
			{
				this.Width -=190;
				this.Height -=96;
			}
		}

	

       
      

        private void mnuSaveGame_Click(object sender, EventArgs e)
        {
            // Save the game state
            GameObj.SaveGame();
        }

        private void mnuLoadGame_Click(object sender, EventArgs e)
        {
            GameObj.LoadGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameObj.IsRunning)	// game is in active state
            {
                GameObj.UndoMove();
            }	
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GameObj.IsRunning)	// game is in active state
            {
                GameObj.RedoMove();
            }		
        }

      

     

      
	}
}
