using System.ComponentModel.DataAnnotations;

namespace CNPJ.Models.Empresa
{
    public class Socio
    {
        public Socio(string qual, string qual_rep_legal, string nome_rep_legal, string nome)
        {
            this.qual = qual;
            this.qual_rep_legal = qual_rep_legal;
            this.nome_rep_legal = nome_rep_legal;
            this.nome = nome;
        }
        public int id { get; set; }
        [Display(Name = "Nível Hierárquico")]
        public string qual { get; set; }
        [Display(Name = "Nível Representante Legal")]
        public string qual_rep_legal { get; set; }
        [Display(Name = "Nome Representante Legal")]
        public string nome_rep_legal { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; }
        public int empresaId { get; set; }

        public virtual global::Empresa.Models.Empresa.Empresa Empresa { get; set; }
    }
}