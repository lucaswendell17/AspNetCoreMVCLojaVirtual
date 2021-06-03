using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LojaVirtualContext _context;
        public ClienteRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public void Excluir(int Id)
        {
            var cliente = ObterCliente(Id);
            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public Cliente Login(string Email, string Senha)
        {
            var cliente = _context.Clientes.Where(m => m.Email == Email && m.Senha == Senha).First();
            return cliente;
        }

        public Cliente ObterCliente(int Id)
        {
            return _context.Clientes.Find(Id); 
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
