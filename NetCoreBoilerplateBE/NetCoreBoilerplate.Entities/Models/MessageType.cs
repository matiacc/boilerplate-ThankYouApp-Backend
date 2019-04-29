using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreBoilerplate.Entities.Models
{
    public class MessageType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MessageTypeId { get; set; }

        public string Name { get; set; }
    }
}