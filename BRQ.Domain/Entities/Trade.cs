namespace BRQ.Domain.Entities
{
    public class Trade
    {
        public string ClientSector { get; set; }
        public double Value { get; set; }
    }

    public class TradeRecord //: Trade
    {
        public int TradeId { get; set; }
        public string ClientSector { get; set; }
        public double Value { get; set; }
    }

}
