using MeuLanchee.Context;
using MeuLanchee.Models;
using MeuLanchee.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MeuLanchee.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos =>_context.Lanches.
                                            Where(l => l.IsLanchePreferido).
                                            Include(c=>c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
