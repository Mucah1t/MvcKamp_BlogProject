using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

      

        // relation with heading
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set;}  //1 to many

        // relation with writer 
        //? bos gecılebılır
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
