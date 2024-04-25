using LoginPractica.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginPractica.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public UsuariosController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public async Task<IEnumerable<CategoriesModel>> GetCatigories()
        //{
        //    var catigories = await unitOfWork.Categories.Get();
        //    return catigories;
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCategory(Guid id)
        //{
        //    if (id == Guid.Empty)
        //    {
        //        return BadRequest();
        //    }

        //    var category = await unitOfWork.Categories.Find(id);

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        [HttpGet("ObtenerUsuarioPorCorreoYPassword/{correo}/{password}")]
        public async Task<IActionResult> ObtenerUsuarioPorCorreoYPassword(string correo, string password)
        {
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(password))
            {
                return BadRequest();
            }

            var usuario = await unitOfWork.Usuarios.Find(correo, password);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }


        //[HttpPost]
        //public async Task<IActionResult> PostCategory(CategoriesModel model)
        //{
        //    await unitOfWork.Categories.Add(model);
        //    return Ok();
        //}

        //[HttpPut]
        //public async Task<IActionResult> PutCategory(CategoriesModel model)
        //{
        //    if (model == null || model.f_uid == Guid.Empty)
        //    {
        //        return BadRequest();
        //    }

        //    var category = await unitOfWork.Categories.Find(model.f_uid);

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    await unitOfWork.Categories.Update(category);
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCategory(Guid id)
        //{
        //    if (id == Guid.Empty)
        //    {
        //        return BadRequest();
        //    }

        //    var category = await unitOfWork.Categories.Find(id);

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    await unitOfWork.Categories.Remove(category);
        //    return Ok();
        //}
    }
}
