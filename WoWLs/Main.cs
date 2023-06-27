using WoWLsConsole;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WoWLs {
	public partial class Main : Form {
		private Dictionary<int, StateRecord> _allStates = new BreadthFirstSearch().Run();

		public Main() {
			InitializeComponent();

			board1.StateChanged += this._Board1_StateChanged;
			board2.StateChanged += this._Board2_StateChanged;

			board1.PlayByTheRules(checkBox1.Checked);
			board2.PlayByTheRules(checkBox1.Checked);

			_UpdateLabels();
		}

		private void _Board1_StateChanged(object? sender, EventArgs e) {
			board2.SetBoardState(board1.State, false);
			_UpdateLabels();
		}

		private void _Board2_StateChanged(object? sender, EventArgs e) {
			board1.SetBoardState(board2.State, false);
			_UpdateLabels();
		}

		private void _UpdateLabels(bool updateListBox = true) {
			if (_allStates.ContainsKey(board1.State.ID)) {
				var record = _allStates[board1.State.ID];

				label_status.ForeColor = Color.Black;
				label_status.Text = record.ToString();

				textBox_LoadByHistory.Text = record.CellHistory();

				if (updateListBox) {
					listBox1.ClearSelected();
					listBox1.Items.Clear();
					var temp = record;
					listBox1.Items.Add(temp);
					while (temp.Parent != null) {
						listBox1.Items.Add(temp.Parent);
						temp = temp.Parent;
					}
					listBox1.SetSelected(0, true);
				}
			} else {
				label_status.ForeColor = Color.Red;
				label_status.Text = "Boardstate impossible from Origin";

				textBox_LoadByHistory.Text = "";

				if (updateListBox) {
					listBox1.ClearSelected();
					listBox1.Items.Clear();
				}
			}
			textBox_LoadByID.Text = board1.State.ID.ToString();
		}

		public void LoadState(BoardState state) {
			board1.SetBoardState(state);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			var selected = (StateRecord?)listBox1.SelectedItem;
			if (selected == null) {
				return;
			}

			board1.SetBoardState(selected.State, false);
			board2.SetBoardState(selected.State, false);
		}

		private void button_LoadByID_Click(object sender, EventArgs e) {
			if (int.TryParse(textBox_LoadByID.Text, out int id)) {
				LoadState(new BoardState(id));
			} else {
				label_status.ForeColor = Color.DarkOrange;
				label_status.Text = "No Boardstate by that ID";
			}
		}

		private void button_LoadByHistory_Click(object sender, EventArgs e) {
			string input = textBox_LoadByHistory.Text;

			Queue<int> ids = new();
			foreach (string part in input.Split(" ")) {
				if (part.Trim() == "")
					continue;
				if (int.TryParse(part.Trim(), out int result)) {
					if (result < 1 || result > 25)
						break;
					ids.Enqueue(result - 1);
				} else {
					label_status.ForeColor = Color.DarkOrange;
					label_status.Text = $"Couldn't parse '{part}'.";
					return;
				}
			}
			BoardState temp = BoardState.Origin;

			while (ids.Count > 0) {
				int cell = ids.Dequeue();
				try {
					temp = temp.PressCell(cell);
				} catch {
					//ConsoleWarning($"Cell '{cell + 1}' was inactive. Skipping further history.");
					break;
				}
			}

			LoadState(temp);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			board1.PlayByTheRules(checkBox1.Checked);
			board2.PlayByTheRules(checkBox1.Checked);
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
			int index = listBox1.IndexFromPoint(e.Location);
			if (index != ListBox.NoMatches) {
				_ShowChildrenForm((StateRecord)listBox1.Items[index]);
			}
		}

		ChildBrowser childrenForm;
		private void _ShowChildrenForm(StateRecord state) {
			if (childrenForm == null || childrenForm.IsDisposed) {
				childrenForm = new ChildBrowser(this, _allStates);
			}
			childrenForm.SetState(state);
			childrenForm.Show();
		}

		AdvancedSearch advancedForm;
		private void _ShowAdvancedForm() {
			if (advancedForm == null || advancedForm.IsDisposed) {
				advancedForm = new AdvancedSearch(this, _allStates);
			}
			advancedForm.Show();
		}

		private void button1_Click(object sender, EventArgs e) {
			_ShowAdvancedForm();
		}
	}
}