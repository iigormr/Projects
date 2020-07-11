using System.ComponentModel.DataAnnotations;

namespace CNPJ.Models.Empresa
{
    public class AtividadesSecundarias
    {
        public AtividadesSecundarias(string text, string code)
        {
            this.text = text;
            this.code = code;
        }

        [Display(Name = "Nome")]
        public string text { get; set; }
        [Display(Name = "Código")]
        public string code { get; set; }
    }
}