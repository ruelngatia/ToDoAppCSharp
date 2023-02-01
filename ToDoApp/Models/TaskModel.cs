using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class TaskModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string task { get; set; }
        [Required]
        public DateTime dueDAte { get; set; }

        public bool completed { get; set; }

    }
}
