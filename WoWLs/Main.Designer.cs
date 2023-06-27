namespace WoWLs {
	partial class Main {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.board1 = new WoWLs.Board();
			this.board2 = new WoWLs.Board();
			this.label_status = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_LoadByID = new System.Windows.Forms.Button();
			this.textBox_LoadByID = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBox_LoadByHistory = new System.Windows.Forms.TextBox();
			this.button_LoadByHistory = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// board1
			// 
			this.board1.IsWildFire = false;
			this.board1.Location = new System.Drawing.Point(12, 12);
			this.board1.Name = "board1";
			this.board1.Size = new System.Drawing.Size(256, 256);
			this.board1.TabIndex = 0;
			// 
			// board2
			// 
			this.board2.IsWildFire = true;
			this.board2.Location = new System.Drawing.Point(539, 12);
			this.board2.Name = "board2";
			this.board2.Size = new System.Drawing.Size(256, 256);
			this.board2.TabIndex = 0;
			// 
			// label_status
			// 
			this.label_status.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label_status.Location = new System.Drawing.Point(0, 0);
			this.label_status.Margin = new System.Windows.Forms.Padding(0);
			this.label_status.Name = "label_status";
			this.label_status.Size = new System.Drawing.Size(259, 15);
			this.label_status.TabIndex = 0;
			this.label_status.Text = "BaordState Blansdf";
			this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label_status);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.listBox1);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(274, 21);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 238);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.button_LoadByID);
			this.panel1.Controls.Add(this.textBox_LoadByID);
			this.panel1.Location = new System.Drawing.Point(0, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 29);
			this.panel1.TabIndex = 1;
			// 
			// button_LoadByID
			// 
			this.button_LoadByID.Location = new System.Drawing.Point(181, 2);
			this.button_LoadByID.Name = "button_LoadByID";
			this.button_LoadByID.Size = new System.Drawing.Size(75, 23);
			this.button_LoadByID.TabIndex = 1;
			this.button_LoadByID.Text = "Load ID";
			this.button_LoadByID.UseVisualStyleBackColor = true;
			this.button_LoadByID.Click += new System.EventHandler(this.button_LoadByID_Click);
			// 
			// textBox_LoadByID
			// 
			this.textBox_LoadByID.Location = new System.Drawing.Point(3, 3);
			this.textBox_LoadByID.Name = "textBox_LoadByID";
			this.textBox_LoadByID.Size = new System.Drawing.Size(172, 23);
			this.textBox_LoadByID.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.textBox_LoadByHistory);
			this.flowLayoutPanel2.Controls.Add(this.button_LoadByHistory);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 44);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(259, 29);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// textBox_LoadByHistory
			// 
			this.textBox_LoadByHistory.Location = new System.Drawing.Point(3, 3);
			this.textBox_LoadByHistory.Name = "textBox_LoadByHistory";
			this.textBox_LoadByHistory.Size = new System.Drawing.Size(172, 23);
			this.textBox_LoadByHistory.TabIndex = 0;
			// 
			// button_LoadByHistory
			// 
			this.button_LoadByHistory.Location = new System.Drawing.Point(181, 3);
			this.button_LoadByHistory.Name = "button_LoadByHistory";
			this.button_LoadByHistory.Size = new System.Drawing.Size(75, 23);
			this.button_LoadByHistory.TabIndex = 1;
			this.button_LoadByHistory.Text = "History";
			this.button_LoadByHistory.UseVisualStyleBackColor = true;
			this.button_LoadByHistory.Click += new System.EventHandler(this.button_LoadByHistory_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(0, 73);
			this.listBox1.Margin = new System.Windows.Forms.Padding(0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(259, 109);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(253, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Advanced Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(0, 211);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(259, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Play by the Rules";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 268);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.board2);
			this.Controls.Add(this.board1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Board board1;
		private Board board2;
		private Label label_status;
		private FlowLayoutPanel flowLayoutPanel1;
		private Panel panel1;
		private Button button_LoadByID;
		private TextBox textBox_LoadByID;
		private FlowLayoutPanel flowLayoutPanel2;
		private TextBox textBox_LoadByHistory;
		private Button button_LoadByHistory;
		private ListBox listBox1;
		private CheckBox checkBox1;
		private Button button1;
	}
}