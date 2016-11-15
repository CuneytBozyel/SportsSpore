using System;

namespace SportsStore.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }

        public int ItemPerOage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get { return (int)Math.Ceiling((decimal)TotalItems / ItemPerOage); } }
    }
}