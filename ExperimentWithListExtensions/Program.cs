using ExperimentWithListExtensions.Models;

namespace ExperimentWithListExtensions
{
	public static class LetsTryToCreatListWithExtensions
	{
		static void Main()
		{
			var statistics = new GameList();

			var game1 = new Game()
			{
				GameTime = DateTime.Now,
				MoveNumber = 0,
				GameStatus = "Victory"
			};

			var game2 = new Game()
			{
				GameTime = DateTime.MinValue,
				MoveNumber = 1,
				GameStatus = "Loss"
			};

			statistics.Add(game1);
			statistics.Add(game2);

			var sortedStatisticsList = statistics.SortByDate();
		}
	}
}