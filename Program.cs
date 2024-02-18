using Pattern_2.Patterns.Decorator;
using Pattern_2.Patterns.Decorator.Decorators;
using Pattern_2.Patterns.Facade;
using Pattern_2.Patterns.Observer;

//Decorator
IWriter writer = new PDFDecorator(new DOCDecorator(new Writer("Writer 1")));
IWriter writer2 = new PDFDecorator(new Writer("Writer 2"));

writer.Write("A new text");

Console.WriteLine("\n");

writer2.Write("A different new text");

//Observer
NotificationService notificationService = new NotificationService();
Store store = new Store(notificationService);

NotificationListener listener1 = new NotificationListener("User 1");
NotificationListener listener2 = new NotificationListener("User 2");

notificationService.subscribe(listener1);
notificationService.subscribe(listener2);
Console.WriteLine("\n");
store.announce("This is an announcement.");

Console.WriteLine("\n");


//Facade

User client  = new User();

CryptoFacade cryptoFacade = new CryptoFacade();

cryptoFacade.BuyCrypto(client, .1f, "BTC");