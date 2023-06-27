namespace WoWLsConsole {
	public class StateRecord {
		public static readonly StateRecord Origin = new StateRecord(BoardState.Origin);

		public readonly BoardState State;
		public readonly StateRecord Parent = null;
		public int CellCount => _cellCount <= 0 ? _cellCount = State.CountActiveCells() : _cellCount;
		public int Depth => _depth;

		private readonly int _depth = 0;
		private readonly int _triggeredCell = -1;
		private int _cellCount = -1;

		public StateRecord(BoardState state) {
			State = state;
		}

		public StateRecord(BoardState state, StateRecord parent, int triggeredCell) : this(state) {
			Parent = parent;
			_depth = parent._depth + 1;
			_triggeredCell = triggeredCell;
		}

		internal void Report(bool force = true) {
			if (force) {
				Console.WriteLine(this.ToString());
			}
		}

		public string ToString(int paddingBaseDepth) {
			string str = $"{_depth} | {State.ID} | {CellHistory()}";
			for (int i = paddingBaseDepth; i < _depth; i++) {
				str = "  " + str;
			}
			return str;
		}

		public override string ToString() {
			return $"{_depth} | {State.ID} | {CellHistory()}";
		}

		public string CellHistory() {
			if (Parent == null)
				return "";

			if (Parent.Parent == null)
				return (_triggeredCell + 1).ToString();

			return Parent.CellHistory() + " " + (_triggeredCell + 1);
		}
	}
}
