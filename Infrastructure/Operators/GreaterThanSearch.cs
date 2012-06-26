using System;
using System.Linq;
using Core.Operators;

namespace Infrastructure.Operators
{
    public class GreaterThanSearch : ISearch
    {
        public IQueryable<T> Search<T>(IQueryable<T> query, T value) where T : IComparable
        {
            if (query != null)
                query = query.Where(e => e.CompareTo(value) > 0);

            return query;
        }
    }
}