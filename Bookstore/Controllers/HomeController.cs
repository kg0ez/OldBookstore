using System.Diagnostics;
using Bookstore.Common.Enums;
using Bookstore.Handlers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bookstore.Common.Dto;

namespace Bookstore.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var typeAction = QueryHandler<QueryBookType>.QueryTypeSerialize(QueryBookType.GetBooks);

        string json = QueryHandler<int>.Serialize(0, QueryType.Book, typeAction);

        string answer = ConnectionHandler.Client(json);

        var books = JsonSerializer.Deserialize<List<BookDto>>(answer);

        Handlers.Book.Books = books;

        return View(books);
    }


    public IActionResult AboutBook(Nullable<int> id)
    {
        if (id.HasValue)
        {
            var book = Handlers.Book.Books.FirstOrDefault(b => b.Id == id);

            if (book!=null)
                return View(book);
        }
        return NotFound();
    }

    public IActionResult Wallet()
    {
        var typeAction = QueryHandler<QueryCreditCardType>.QueryTypeSerialize(QueryCreditCardType.Get);

        string json = QueryHandler<int>.Serialize(0, QueryType.CreditCard, typeAction);

        string answer = ConnectionHandler.Client(json);

        var cards = JsonSerializer.Deserialize<List<CreditCardDto>>(answer);

        return View(cards);
    }

    public IActionResult Delete(Nullable<int> id)
    {
        if (!id.HasValue)
            return NotFound();

        var typeAction = QueryHandler<QueryCreditCardType>.QueryTypeSerialize(QueryCreditCardType.Delete);

        string json = QueryHandler<int>.Serialize((int)id, QueryType.CreditCard, typeAction);

        string answer = ConnectionHandler.Client(json);

        var cards = JsonSerializer.Deserialize<bool>(answer);

        if (!cards)
            return NotFound();

        return RedirectToAction("Wallet");
    }

    public IActionResult AddCard()=>
        View();

    [HttpPost]
    public IActionResult AddCard(CardDto card)
    {
        if (!ModelState.IsValid)
            return View(card);

        var typeAction = QueryHandler<QueryCreditCardType>.QueryTypeSerialize(QueryCreditCardType.Add);

        string json = QueryHandler<CardDto>.Serialize(card, QueryType.CreditCard, typeAction);

        string answer = ConnectionHandler.Client(json);

        var isAdd = JsonSerializer.Deserialize<bool>(answer);

        if (!isAdd)
            return View(card);
        
        return RedirectToAction("Wallet");
    }

    public IActionResult Basket()
    {
        var typeAction = QueryHandler<QueryBasketType>.QueryTypeSerialize(QueryBasketType.Get);

        string json = QueryHandler<int>.Serialize(0, QueryType.Basket, typeAction);

        string answer = ConnectionHandler.Client(json);

        var basket = JsonSerializer.Deserialize<List<BasketDto>>(answer);

        return View(basket);
    }

    [HttpPost]
    public IActionResult AddBusket(Nullable<int> id)
    {
        if (!id.HasValue)
            return NotFound();

        var typeAction = QueryHandler<QueryBasketType>.QueryTypeSerialize(QueryBasketType.Add);

        string json = QueryHandler<int>.Serialize((int)id, QueryType.Basket, typeAction);

        string answer = ConnectionHandler.Client(json);

        var isAdded = JsonSerializer.Deserialize<bool>(answer);

        if (!isAdded)
            return NotFound();

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DeleteBusket(Nullable<int> id)
    {
        if (!id.HasValue)
            return NotFound();

        var typeAction = QueryHandler<QueryBasketType>.QueryTypeSerialize(QueryBasketType.Delete);

        string json = QueryHandler<int>.Serialize((int)id, QueryType.Basket, typeAction);

        string answer = ConnectionHandler.Client(json);

        var isAdded = JsonSerializer.Deserialize<bool>(answer);

        if (!isAdded)
            return NotFound();

        return RedirectToAction("Basket");
    }
}
