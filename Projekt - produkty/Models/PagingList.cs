using System;
using System.Collections.Generic;

namespace Projekt___produkty.Models
{
    public class PagingList<T>
    {
        public IEnumerable<T> Data { get; }
        public int TotalItems { get; }
        public int TotalPages { get; }
        public int PageNumber { get; }
        public int Size { get; }
        public bool IsFirst { get; }
        public bool IsLast { get; }
        public bool IsNext { get; }
        public bool IsPrevious { get; }

        private PagingList(IEnumerable<T> data, int totalItems, int pageNumber, int size)
        {
            Data = data;
            TotalItems = totalItems;
            PageNumber = pageNumber;
            Size = size;
            TotalPages = (int)Math.Ceiling((double)TotalItems / Size);
            IsFirst = pageNumber <= 1;
            IsLast = pageNumber >= TotalPages;
            IsNext = !IsLast;
            IsPrevious = !IsFirst;
        }

        public static PagingList<T> Create(IEnumerable<T> data, int totalItems, int pageNumber, int size)
        {
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
            else if (pageNumber > (int)Math.Ceiling((double)totalItems / size))
            {
                pageNumber = (int)Math.Ceiling((double)totalItems / size);
            }

            return new PagingList<T>(data, totalItems, pageNumber, size);
        }
    }
}
