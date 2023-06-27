using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WoWLsConsole {
	public class BreadthFirstSearch {
		private bool[] _discoveredBool = new bool[33554432];
		private int _discoveredCount = 0;

		private Dictionary<int, StateRecord> _nodes = new Dictionary<int, StateRecord>();

		public Dictionary<int, StateRecord> Run() {
			Queue<StateRecord> stateQueue = new Queue<StateRecord>();

			StateRecord rootNode = StateRecord.Origin;
			_Discover(rootNode);
			stateQueue.Enqueue(rootNode);

			while (stateQueue.Count > 0) {
				StateRecord node = stateQueue.Dequeue();
				node.Report(false);

				BoardState state = node.State;
				foreach (int cell in state.ActiveCells()) {
					BoardState newState = state.PressCell(cell);
					if (!_IsDiscovered(newState.ID)) {
						StateRecord newNode = new StateRecord(newState, node, cell);
						_Discover(newNode);
						stateQueue.Enqueue(newNode);
					}
				}
			}

			Console.WriteLine(_discoveredCount + " Total states discovered");
			return _nodes;
		}

		private void _Discover(StateRecord node) {
			_nodes.Add(node.State.ID, node);
			_discoveredBool[node.State.ID] = true;
			_discoveredCount++;
		}

		private bool _IsDiscovered(int cell) {
			return _discoveredBool[cell];
		}
	}
}
