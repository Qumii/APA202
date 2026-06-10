using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Utilities.Enums;
using _27_FrontToBackSqlConnection.Utilities.Extentisions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin, Moderator")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders
                .Where(s => !s.IsDeleted)
                .ToListAsync();

            return View(sliders);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View(slider);

            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError(nameof(slider.Photo), "File type incorrect!");
                return View(slider);
            }


            if (!slider.Photo.CheckFileSize(FileSize.KB, 10))
            {
                ModelState.AddModelError(nameof(slider.Photo), "File size incorrect!");
                return View(slider);
            }


            Slider slider1 = new()
            {
                Title = slider.Title,
                Description = slider.Description,
                Image = await slider.Photo.CreateFile(_env.WebRootPath, "assets/images")
            };

            await _context.Sliders.AddAsync(slider1);
            await _context.SaveChangesAsync();



            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .Where(s => !s.IsDeleted && s.Id == id)
                .FirstOrDefaultAsync();

            if (slider is null) return NotFound();

            return View(slider);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .FirstOrDefaultAsync(s => !s.IsDeleted && s.Id == id);

            if (slider is null) return NotFound();

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .FirstOrDefaultAsync(s => !s.IsDeleted && s.Id == id);

            if (slider is null) return NotFound();

            return View(slider);
        }



        [HttpPost]
        public async Task<IActionResult> Update(int? id, Slider newSlider)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .FirstOrDefaultAsync(s => !s.IsDeleted && s.Id == id);

            if (slider is null) return NotFound();

            bool existSlider = await _context.Sliders.AnyAsync(s => s.Title.Trim() == newSlider.Title.Trim() && s.Id != id);
            if (existSlider)
            {
                ModelState.AddModelError(nameof(Slider.Title), "This title is already in use.");
            }

            if (newSlider.Photo == null)
            {
                ModelState.Remove(nameof(Slider.Photo));
            }

            if (!ModelState.IsValid) return View(newSlider);

            if (newSlider.Photo != null)
            {
                //!newSlider.Photo.ContentType.Contains("image/")

                if (!slider.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError(nameof(Slider.Photo), "Please select an image file.");
                    return View(newSlider);
                }
                //newSlider.Photo.Length > 2 * 1024 * 1024
                if (!slider.Photo.CheckFileSize(FileSize.MB,2))
                {
                    ModelState.AddModelError(nameof(Slider.Photo), "Image size must be less than 2MB.");
                    return View(newSlider);
                }

                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(newSlider.Photo.FileName);
                string path = Path.Combine(_env.WebRootPath, "assets", "images", "website-images", fileName);

                FileStream fileStream = new FileStream(path, FileMode.Create);

                    await newSlider.Photo.CopyToAsync(fileStream);

            }

            slider.Title = newSlider.Title;
            slider.Subtitle = newSlider.Subtitle;
            slider.Description = newSlider.Description;
            slider.Order = newSlider.Order;

            

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
