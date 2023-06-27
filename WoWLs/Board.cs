using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWLsConsole;

namespace WoWLs {

	public partial class Board : UserControl {
		private readonly Color COLOR_OFF = Color.OrangeRed;
		private readonly Color COLOR_ON = Color.LimeGreen;

		private BoardState _state = BoardState.Origin;
		private Label[] _c;
		private Label[] _cellMap;
		private bool _isWildFire = false;
		private bool _playByTheRules = true;

		[Browsable(true)]
		public bool IsWildFire {
			get => _isWildFire;
			set => _UpdateWildFire(value);
		}

		public BoardState State => _state;

		public delegate void EventHandler(object? sender, EventArgs e);
		public event EventHandler? StateChanged;

		public Board() {
			InitializeComponent();

			_c = new Label[] {
				cell0, cell1, cell2, cell3, cell4,
				cell5, cell6, cell7, cell8, cell9,
				cell10, cell11, cell12, cell13, cell14,
				cell15, cell16, cell17, cell18, cell19,
				cell20, cell21, cell22, cell23, cell24
			};
			for (int i = 0; i < _c.Length; i++) {
				_c[i].Click += this._Cell_Click;
			}

			_UpdateCellMap();
		}

		public void PlayByTheRules(bool doIt) {
			_playByTheRules = doIt;
		}

		private void _Cell_Click(object? sender, EventArgs e) {
			for (int i = 0; i < _c.Length; i++) {
				var cell = _cellMap[i];
				if (cell == sender) {
					SetBoardState(_playByTheRules ? _state.PressCell(i) : _state.FlipCell(i));

					return;
				}
			}
			throw new Exception("Label Not Found");
		}

		private void _UpdateCellMap() {
			if (_isWildFire) {
				_cellMap = new Label[] {
					_c[0], _c[1], _c[7], _c[8], _c[4],
					_c[5], _c[6], _c[12], _c[13], _c[9],
					_c[10], _c[11], _c[17], _c[18], _c[14],
					_c[15], _c[16], _c[22], _c[23], _c[19],
					_c[20], _c[21], _c[24], _c[2], _c[3],
				};
			} else {
				_cellMap = new Label[] {
					_c[0], _c[1], _c[2], _c[3], _c[4],
					_c[5], _c[6], _c[7], _c[8], _c[9],
					_c[10], _c[11], _c[12], _c[13], _c[14],
					_c[15], _c[16], _c[17], _c[18], _c[19],
					_c[20], _c[21], _c[22], _c[23], _c[24],
				};
			}
			SetBoardState(_state);
		}

		private void _UpdateWildFire(bool val) {
			_isWildFire = val;
			_UpdateCellMap();
		}

		public void SetBoardState(BoardState state, bool triggerStateChange = true) {
			bool[] barr = state.AsBoolArray();
			for (int i = 0; i < barr.Length; i++) {
				_cellMap[i].BackColor = barr[i] ? COLOR_ON : COLOR_OFF;
			}
			_state = state;
			if (triggerStateChange) StateChanged?.Invoke(this, new EventArgs());
		}
	}
}
