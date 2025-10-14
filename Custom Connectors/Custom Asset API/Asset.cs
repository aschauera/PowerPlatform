public class Asset{
    public int? ID { get; set;}
    public string? Name { get; set;}
    public string? Location { get; set; }
    public string? Code { get; set; }
    public DateOnly? InstallDate { get; set; }
    public DateOnly? InventoryDate { get; set; }
}