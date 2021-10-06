using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisinesController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisines> model = _db.Cuisines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisines Cuisines)
    {
      _db.Cuisines.Add(Cuisines);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisines thisCuisines = _db.Cuisines.FirstOrDefault(Cuisines => Cuisines.CuisinesId == id);
      return View(thisCuisines);
    }
    public ActionResult Edit(int id)
    {
      var thisCuisines = _db.Cuisines.FirstOrDefault(Cuisines => Cuisines.CuisinesId == id);
      return View(thisCuisines);
    }

    [HttpPost]
    public ActionResult Edit(Cuisines Cuisines)
    {
      _db.Entry(Cuisines).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCuisines = _db.Cuisines.FirstOrDefault(Cuisines => Cuisines.CuisinesId == id);
      return View(thisCuisines);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCuisines = _db.Cuisines.FirstOrDefault(Cuisines => Cuisines.CuisinesId == id);
      _db.Cuisines.Remove(thisCuisines);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}