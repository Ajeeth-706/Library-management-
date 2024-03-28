using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management.Models
{
    
    public partial class author
    {
        [MetadataType(typeof(AuthorMetaData))]
        public class AuthorMetaData
        {
            //[ScaffoldColumn(false)]
            public int Id { get; set; }
            [DisplayName("Author Name")]
            public string Name { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            public string Nationality { get; set; }
        }

    }
}