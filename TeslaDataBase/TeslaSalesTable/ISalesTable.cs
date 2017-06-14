namespace TeslaSalesTable
{
    public interface ISalesTableData
    {
        int Id { get; set; }
        int Cost { get; set; }
        int Revenue { get; set; }
        int SellPrice { get; set; }
    }
}