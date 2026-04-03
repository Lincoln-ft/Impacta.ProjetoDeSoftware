using Impacta.ProjetoDeSoftware.Web.DbContext;
using Impacta.ProjetoDeSoftware.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Impacta.ProjetoDeSoftware.Web.Services;

public class ExercicioService
{
    private readonly AppDbContext _context;
    public ExercicioService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Exercicio>> GetExerciciosAsync()
    {
        return await _context.Exercicio.ToListAsync();
    }

    public async Task<Exercicio> AdicionarExercicio(Exercicio exercicio)
    {

        _context.Exercicio.Add(exercicio);
        await _context.SaveChangesAsync();

        return exercicio;
    }
}
