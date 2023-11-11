namespace SyosecAdvent.Application.Common
{
    public class PaginatedListResponse<T> where T : class
    {
        public int? CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }

        public List<T> Result { get; set; } = new();

        public PaginatedListResponse(IEnumerable<T> items, int count, int? currentPage= 1, int? pageSize=15)
        {
            Result.AddRange(items);
            CurrentPage = currentPage; 
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
            TotalItems = count;
        }
    }
}
