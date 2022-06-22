using Factory;

SimpleProductFactory simple = new SimpleProductFactory();

List<ITechProduct> products = new List<ITechProduct>()
{
    simple.CreateProduct("phone"),
    simple.CreateProduct("laptop"),
    simple.CreateProduct("tablet"),
};

foreach (var product in products)
{
    Console.WriteLine(product.Name);
}