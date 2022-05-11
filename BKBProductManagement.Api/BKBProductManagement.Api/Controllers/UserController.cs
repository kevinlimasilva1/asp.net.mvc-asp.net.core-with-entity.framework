using BKBProductManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BKBProductManagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly BKBDbContext _context;
        public UserController(BKBDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna todos os usuários
        /// </summary>
        /// <returns>Lista com objetos contendo informações sobre usuários</returns>
        [HttpGet()]
        public IEnumerable<User> Get()
        {
            return _context.User.ToList();
        }

        /// <summary>
        /// Retorna o usuário pelo Id
        /// </summary>
        /// <returns>Objeto contendo informações sobre o usuário</returns>
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _context.User.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Cadastra um usuário no banco de dados
        /// </summary>
        /// <returns>Novo objeto usuário cadastrado no banco de dados</returns>
        [HttpPost]
        public IActionResult Post([FromBody]User value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        /// <summary>
        /// Remove um usuário do banco de dados
        /// </summary>
        /// <returns>Status de remoção do banco de dados</returns>
        [HttpDelete]
        public IActionResult Delete([FromBody] int id)
        {
            var user = Get(id);
            _context.Remove(user);
            _context.SaveChanges();
            return StatusCode(200, true);
        }
    }
}
