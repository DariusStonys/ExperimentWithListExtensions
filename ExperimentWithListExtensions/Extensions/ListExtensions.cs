namespace ExperimentWithListExtensions
{
    public static class ListExtensions
    {
        public static List<Game> SortByDate(this List<Game> Statistics)
        {
            return Statistics.OrderBy(s => s.GameTime).ToList();
        }
    }
}