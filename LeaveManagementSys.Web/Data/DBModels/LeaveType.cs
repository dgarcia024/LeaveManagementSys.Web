using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSys.Web.Data.DBModels
{
    public class LeaveType
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Column(TypeName="nvarchar(150)")]
        public string Name { get; set; }
        [DisplayName("Numero de dias")]
        public int NumberOfDays { get; set; }
    }
}
