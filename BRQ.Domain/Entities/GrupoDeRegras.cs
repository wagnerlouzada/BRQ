using System;
using System.Collections.Generic;

namespace BRQ.Domain.Entities
{
    public class GrupoDeRegras
    {
        public int GrupoDeRegrasId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Regra> Regras { get; set; }
        public List<string> Classificacoes { get; set; }
        //public bool GrupoDeRegrasEspecial(GrupoDeRegras grupoDeRegras) => grupoDeRegras.Ativo && DateTime.Now.Year - grupoDeRegras.DataCadastro.Year >= 5;
    }
}
