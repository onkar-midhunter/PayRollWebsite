namespace PayRollWebsite.Helper
{
    public class PaginationList<T> : List<T>
    {

        public int TotalPages  { get; set; }
        public int PageNumber { get; set; }
        public PaginationList(List<T> items,int count,int pageNumber,int pageSize )
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool IsPreviousPageAvailable => PageNumber > 1;
        public bool IsNextPageAvailable => PageNumber < TotalPages;

        public static PaginationList<T> Create(IList<T>? source,
            int pageNumber,int pageSize)
        {
            var count = source.Count;
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationList<T>(items, count, pageNumber, pageSize);
        }
    }
}
