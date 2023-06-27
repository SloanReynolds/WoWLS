namespace WoWLs {
	partial class AdvancedSearch {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.board1 = new WoWLs.Board();
			this.board2 = new WoWLs.Board();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.input_CellCount = new System.Windows.Forms.TextBox();
			this.input_Depth = new System.Windows.Forms.TextBox();
			this.label_statesCount = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(12, 162);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(280, 439);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// board1
			// 
			this.board1.IsWildFire = false;
			this.board1.Location = new System.Drawing.Point(298, 3);
			this.board1.Name = "board1";
			this.board1.Size = new System.Drawing.Size(256, 256);
			this.board1.TabIndex = 1;
			// 
			// board2
			// 
			this.board2.IsWildFire = true;
			this.board2.Location = new System.Drawing.Point(298, 354);
			this.board2.Name = "board2";
			this.board2.Size = new System.Drawing.Size(256, 256);
			this.board2.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_statesCount);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.input_CellCount);
			this.groupBox1.Controls.Add(this.input_Depth);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 153);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "State Depth";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Active Cell Count";
			// 
			// input_CellCount
			// 
			this.input_CellCount.Location = new System.Drawing.Point(111, 22);
			this.input_CellCount.MaxLength = 2;
			this.input_CellCount.Name = "input_CellCount";
			this.input_CellCount.Size = new System.Drawing.Size(37, 23);
			this.input_CellCount.TabIndex = 0;
			this.input_CellCount.TextChanged += new System.EventHandler(this.textbox_NumberValidate);
			// 
			// input_Depth
			// 
			this.input_Depth.Location = new System.Drawing.Point(80, 51);
			this.input_Depth.MaxLength = 2;
			this.input_Depth.Name = "input_Depth";
			this.input_Depth.Size = new System.Drawing.Size(37, 23);
			this.input_Depth.TabIndex = 0;
			this.input_Depth.TextChanged += new System.EventHandler(this.textbox_NumberValidate);
			// 
			// label_statesCount
			// 
			this.label_statesCount.AutoSize = true;
			this.label_statesCount.Location = new System.Drawing.Point(6, 128);
			this.label_statesCount.Name = "label_statesCount";
			this.label_statesCount.Size = new System.Drawing.Size(53, 15);
			this.label_statesCount.TabIndex = 3;
			this.label_statesCount.Text = "10 States";
			// 
			// AdvancedSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 613);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.board2);
			this.Controls.Add(this.board1);
			this.Controls.Add(this.listBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AdvancedSearch";
			this.Text = "Advanced Search";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedSearch_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox listBox1;
		private Board board1;
		private Board board2;
		private GroupBox groupBox1;
		private Label label1;
		private TextBox input_Depth;
		private Button button1;
		private Label label2;
		private TextBox input_CellCount;
		private Label label_statesCount;
	}
}