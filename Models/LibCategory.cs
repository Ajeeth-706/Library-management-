using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management.Models
{
    public partial class Category
    {
        [MetadataType(typeof(CategoryMetaData))]
        public class CategoryMetaData
        {
            [ScaffoldColumn(false)]
            public int CategoryId { get; set; }
            [DisplayName("Category Name")]
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}