namespace WebApp
{
	public class SearchData
	{
		public string Name { get; set; } = "";
		public Dictionary<string, bool> EducFormVals { get; set; }
		public int MinScore { get; set; } = 0;
		public int MaxScore { get; set; } = 400;
		public int BudgetPlaces { get; set; } = 0;
		public int ContractPlaces { get; set; } = 0;
		public int MinCost { get; set; } = 0;
		public int MaxCost { get; set; } = 300000;
		public Dictionary<int, int> SortTypesSet { get; set; }
	}
}
