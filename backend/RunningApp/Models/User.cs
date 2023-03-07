using System.ComponentModel.DataAnnotations.Schema;

namespace RunningApp.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public string? UserName { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
