# Projeto Agendamento - Trabalho 1

Funcionalidade de gerenciamento de pacientes desenvolvida em ASP.NET Core MVC com Entity Framework Core e PostgreSQL.

## Requisitos implementados

- Classe `Paciente` com:
  - Nome
  - CPF
  - Telefone
  - Endereço
  - Data de Nascimento
- Data Annotations para validação e mapeamento.
- `AppDbContext` com `DbSet<Paciente>`.
- Migration para criação da tabela `Pacientes`.
- `SeedingService` com pacientes iniciais.
- CRUD de pacientes:
  - Listar
  - Inserir
  - Editar
  - Remover

## Tecnologias

- .NET 9
- ASP.NET Core MVC
- Entity Framework Core 9
- PostgreSQL
- Npgsql
- Razor Views e Tag Helpers

## Configuração do banco

No arquivo `appsettings.json`, altere a senha do PostgreSQL na string de conexão, se necessário:

```json
"DefaultConnection": "Host=localhost;Port=5432;Database=Agendamento;Username=postgres;Password=senha"
```

## Executar pelo VS Code

Caso a ferramenta do EF Core ainda não esteja instalada:

```bash
dotnet tool install --global dotnet-ef
```

Restaure os pacotes:

```bash
dotnet restore
```

Aplique a migration no PostgreSQL:

```bash
dotnet ef database update
```

Execute a aplicação:

```bash
dotnet run
```

Depois, acesse a opção **Pacientes** no menu da aplicação.

## Comandos equivalentes vistos em aula

Criação de migration no VS Code:

```bash
dotnet ef migrations add CriacaoPacientes
```

Aplicação das migrations:

```bash
dotnet ef database update
```

No Visual Studio, os comandos equivalentes no Console do Gerenciador de Pacotes são:

```powershell
Add-Migration CriacaoPacientes
Update-Database
```
