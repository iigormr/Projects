﻿using System.ComponentModel.DataAnnotations;

namespace CNPJ.Models.Empresa
{
    public class AtividadePrincipal
    {
        public AtividadePrincipal(string text, string code)
        {
            this.text = text;
            this.code = code;
        }

        public int id { get; set; }
        [StringLength(200)]
        [Display(Name = "Nome")]
        public string text { get; set; }
        [StringLength(100)]
        [Display(Name = "Código")]
        public string code { get; set; }
        public int empresaId { get; set; }
        public virtual global::Empresa.Models.Empresa.Empresa Empresa { get; set; }
    }
}
