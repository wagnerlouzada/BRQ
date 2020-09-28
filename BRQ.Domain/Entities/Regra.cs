namespace BRQ.Domain.Entities
{
    public class Regra
    {
        public int RegraId { get; set; }
        public string ClientSector { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public string Risk { get; set; }
        public bool Ativo { get; set; }
        public int GrupoDeRegrasId { get; set; }
        public virtual GrupoDeRegras GrupoDeRegras { get; set; }
    }
}
