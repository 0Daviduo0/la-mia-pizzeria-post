using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static
{
    public class PizzeList
    {
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Il valore deve essere maggiore di zero")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(25, ErrorMessage = "Il nome non può avere più di 25 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Descr { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public decimal Price { get; set; }

        public PizzeList()
        {
        }

        public PizzeList(string nome, string descr, string img, decimal price, int id)
        {
            Id = id;
            Nome = nome;
            Descr = descr;
            Img = img;
            Price = price;
        }
    }
}
