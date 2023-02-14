using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618

namespace CarServiceLibrary.Models.Entities;

public class Cars
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Наименование машины.
    /// </summary>
    [Required(ErrorMessage = "Поле не может быть пустым!")]
    public string CarName { get; set; }

    /// <summary>
    /// Изображение марки машины.
    /// </summary>
    public string CarImage { get; set; }
}