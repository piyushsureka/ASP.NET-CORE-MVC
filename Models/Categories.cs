using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace QuickKartCoreMVCApp.Models
{
    public class Categories
    {
        [DisplayName("CategoryId")]
        public Nullable<byte> CategoryId { get; set; }
        [DisplayName("CategoryName")]
        public string CategoryName { get; set; }
    }
}
