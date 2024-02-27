using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentDetails
    {
        [Column("StudentDetailsId")]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }

        public Guid StudentID {  get; set; }
        public Student Student { get; set; }
    }
}
