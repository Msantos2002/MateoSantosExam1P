using System.ComponentModel.DataAnnotations;

namespace MateoSantosExam1P.Models
{
    public class MS_Cerveza
    {
        public int  MS_CervezaId { get; set; }
        [Required]
        public string? MS_CervezaName { get; set; }
        public string? MS_CervezaDescription { get; set; }
        public bool MS_Escarchada { get; set; }
        [Range  (0.01, 20.5)]
        public decimal MS_Price { get; set; }
        public DateTime? MS_Date { get; set; }   


    }
}