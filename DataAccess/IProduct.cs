namespace DataAccess;

public interface IProduct
{
    int Id { get; set; }
    string Name { get; set; }
    string Autor { get; set; }
    decimal Price {  get; set; }

    string GetBasicInfo();
}
