﻿using MeuLanchee.Context;
using MeuLanchee.Models;
using MeuLanchee.Repositories.Interfaces;

namespace MeuLanchee.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
