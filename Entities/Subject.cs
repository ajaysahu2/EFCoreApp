using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subject
    {
        [Column("SubjectId")]
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
