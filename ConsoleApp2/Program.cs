using ParserWildberries;

var searchStrings = File.ReadAllLines(@"C:\Keys.txt");

var wbEngine = new WbEngine();
List<ExcelProductsModel> excelProductsModels = new List<ExcelProductsModel>();

foreach (var searchString in searchStrings)
{
    var products = await wbEngine.GetDataByQueryTerm(searchString);
    excelProductsModels.Add(new ExcelProductsModel() 
    { 
        Products= products, 
        SearchString = searchString 
    });
}
wbEngine.WriteIntoExcel(excelProductsModels);

Console.WriteLine("Done");