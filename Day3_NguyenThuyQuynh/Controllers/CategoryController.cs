using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3_NguyenThuyQuynh.data;
namespace Day3_NguyenThuyQuynh.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategroyController1
        public ActionResult Index()
        {
            var _categoories = SeedData.categories;
            return View(_categoories);
        }

        // GET: CategroyController1/Details/5
        public ActionResult Details(int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            {
                if (category == null)
                {
                    return NotFound();
                }
            }
            return View(category);
        }

        // GET: CategroyController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategroyController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Models.Category category)
        {
            if (ModelState.IsValid)
            {
                int maxId = SeedData.categories.Max(c => c.Id);
                category.Id = maxId + 1;
                SeedData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        // GET: CategroyController1/Edit/5
        public ActionResult Edit([FromRoute] int id)
        {
            var category = SeedData.categories.FirstOrDefault(category => category.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategroyController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Models.Category category)
        {
            var eistingcategory = SeedData.categories.FirstOrDefault(e => e.Id == category.Id);
            if (eistingcategory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid) {
                eistingcategory.Name = category.Name;
                eistingcategory.Description = category.Description;

            }
            return View(category);
        }

        // GET: CategroyController1/Delete/5
        public ActionResult Delete(int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategroyController1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([FromRoute] int id)
        {
            var existingCategory = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            // SỬA LỖI: Xóa đối tượng vừa tìm thấy trong danh sách
            SeedData.categories.Remove(existingCategory);

            // Chuyển hướng về trang danh sách (Index) sau khi xóa thành công
            return RedirectToAction(nameof(Index));
        }
    }
}
