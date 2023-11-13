using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.Extensions
{
    public static class IEnumerableExtension
    {
        private const int defaultCurrentPage = 1;
        private const int defaultPageSize = 10; 
        public static PaginatedListResponse<T> ToPaginationsList<T>(this IEnumerable<T> source,
            int currentPage,
            int pageSize) where T : class
        {
            currentPage = currentPage > 0 ?  currentPage : defaultCurrentPage;
            pageSize = pageSize > 0 ? pageSize : defaultPageSize; 
            int totalItems = source.Count();
            var Items = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedListResponse<T>(Items, totalItems, currentPage, pageSize);
        }
    }
}
