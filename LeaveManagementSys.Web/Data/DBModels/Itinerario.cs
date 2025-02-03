using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSys.Web.Data.DBModels
{
    public class Itinerario
    {
        [Key]
        public int ItenerarioId { get; set; }

        [DisplayName("Nombre usuario")]
        [MaxLength(10)]
        public required string CurrentUser { get; set; }

        [MaxLength(100)]
        [DisplayName("Lugar")]
        public string? CurrentLocation { get; set; }
        [DisplayName("Fecha y Hora")]
        public required DateTime CurrentDate { get; set; }

    }
}
