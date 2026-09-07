using ProjetoAgendamento.Models;

namespace ProjetoAgendamento.Data;

public class SeedingService
{
    private readonly AppDbContext _context;

    public SeedingService(AppDbContext context)
    {
        _context = context;
    }

    public void Popula()
    {
        if (_context.Pacientes.Any())
        {
            return;
        }

        Paciente paciente1 = new Paciente
        {
            Nome = "Ana Souza",
            Cpf = "123.456.789-00",
            Telefone = "(18) 99999-1111",
            Endereco = "Rua das Flores, 100",
            DataNascimento = new DateTime(1995, 5, 10)
        };

        Paciente paciente2 = new Paciente
        {
            Nome = "Carlos Lima",
            Cpf = "987.654.321-00",
            Telefone = "(18) 99999-2222",
            Endereco = "Avenida Brasil, 250",
            DataNascimento = new DateTime(1988, 11, 22)
        };

        Paciente paciente3 = new Paciente
        {
            Nome = "Mariana Alves",
            Cpf = "111.222.333-44",
            Telefone = "(18) 99999-3333",
            Endereco = "Rua Central, 45",
            DataNascimento = new DateTime(2001, 3, 14)
        };

        _context.Pacientes.AddRange(paciente1, paciente2, paciente3);
        _context.SaveChanges();
    }
}
