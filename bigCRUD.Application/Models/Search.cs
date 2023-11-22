namespace bigCRUD.Application.Models
{
    public class SearchFilter
    {
        public string SearchField { get; set; }
        public string SearchOperator { get; set; }

        public object SearchFor { get; set; }
        public bool IgnoreCase { get; set; } = false;

      
    }
    public class SortBy
    {
        public string sortField { get; set; }
        //asc,des
        public string SortOrder { get; set; }
    }
    public class SearchOptions
    {
        public int Take { get; set; } = 10;
        public int Skip { get; set; } = 0;
        public int PageNumber { get; set; } = 0;
        public List<SearchFilter> Filters { get; set; }
        public SortBy SortBy { get; set; } = new SortBy();

    }




}
