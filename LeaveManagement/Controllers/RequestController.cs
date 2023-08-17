using LeaveManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagement.Controllers
{
       
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public RequestController(ApplicationDbContext context)
        {
            _Context = context;
        }

        public SelectList NewRequester { get; set; }
        //public SelectList NewStatus { get; set; }
        public IActionResult Index()
        {

             _Context.Requesters.ToLookup(x => x.Name);
            var list = _Context.Requests.ToList();

            return View(list);
        }

        public IActionResult Create()
        {
            PopulateData();
            //ViewBag.NewRequester = new SelectList(_Context.Requesters.ToList(), "Id", "Name");
            //ViewBag.Status = new SelectList(_Context.Status.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Request request)
        {
            DateTime dateTime = DateTime.Now;
            if (ModelState.IsValid)
            {
                request.RequestDate = dateTime;
                
               _Context.Requests.Add(request);
                await _Context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            PopulateData();
            return View(request);
            


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id != null)
            {
               var delItem = _Context.Requests.Where(n => n.Id == id).FirstOrDefault();
                _Context.Requests.Remove(delItem);
                await _Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public void PopulateData()
        {
            ViewBag.NewRequester = new SelectList(_Context.Requesters.ToList(), "Id", "Name");

          

        }
     
    }

}
