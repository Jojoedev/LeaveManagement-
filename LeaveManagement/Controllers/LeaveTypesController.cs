using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Models;
using LeaveManagement.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Constants;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles = "Administrator, Accounts")]
    public class LeaveTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;



        //With Repository design pattern, Controller does not interact with DatabaseContext as seen below.
        //This is important that there cud be change of database and such change would not affect the operations of the controllers. 


        /*public LeaveTypesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
           
        }*/

        
        //IleaveTypeRepository is a specific to LeaveType alone, it is registered in the program.cs file and hence injected as below to 
        //to communication with DB instead of DBContext earlier set.
        

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            
            var leaveType = _mapper.Map<List<LeaveTypeVM>>(await _leaveTypeRepository.GetAllAsync());
            
              return View(leaveType);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType =  await _leaveTypeRepository.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                await _leaveTypeRepository.CreateAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var leaveType = await _leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
               var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                await _leaveTypeRepository.UpdateAsync(leaveType);               
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult?> Delete(int? id)
        {
            /*if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }*/

           /* var leaveType = _mapper.Map<LeaveTypeVM>(await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id));
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);*/


            var DeleteLeaveType = _mapper.Map<LeaveTypeVM>(await _leaveTypeRepository.GetAsync(id));
            if(id != DeleteLeaveType.Id || id == null)
            {
                return null;
            }

            return View(DeleteLeaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*if (_context.LeaveTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
            }
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));*/

          await _leaveTypeRepository.DeleteAsync(id);
           return RedirectToAction(nameof(Index));


        }

        private async Task<bool> LeaveTypeExistsAsync(int id)
        {
            return await _leaveTypeRepository.Exists(id);
        }
    }
}
