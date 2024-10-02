
using StockOnliner;

StockExchangeManitor stockExchangeManitor = new StockExchangeManitor();

stockExchangeManitor.PriceChangeHandler = ShowPrice;

stockExchangeManitor.Start();


void ShowPrice(int price)
{
    Console.WriteLine($"New price is : {price}");
}
