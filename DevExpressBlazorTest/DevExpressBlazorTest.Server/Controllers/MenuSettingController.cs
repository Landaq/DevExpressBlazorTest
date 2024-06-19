using DevExpressBlazorTest.Server.Data;
using DevExpressBlazorTest.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevExpressBlazorTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuSettingController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public MenuSettingController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var menus = await _context.MenuSettings.ToListAsync();
            return Ok(menus);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var menu = await _context.MenuSettings.FirstOrDefaultAsync(x => x.MenuId == id);
            return Ok(menu);
        }
        [HttpPost]
        public async Task<IActionResult> Post(MenuSetting menuSetting)
        {
            _context.Add(menuSetting);
            await _context.SaveChangesAsync();
            return Ok(menuSetting.MenuId);
        }
        [HttpPut]
        public async Task<IActionResult> Put(MenuSetting menuSetting)
        {
            _context.Entry(menuSetting).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var menu = new MenuSetting { MenuId = id };
            _context.Remove(menu);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
