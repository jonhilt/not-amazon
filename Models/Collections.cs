using System.Collections.Generic;

namespace NotAmazon.Models
{
    public class CollectionModel
    {
        public string Title { get; set; }
        public IEnumerable<CollectionItem> Items { get; set; }
        public string SeeMoreLink { get; set; }

        public class CollectionItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}