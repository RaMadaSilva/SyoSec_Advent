namespace SyosecAdvent.Application.Common
{
    public class PaginatedListResponse<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }

        public IEnumerable<T> Result { get; set; } = Enumerable.Empty<T>();

        public PaginatedListResponse(IEnumerable<T> items, int count, int currentPage= 1, int pageSize=15)
        {
            Result = items;
            CurrentPage = CurrentPage; 
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
            TotalItems = count;
        }
    }
}
