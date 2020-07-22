namespace CNPJ.Models.Empresa
{
    public class Extra
    {
        public int id { get; set; }
        public virtual global::Empresa.Models.Empresa.Empresa Empresa { get; set; }
    }
}