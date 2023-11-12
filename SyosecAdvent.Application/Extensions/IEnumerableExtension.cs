using SyosecAdvent.Application.Common;

namespace SyosecAdvent.Application.Extensions
{
    public static class IEnumerableExtension
    {
        public static PaginatedListResponse<T> ToPaginationsList<T>(this IEnumerable<T> source,
            int currentPage,
            int pageSize) where T : class
        {
            int totalItems = source.Count();
            var Items = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedListResponse<T>(Items, totalItems, currentPage, pageSize);
        }
    }
}
