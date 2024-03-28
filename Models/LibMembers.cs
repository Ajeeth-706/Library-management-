using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_Management.Models
{
    public partial class Members
    {
        [MetadataType(typeof(MemberMetaData))]
        public class MemberMetaData 
        {
            public int MemberId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}