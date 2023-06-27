using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWLsConsole {
	public struct BoardState {
		public static BoardState Origin = new BoardState(0, 4, 7, 11, 12, 13, 17, 20, 24);

		private int _state = -1;
		public int ID => _state;

		public BoardState(int ID) {
			_state = ID;
		}

		public BoardState(params int[] onCells) {
			_state = 0;
			foreach (int cell in onCells) {
				if (cell < 0 || cell > 24)
					throw new Exception("Invalid cell");
				_state |= 1 << cell;
			}
		}

		public IEnumerable<int> ActiveCells() {
			int state = _state;
			int cell = 0;
			while (state != 0) {
				if ((state & 1) == 1) {
					yield return cell;
				}
				state >>= 1;
				cell++;
			}
		}

		private bool IsCellActive(int cell) {
			return (_state & (1 << cell)) > 0;
		}

		private List<int> _ToActiveCells() {
			List<int> cells = new List<int>();
			foreach (int cell in ActiveCells()) {
				cells.Add(cell);
			}
			return cells;
		}

		public bool[] AsBoolArray() {
			bool[] cells = new bool[25];
			foreach (int cell in ActiveCells()) {
				cells[cell] = true;
			}

			return cells;
		}

		public string Display() {
			bool[] c = AsBoolArray();
			string ret = "+---+---+---+---+---+\n";
			for (int i = 0; i <= 4; i++) {
				ret += "|";
				for (int j = 0; j <= 4; j++) {
					ret += $" {(c[i * 5 + j] ? 1 : " ")} |";
				}
				ret += "\n";
				ret += "+---+---+---+---+---+\n";
			}

			return ret;
		}

		public BoardState FlipCell(int cell) {
			List<int> cells = _ToActiveCells();
			_FlipCell(cells, cell);
			return new BoardState(cells.ToArray());
		}

		public BoardState PressCell(int cell) {
			List<int> cells = _ToActiveCells();

			_FlipCell(cells, cell);

			_FlipCell(cells, cell + (cell % 5 == 0 ? 4 : -1)); //Left
			_FlipCell(cells, cell + (cell % 5 == 4 ? -4 : 1)); //Right
			_FlipCell(cells, cell + (cell < 5 ? 20 : -5)); //Up
			_FlipCell(cells, cell + (cell > 19 ? -20 : 5)); //Down

			return new BoardState(cells.ToArray());
		}

		private void _FlipCell(List<int> cells, int cell) {
			if (cells.Contains(cell)) {
				cells.Remove(cell);
			} else {
				cells.Add(cell);
			}
		}

		internal int CountActiveCells() {
			int count = 0;
			foreach (int cell in ActiveCells()) {
				count++;
			}
			return count;
		}
	}
}
