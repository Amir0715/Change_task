using System.ComponentModel.DataAnnotations;

namespace ATM_Blazor.Models;

public class CassetModel : ICloneable
{
    public int id { get; set; }

    [Required]
    public int nominal { get; set; }
    [Required]
    [Range(0, Int32.MaxValue, ErrorMessage = "Кол-во купюр должно быть >= 0")]
    public int countBanknotes { get; set; }
    [Range(typeof(bool), "true", "true")]
    public bool faulty { get; set; } = false;

    public object Clone()
    {
        return new CassetModel
        {
            id = this.id,
            nominal = this.nominal,
            faulty = this.faulty,
            countBanknotes = this.countBanknotes
        };
    }
}