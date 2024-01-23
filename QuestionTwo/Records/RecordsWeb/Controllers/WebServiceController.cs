using Microsoft.AspNetCore.Mvc;
using RecordsWeb.Data;
using RecordsWeb.Models;

namespace RecordsWeb.Controllers;

public class WebServiceController : Controller
{
    private readonly ApplicationDbContext _db;

    public WebServiceController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var foundRecords = TempData["FoundRecords"];
        if (foundRecords == null) return View(_db.Records);

        foundRecords = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Record>>(TempData["FoundRecords"].ToString());
        IEnumerable<Record> recordsList = (List<Record>)foundRecords;
        return View(recordsList);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Record newRecord)
    {
        if (!ModelState.IsValid) return View(newRecord);

        _db.Records.Add(newRecord);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Record recordToDelete)
    {
        if (!ModelState.IsValid) return View(recordToDelete);

        var foundRecord = _db.Records.FirstOrDefault(record =>
            record.FirstName == recordToDelete.FirstName &&
            record.LastName == recordToDelete.LastName
        );

        if (foundRecord != null)
        {
            _db.Records.Remove(foundRecord);
            _db.SaveChanges();
        }
        else
        {
            ModelState.AddModelError("firstname", "No record has been found with the given names");
        }
        if (!ModelState.IsValid) return View(recordToDelete);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Search()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Search(Record recordToSearch)
    {
        if (!ModelState.IsValid) return View();
        var foundRecords = _db.Records.Where(
            record => record.FirstName == recordToSearch.FirstName ||
            record.LastName == recordToSearch.LastName
        ).ToList();

        TempData["FoundRecords"] = Newtonsoft.Json.JsonConvert.SerializeObject(foundRecords);

        return RedirectToAction("Index");
    }
}
