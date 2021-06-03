using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {
        private readonly LojaVirtualContext _context;
        public NewsletterRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        public void Cadastrar(NewsletterEmail newsletter)
        {
            _context.NewsletterEmails.Add(newsletter);
            _context.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletter()
        {
            return _context.NewsletterEmails.ToList();
        }
    }
}
