using Impacta.ProjetoDeSoftware.Web.DbContext;
using Impacta.ProjetoDeSoftware.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Impacta.ProjetoDeSoftware.Web.Services
{
    public class ClienteService
    {
        private readonly AppDbContext _context;
        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> AdicionarCliente(Cliente cliente)
        {
                           
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }
    }

}
