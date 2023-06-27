using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWLsConsole;

namespace WoWLs {
	public partial class AdvancedSearch : Form {
		private Main _parent;
		private readonly IList<StateRecord> _allStates;
		private StateRecord _state;
		private IList<StateRecord> _loadedStates;

		public AdvancedSearch(Main parent, Dictionary<int, StateRecord> allStates) {
			InitializeComponent();

			_parent = parent;
			_allStates = allStates.Values.ToList();

			_LoadStates(_allStates);
		}

		private void _RunSearch(int count, int depth) {
			if (count < 0 && depth < 0) {
				if (_loadedStates != _allStates)
					_LoadStates(_allStates);
				return;
			}
			var filtered = _allStates.Where(st => {
				return (count > 0 ? st.CellCount == count : true) && (depth > 0 ? st.Depth == depth : true);
			});

			if (filtered.Any()) {
				_LoadStates(filtered.ToList());
			}
		}

		private void _LoadStates(IList<StateRecord> states) {
			Cursor prev = Cursor.Current;
			this.Cursor = Cursors.WaitCursor;

			listBox1.ClearSelected();
			listBox1.Items.Clear();
			_loadedStates = states;

			int minDepth = states.Select(st => st.Depth).Min();

			foreach (var state in states) {
				listBox1.Items.Add(state.ToString());
			};

			label_statesCount.Text = listBox1.Items.Count + " States";

			this.Cursor = prev;
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
			int index = listBox1.IndexFromPoint(e.Location);
			if (index != ListBox.NoMatches) {
				_LoadStateInParent(_loadedStates[index]);
				this.Hide();
			}
		}

		private void _LoadStateInParent(StateRecord state) {
			_parent.LoadState(state.State);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex > _loadedStates.Count)
				return;

			var selected = _loadedStates[listBox1.SelectedIndex];
			if (selected == null) {
				return;
			}

			board1.SetBoardState(selected.State, false);
			board2.SetBoardState(selected.State, false);
		}

		private void textbox_NumberValidate(object sender, EventArgs e) {
			TextBox textbox = (TextBox)sender;
			if (textbox.Text.Length <= 0 ) {
				return;
			}
			if (!char.IsNumber(textbox.Text.Last())) {
				textbox.Text = textbox.Text.Trim(textbox.Text.Last());
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			if (!int.TryParse(input_CellCount.Text, out int count)) {
				count = -1;
			}
			if (!int.TryParse(input_Depth.Text, out int depth)) {
				depth = -1;
			}

			_RunSearch(count, depth);
		}

		private void AdvancedSearch_FormClosing(object sender, FormClosingEventArgs e) {
			this.Hide();
			e.Cancel = true;
		}

		internal bool HasNoState() {
			if (_state == null)
				return true;
			return false;
		}
	}
}
