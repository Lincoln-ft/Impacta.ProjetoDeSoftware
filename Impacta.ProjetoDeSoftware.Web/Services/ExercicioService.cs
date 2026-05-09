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

    public async Task<bool> ExcluirExercicio(int id)
    {
        var exercicio = await _context.Exercicio.FindAsync(id);
        if (exercicio == null) return false;

        _context.Exercicio.Remove(exercicio);
        await _context.SaveChangesAsync();
        return true;
    }

}

