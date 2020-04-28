namespace EduCredit.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public Course()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserCourses = new HashSet<UserCourse>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime CourseBeginning { get; set; }

        [Required]
        public DateTime CourseEnding { get; set; }

        [Required]
        public int Credits { get; set; }

        public ICollection<UserCourse> UserCourses { get; set; }
    }
}
