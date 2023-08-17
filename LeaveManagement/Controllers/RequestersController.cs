using LeaveManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    public class RequestersController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public RequestersController(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
          var list =  _Context.Requesters.ToList();
            return View(list);
        }

        public async Task<IActionResult> Create(Requester RequesterObj)
        {
            CheckDuplication(RequesterObj);
            if (ModelState.IsValid)
            {
                _Context.Requesters.Add(RequesterObj);
                await _Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id != null)
            {
                var DeleteItem = _Context.Requesters.FirstOrDefault(x => x.Id == id);
               _Context.Remove(DeleteItem);
                await _Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        
        public void CheckDuplication(Requester requester)
        {
            var item = _Context.Requesters.Where(x => x.Name == requester.Name);
            if (item.Any())
            {
                throw new Exception($"The {requester.Name} being created already exist in the database");
            }

            
        }
    }
}
