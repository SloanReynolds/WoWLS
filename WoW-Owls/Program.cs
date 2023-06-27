// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using WoWLsConsole;

Console.WriteLine("Origin Board:");

Console.WriteLine(BoardState.Origin.Display());

Dictionary<int, StateRecord> allStates = new BreadthFirstSearch().Run();

while (true) {
	Console.WriteLine();
	Console.ForegroundColor = ConsoleColor.Gray;
	Console.WriteLine("X = Exit | I = Boardstate by ID | L = Boardstate by Active Cells | H = Boardstate by History");
	Console.ForegroundColor = ConsoleColor.White;

	ConsoleKey key = Console.ReadKey().Key;
	Console.WriteLine();
	if (key == ConsoleKey.X) {
		break;
	} else if (key == ConsoleKey.H) {
		Console.WriteLine("Enter History (eg '8 12 14 18'):");
		_SubBoardStateByHistory();
	} else if (key == ConsoleKey.L) {
		Console.WriteLine("Enter Boardstate Active Cell List (eg '1 20 24'):");
		_SubBoardStateByList();
	} else if (key == ConsoleKey.I) {
		Console.WriteLine("Enter Boardstate ID:");
		_SubBoardStateByID();
	}
}

void _SubBoardStateByID() {
	string input = Console.ReadLine();

	if (int.TryParse(input, out int result)) {
		PrintBoardStateByID(result);
	} else {
		ConsoleError($"Couldn't parse '{input}' as an ID.");
		return;
	}
}

void _SubBoardStateByList() {
	string input = Console.ReadLine();

	List<int> ids = new();
	foreach (string part in input.Split(" ")) {
		if (part.Trim() == "")
			continue;
		if (int.TryParse(part.Trim(), out int result)) {
			if (result < 1 || result > 25)
				ConsoleError($"Specified Cell '{part}' doesn't exist.");
			ids.Add(result - 1);
		} else {
			ConsoleWarning($"Couldn't parse '{part}'. Excluded from list.");
		}
	}
	BoardState temp = new BoardState(ids.ToArray());

	PrintBoardStateByID(temp.ID);
}



void _SubBoardStateByHistory() {
	string input = Console.ReadLine();

	Queue<int> ids = new();
	foreach (string part in input.Split(" ")) {
		if (part.Trim() == "")
			continue;
		if (int.TryParse(part.Trim(), out int result)) {
			if (result < 1 || result > 25)
				throw new Exception("Cell out of range");
			ids.Enqueue(result - 1);
		} else {
			ConsoleError($"Couldn't parse '{part}'.");
			return;
		}
	}
	BoardState temp = BoardState.Origin;

	while (ids.Count > 0) {
		int cell = ids.Dequeue();
		try {
			temp = temp.PressCell(cell);
		} catch {
			ConsoleWarning($"Cell '{cell+1}' was inactive. Skipping further history.");
			break;
		}
	}

	PrintBoardStateByID(temp.ID);
}

void PrintBoardStateByID(int id) {
	if (allStates.TryGetValue(id, out StateRecord record)) {
		Console.WriteLine(record.State.Display());
		StateRecord parent = record.Parent;
		Console.WriteLine("State History:");
		record.Report();
		while (parent != null) {
			parent.Report();
			parent = parent.Parent;
		}
	} else {
		ConsoleError("Boardstate impossible from Origin");
	}
}

void ConsoleWarning(string msg) {
	ConsoleColor prev = Console.ForegroundColor;
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("Warning: " + msg);
	Console.ForegroundColor = prev;
}

void ConsoleError(string msg) {
	ConsoleColor prev = Console.ForegroundColor;
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Error: " + msg);
	Console.ForegroundColor = prev;
}