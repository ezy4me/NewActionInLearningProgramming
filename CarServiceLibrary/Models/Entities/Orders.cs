using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618

namespace CarServiceLibrary.Models.Entities;

public class Orders
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int UserId { get; set; }
    
    public virtual Users? Users { get; set; }
    
    public int ServiceId { get; set; }
    
    public virtual Services Services { get; set; }
    
    [Required(ErrorMessage = "Поле не может быть пустым!")]
    public string? UserName { get; set; }
    
    public int StatusId { get; set; }
    
    public virtual Statuses Statuses { get; set; }

    public int CarId { get; set; }
    
    public virtual Cars Cars { get; set; }
    
    [Required(ErrorMessage = "Поле не может быть пустым!")]
    public string? CarModelName { get; set; }
    
    public string DateOrder { get; set; } = DateTime.Now.ToShortDateString();
}
