using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management.Models
{
    public partial class Book
    {
        [MetadataType(typeof(BookMetaData))]
        public class BookMetaData
        {
            public int BookId { get; set; }
            [DisplayName("Book Name")]
            public string BookName { get; set; }

            public Nullable<int> AuthorId { get; set; }
            public Nullable<int> CategoryId { get; set; }
            public Nullable<int> PublisherId { get; set; }
            public string Contents { get; set; }
            public Nullable<int> Pages { get; set; }
            public string Edition { get; set; }

        }
    }
}