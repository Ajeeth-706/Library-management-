//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public string Contents { get; set; }
        public Nullable<int> Pages { get; set; }
        public string Edition { get; set; }
    
        public virtual author author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}
