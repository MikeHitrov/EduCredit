namespace EduCredit.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserCourse
    {
        public UserCourse()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string CourseId { get; set; }

        [Required]
        public Course Course { get; set; }
    }
}
