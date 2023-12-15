using Aysa14.Models;
using Aysa14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aysa14.Services
{
    public class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();

        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.People.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return _context.People.ToList();


            return _context.People.Where(x => x.Cliente.Contains(text) || x.Vendedor.Contains(text)).ToList();
        }


    }
}
