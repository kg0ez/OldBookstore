using System.Diagnostics;
using Bookstore.Models;
using Bookstore.Models.HelperClasses;
using Bookstore.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Controllers;

public class HomeController : Controller
{
    private BookstoreContext _db;
    private Operation _operation;

    public HomeController(BookstoreContext context)
    {
        _db = context;
        _operation = new Operation(_db);
    }

    public IActionResult Index()=>
        View(_db.CostBooks.Include(x => x.Book).ThenInclude(u => u!.Author).ToList());


    public IActionResult AboutBook(Nullable<int> id)
    {
        if (id.HasValue)
        {
            AboutBook? book = _db.AboutBooks.Include(x => x.Book).ThenInclude(y => y!.Author)
                .Include(x => x.Book!.Language).Include(x => x.Book!.Description).Include(x => x.Book!.Provider)
                .Include(x => x.Book!.PublishingOffice).FirstOrDefault(x => x.Book!.Id == id.Value);
            if (book!=null)
                return View(book);
        }
        return NotFound();
    }

    public IActionResult Wallet()=>
        View(_db.CreditCards.ToList());

    public IActionResult Delete(Nullable<int> id)
    {
        if (id.HasValue)
        {
            CreditCard? card = _db.CreditCards.FirstOrDefault(x => x.Id == id.Value);
            if (_operation.DeleteCard(card))
                return RedirectToAction("Wallet");
        }
        return NotFound();
    }

    public IActionResult AddCard()=>
        View();

    [HttpPost]
    public IActionResult AddCard(CreditCard card)
    {
        card.Customer = (Customer)_db.Customers.Where(x => x.Id == card.Id);
        if (ModelState.IsValid)
        {
            _operation.AddCreditCard(card);
            return RedirectToAction("Index");
        }
        return View(card);
    }

    public IActionResult Basket()=>
        View(_db.Basket.Include(x => x.Book).ThenInclude(u => u!.Author).ToList());

    [HttpPost]
    public IActionResult AddBusket(Nullable<int> id)
    {
        _operation.AddItemBusket(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DeleteBusket(Nullable<int> id)
    {
        if(_operation.DeleteItemBusket(id))
            return RedirectToAction("Basket");
        return NotFound();
    }
}
