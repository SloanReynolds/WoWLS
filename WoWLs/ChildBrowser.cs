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
	public partial class ChildBrowser : Form {
		private Main _parent;
		private Dictionary<int, StateRecord> _allStates;
		private StateRecord _state;
		private List<StateRecord> _childrenStates;

		public ChildBrowser(Main parent, Dictionary<int, StateRecord> allStates) {
			InitializeComponent();
			
			_parent = parent;
			_allStates = allStates;
		}

		public void SetState(StateRecord state) {
			_state = state;
			
			_childrenStates = new List<StateRecord>();
			listBox1.ClearSelected();
			listBox1.Items.Clear();

			label_ParentState.Text = state.ToString();

			_AddChildrenOf(state, listBox1);
		}

		private void _AddChildrenOf(StateRecord state, ListBox listBox1, int depth = 0, string padding = "") {
			foreach (int cell in state.State.ActiveCells()) {
				BoardState newState = state.State.PressCell(cell);
				StateRecord child = _allStates.Values.First(st => st.State.ID == newState.ID);

				listBox1.Items.Add(padding + child);
				_childrenStates.Add(child);

				if (depth < 1) {
					_AddChildrenOf(child, listBox1, depth + 1, padding + "  ");
				}
			}
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
			int index = listBox1.IndexFromPoint(e.Location);
			if (index != ListBox.NoMatches) {
				_LoadStateInParent(_childrenStates[index]);
				this.Hide();
			}
		}

		private void _LoadStateInParent(StateRecord state) {
			_parent.LoadState(state.State);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex > _childrenStates.Count)
				return;

			var selected = _childrenStates[listBox1.SelectedIndex];
			if (selected == null) {
				return;
			}

			board1.SetBoardState(selected.State, false);
			board2.SetBoardState(selected.State, false);
		}

		private void ChildBrowser_FormClosing(object sender, FormClosingEventArgs e) {
			this.Hide();
			e.Cancel = true;
		}
	}
}
