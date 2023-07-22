using System;

namespace LibraryManagementSystem.Models {
    public class BookModel {
        public string Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime PublishedAt { get; set; }
        public string PublisherName { get; set; }
        public string Volume { get; set; }
    }
}
