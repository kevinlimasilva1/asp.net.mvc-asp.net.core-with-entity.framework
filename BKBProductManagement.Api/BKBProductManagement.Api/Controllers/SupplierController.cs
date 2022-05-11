using BKBProductManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BKBProductManagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class SupplierController : Controller
    {
        private readonly BKBDbContext _context;
        public SupplierController(BKBDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna todos os fornecedores
        /// </summary>
        /// <returns>Lista com objetos contendo informações sobre fornecedores</returns>
        [HttpGet()]
        public IEnumerable<Supplier> Get()
        {
            return _context.Supplier.ToList();
        }

        /// <summary>
        /// Retorna o fornecedor pelo Id
        /// </summary>
        /// <returns>Objeto contendo informações sobre o fornecedor</returns>
        [HttpGet("{id}")]
        public Supplier Get(int id)
        {
            return _context.Supplier.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Cadastra um fornecedor no banco de dados
        /// </summary>
        /// <returns>Novo objeto fornecedor cadastrado no banco de dados</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Supplier value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        /// <summary>
        /// Edita um fornecedor no banco de dados
        /// </summary>
        /// <returns>Novo objeto fornecedor editado no banco de dados</returns>
        [HttpPut]
        public IActionResult Edit([FromBody] Supplier value)
        {
            _context.Update(value);
            _context.SaveChanges();
            return StatusCode(200, value);
        }

        /// <summary>
        /// Remove um fornecedor do banco de dados
        /// </summary>
        /// <returns>Status de remoção do banco de dados</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var supplier = Get(id);
            _context.Remove(supplier);
            _context.SaveChanges();
            return StatusCode(200, true);
        }
    }
}
