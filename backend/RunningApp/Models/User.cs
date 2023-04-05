using System.ComponentModel.DataAnnotations.Schema;

namespace RunningApp.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
      
        public int? Age { get; set; }

        public User(int? id, string? userName, string? email, string? firstName, string? lastName, int? age)
        {
            Id = id;
            UserName = userName;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public User()
        {

        }
    }
}
