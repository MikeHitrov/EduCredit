namespace EduCredit.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserCourses = new HashSet<UserCourse>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; }

        public ICollection<UserCourse> UserCourses { get; set; }
    }
}
