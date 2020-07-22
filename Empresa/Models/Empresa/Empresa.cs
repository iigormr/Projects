using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CNPJ.Models.Empresa;

namespace Empresa.Models.Empresa
{
    public class Empresa
    {
        [Key] 
        public int id { get; set; }
        [StringLength(20)]
        public string data_situacao { get; set; }
        public List<AtividadePrincipal> atividade_principal { get; set; }
        public List<AtividadesSecundarias> atividades_secundarias { get; set; }
        public List<Socio> qsa { get; set; }
        [StringLength(100)]
        public string complemento { get; set; }
        [StringLength(250)]
        public string nome { get; set; }
        [StringLength(2)]
        public string uf { get; set; }
        [StringLength(11)]
        public string telefone { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        [StringLength(100)]
        public string situacao { get; set; }
        [StringLength(100)]
        public string bairro { get; set; }
        [StringLength(200)]
        public string logradouro { get; set; }
        [StringLength(15)]
        public string numero { get; set; }
        [StringLength(10)]
        public string cep { get; set; }
        [StringLength(150)]
        public string municipio { get; set; }
        [StringLength(150)]
        public string porte { get; set; }
        [StringLength(100)]
        public string abertura { get; set; }
        [StringLength(150)]
        public string natureza_juridica { get; set; }
        [StringLength(14)]
        public string cnpj { get; set; }
        public DateTime ultima_atualizacao { get; set; }
        [StringLength(10)]
        public string tipo { get; set; }
        [StringLength(200)]
        public string fantasia { get; set; }
        [StringLength(20)]
        public string efr { get; set; }
        [StringLength(150)]
        public string motivo_situacao { get; set; }
        [StringLength(100)]
        public string data_situacao_especial { get; set; }
        [StringLength(100)]
        public string capital_social { get; set; }

        public int extraid { get; set; }
        [ForeignKey("extraid")] 
        public virtual Extra extra { get; set; }

        public int billingid { get; set; }
        [ForeignKey("billingid")]
        public virtual Billings billings { get; set; }
    }
}
