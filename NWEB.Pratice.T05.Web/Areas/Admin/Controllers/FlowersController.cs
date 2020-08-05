using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NWEB.Pratice.T05.Core.Model;
using System.Linq;
using System.Threading.Tasks;

namespace NWEB.Pratice.T05.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlowersController : Controller
    {
        private readonly FlowerContext _context;

        public FlowersController(FlowerContext context)
        {
            _context = context;
        }

        // GET: Admin/Flowers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flowers.ToListAsync());
        }

        // GET: Admin/Flowers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flower = await _context.Flowers
                .FirstOrDefaultAsync(m => m.FlowerId == id);
            if (flower == null)
            {
                return NotFound();
            }

            return View(flower);
        }

        // GET: Admin/Flowers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Flowers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlowerId,FlowerName,Description,ImageUrl,Price,SalePrice,StoreDate,StoreInventory,CategoryId")] Flower flower)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flower);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flower);
        }

        // GET: Admin/Flowers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flower = await _context.Flowers.FindAsync(id);
            if (flower == null)
            {
                return NotFound();
            }
            return View(flower);
        }

        // POST: Admin/Flowers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlowerId,FlowerName,Description,ImageUrl,Price,SalePrice,StoreDate,StoreInventory,CategoryId")] Flower flower)
        {
            if (id != flower.FlowerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flower);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlowerExists(flower.FlowerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(flower);
        }

        // GET: Admin/Flowers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flower = await _context.Flowers
                .FirstOrDefaultAsync(m => m.FlowerId == id);
            if (flower == null)
            {
                return NotFound();
            }

            return View(flower);
        }

        // POST: Admin/Flowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flower = await _context.Flowers.FindAsync(id);
            _context.Flowers.Remove(flower);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlowerExists(int id)
        {
            return _context.Flowers.Any(e => e.FlowerId == id);
        }
    }
}
