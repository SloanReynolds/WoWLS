namespace WoWLs {
	partial class ChildBrowser {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label_ParentState = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(12, 42);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(280, 559);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// board1
			// 
			this.board1.IsWildFire = false;
			this.board1.Location = new System.Drawing.Point(298, 33);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Child browser for:";
			// 
			// label_ParentState
			// 
			this.label_ParentState.AutoSize = true;
			this.label_ParentState.Location = new System.Drawing.Point(12, 24);
			this.label_ParentState.Name = "label_ParentState";
			this.label_ParentState.Size = new System.Drawing.Size(103, 15);
			this.label_ParentState.TabIndex = 4;
			this.label_ParentState.Text = "5 | 12345678 | 1 2 3";
			// 
			// ChildBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 613);
			this.Controls.Add(this.label_ParentState);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.board2);
			this.Controls.Add(this.board1);
			this.Controls.Add(this.listBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ChildBrowser";
			this.Text = "Child Browser";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildBrowser_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox listBox1;
		private Board board1;
		private Board board2;
		private Label label1;
		private Label label_ParentState;
	}
}