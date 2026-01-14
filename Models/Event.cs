using System.ComponentModel.DataAnnotations;

namespace EtkinlikSistemi.Models;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Etkinlik adı şart!")]
    [Display(Name = "Etkinlik Adı")]
    public string Name { get; set; }

    [Display(Name = "Mekan")]
    public string Location { get; set; }

    [Display(Name = "Tarih")]
    public DateTime EventDate { get; set; }

    [Display(Name = "Kapasite")]
    public int Capacity { get; set; }
}