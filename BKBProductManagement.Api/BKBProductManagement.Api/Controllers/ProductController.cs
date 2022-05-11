using BKBProductManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BKBProductManagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly BKBDbContext _context;
        public ProductController(BKBDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna todos os produtos
        /// </summary>
        /// <returns>Lista com objetos contendo informações sobre produtos</returns>
        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            return _context.Product.ToList();
        }

        /// <summary>
        /// Retorna o produto pelo Id
        /// </summary>
        /// <returns>Objeto contendo informações sobre o produto</returns>
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _context.Product.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Cadastra um produto no banco de dados
        /// </summary>
        /// <returns>Novo objeto produto cadastrado no banco de dados</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        /// <summary>
        /// Edita um produto no banco de dados
        /// </summary>
        /// <returns>Novo objeto produto editado no banco de dados</returns>
        [HttpPut]
        public IActionResult Edit([FromBody] Product value)
        {
            _context.Update(value);
            _context.SaveChanges();
            return StatusCode(200, value);
        }

        /// <summary>
        /// Remove um produto do banco de dados
        /// </summary>
        /// <returns>Status de remoção do banco de dados</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = Get(id);
            _context.Remove(product);
            _context.SaveChanges();
            return StatusCode(200, true);
        }
    }
}
