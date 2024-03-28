using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management.Models
{
    public partial class Publisher
    {
        [MetadataType(typeof(PublisherMetaData))]
        public class PublisherMetaData
        {
            [ScaffoldColumn(false)]
            public int PublisherId { get; set; }
            [DisplayName("Publisher Name")]
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
        }
    }
}