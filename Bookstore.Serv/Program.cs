using System.Net;
using System.Net.Sockets;
using AutoMapper;
using Bookstore.BusinessLogic.Mapper;
using Bookstore.BusinessLogic.Services;
using Bookstore.Model;
using Bookstore.Serv;
using Bookstore.Serv.Services;
using Microsoft.Extensions.DependencyInjection;

var mapperConfiguration = new MapperConfiguration(x =>
{
    x.AddProfile<MappingProfile>();
});

mapperConfiguration.AssertConfigurationIsValid();
IMapper mapper = mapperConfiguration.CreateMapper();

var serviceProvider = new ServiceCollection()
            .AddLogging()
            .AddSingleton<IBookService, BookService>()
            .AddSingleton<IBookJsonService, BookJsonService>()
            .AddSingleton<ICreditCardJsonService, CreditCardJsonService>()
            .AddSingleton<IWalletService, WalletService>()
            .AddSingleton<IBasketJsonService, BasketJsonService>()
            .AddSingleton<IBasketService, BasketService>()
            .AddSingleton<IAuthorService, AuthorService>()
            .AddSingleton<IMethodService, MethodService>()
            .AddSingleton<BookstoreContext, BookstoreContext>()
            .AddSingleton(mapper)
            .BuildServiceProvider();

var bookService = serviceProvider.GetService<IBookService>();
var methodService = serviceProvider.GetService<IMethodService>();

//bookService.Sync();
//Console.WriteLine("sex");
//Console.ReadLine();


TcpListener listener = null;

string IP = "127.0.0.1";
int PORT = 8080;

try
{
    listener = new TcpListener(IPAddress.Parse(IP), PORT);
    listener.Start();

    while (true)
    {
        //Для входящих
        TcpClient client = listener.AcceptTcpClient();

        Connection connection = new Connection(
            client, methodService);

        Thread clientThread = new Thread(new ThreadStart(connection.Process));
        clientThread.Start();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    if (listener != null)
        listener.Stop();
}
