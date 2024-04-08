using Microsoft.EntityFrameworkCore;
using tarefa_bd_parte4_2etapa;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MainDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Cliente
app.MapGet(
    "/cliente",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Cliente.ToListAsync();
    }
);
app.MapGet("/cliente/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Cliente.FindAsync(id) is Cliente cliente
            ? Results.Ok(cliente)
            : Results.NotFound();
    }
);
app.MapPost("/cliente", async (Cliente cliente, MainDbContext dbContext) =>
{
    await dbContext.Cliente.AddAsync(cliente);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/cliente/{cliente.Id}", cliente);
});
app.MapPut("/cliente/{id}", async (int id, Cliente cliente, MainDbContext dbContext) =>
{
    if (id != cliente.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(cliente).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Cliente.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/cliente/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Cliente.FindAsync(id) is not Cliente cliente)
    {
        return Results.NotFound();
    }

    dbContext.Cliente.Remove(cliente);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});

//Categoria
app.MapGet("/categoria",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Categoria.ToListAsync();
    }
);
app.MapGet("/categoria/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Categoria.FindAsync(id) is Categoria categoria
            ? Results.Ok(categoria)
            : Results.NotFound();
    }
);
app.MapPost("/categoria", async (Categoria categoria, MainDbContext dbContext) =>
{
    await dbContext.Categoria.AddAsync(categoria);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/categoria/{categoria.Id}", categoria);
});
app.MapPut("/categoria/{id}", async (int id, Categoria categoria, MainDbContext dbContext) =>
{
    if (id != categoria.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(categoria).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Categoria.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/categoria/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Categoria.FindAsync(id) is not Categoria categoria)
    {
        return Results.NotFound();
    }

    dbContext.Categoria.Remove(categoria);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


//Projeto
app.MapGet("/projeto",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Projeto.ToListAsync();
    }
);
app.MapGet("/projeto/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Projeto.FindAsync(id) is Projeto projeto
            ? Results.Ok(projeto)
            : Results.NotFound();
    }
);
app.MapPost("/projeto", async (Projeto projeto, MainDbContext dbContext) =>
{
    await dbContext.Projeto.AddAsync(projeto);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/projeto/{projeto.Id}", projeto);
});
app.MapPut("/projeto/{id}", async (int id, Projeto projeto, MainDbContext dbContext) =>
{
    if (id != projeto.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(projeto).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Projeto.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/projeto/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Projeto.FindAsync(id) is not Projeto projeto)
    {
        return Results.NotFound();
    }

    dbContext.Projeto.Remove(projeto);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


//Tipo 
app.MapGet("/tipo",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Tipo.ToListAsync();
    }
);
app.MapGet("/tipo/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Tipo.FindAsync(id) is Tipo tipo
            ? Results.Ok(tipo)
            : Results.NotFound();
    }
);
app.MapPost("/tipo", async (Tipo tipo, MainDbContext dbContext) =>
{
    await dbContext.Tipo.AddAsync(tipo);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/tipo/{tipo.Id}", tipo);
});
app.MapPut("/tipo/{id}", async (int id, Tipo tipo, MainDbContext dbContext) =>
{
    if (id != tipo.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(tipo).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Tipo.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/tipo/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Tipo.FindAsync(id) is not Tipo tipo)
    {
        return Results.NotFound();
    }

    dbContext.Tipo.Remove(tipo);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


//Equipe
app.MapGet("/equipe",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Equipe.ToListAsync();
    }
);
app.MapGet("/equipe/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Equipe.FindAsync(id) is Equipe equipe
            ? Results.Ok(equipe)
            : Results.NotFound();
    }
);
app.MapPost("/equipe", async (Equipe equipe, MainDbContext dbContext) =>
{
    await dbContext.Equipe.AddAsync(equipe);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/equipe/{equipe.Id}", equipe);
});
app.MapPut("/equipe/{id}", async (int id, Equipe equipe, MainDbContext dbContext) =>
{
    if (id != equipe.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(equipe).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Equipe.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/equipe/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Equipe.FindAsync(id) is not Equipe equipe)
    {
        return Results.NotFound();
    }

    dbContext.Equipe.Remove(equipe);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


//Tag
app.MapGet("/tag",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Tag.ToListAsync();
    }
);
app.MapGet("/tag/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Tag.FindAsync(id) is Tag tag
            ? Results.Ok(tag)
            : Results.NotFound();
    }
);
app.MapPost("/tag", async (Tag tag, MainDbContext dbContext) =>
{
    await dbContext.Tag.AddAsync(tag);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/tag/{tag.Id}", tag);
});
app.MapPut("/tag/{id}", async (int id, Tag tag, MainDbContext dbContext) =>
{
    if (id != tag.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(tag).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Tag.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/tag/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Tag.FindAsync(id) is not Tag tag)
    {
        return Results.NotFound();
    }

    dbContext.Tag.Remove(tag);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


//Status
app.MapGet("/status",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Status.ToListAsync();
    }
);
app.MapGet("/status/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Status.FindAsync(id) is Status status
            ? Results.Ok(status)
            : Results.NotFound();
    }
);
app.MapPost("/status", async (Status status, MainDbContext dbContext) =>
{
    await dbContext.Status.AddAsync(status);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/status/{status.Id}", status);
});
app.MapPut("/status/{id}", async (int id, Status status, MainDbContext dbContext) =>
{
    if (id != status.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(status).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Status.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/status/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Status.FindAsync(id) is not Status status)
    {
        return Results.NotFound();
    }

    dbContext.Status.Remove(status);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});

//Tarefa
app.MapGet("/tarefa",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Tarefa.ToListAsync();
    }
);
app.MapGet("/tarefa/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Tarefa.FindAsync(id) is Tarefa tarefa
            ? Results.Ok(tarefa)
            : Results.NotFound();
    }
);
app.MapPost("/tarefa", async (Tarefa tarefa, MainDbContext dbContext) =>
{
    await dbContext.Tarefa.AddAsync(tarefa);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/tarefa/{tarefa.Id}", tarefa);
});
app.MapPut("/tarefa/{id}", async (int id, Tarefa tarefa, MainDbContext dbContext) =>
{
    if (id != tarefa.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(tarefa).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Tarefa.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/tarefa/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Tarefa.FindAsync(id) is not Tarefa tarefa)
    {
        return Results.NotFound();
    }

    dbContext.Tarefa.Remove(tarefa);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});

//Usuario
app.MapGet("/usuario",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.Usuario.ToListAsync();
    }
);
app.MapGet("/usuario/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.Usuario.FindAsync(id) is Usuario usuario
            ? Results.Ok(usuario)
            : Results.NotFound();
    }
);
app.MapPost("/usuario", async (Usuario usuario, MainDbContext dbContext) =>
{
    await dbContext.Usuario.AddAsync(usuario);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/usuario/{usuario.Id}", usuario);
});
app.MapPut("/usuario/{id}", async (int id, Usuario usuario, MainDbContext dbContext) =>
{
    if (id != usuario.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(usuario).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.Usuario.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/usuario/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.Usuario.FindAsync(id) is not Usuario usuario)
    {
        return Results.NotFound();
    }

    dbContext.Usuario.Remove(usuario);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});

//TarefaUsuarioStatus
app.MapGet("/tarefaUsuarioStatus",
    async (MainDbContext dbContext) =>
    {
        return await dbContext.TarefaUsuarioStatus.ToListAsync();
    }
);
app.MapGet("/tarefaUsuarioStatus/{id}",
    async (int id, MainDbContext dbContext) =>
    {
        return await dbContext.TarefaUsuarioStatus.FindAsync(id) is TarefaUsuarioStatus tarefaUsuarioStatus
            ? Results.Ok(tarefaUsuarioStatus)
            : Results.NotFound();
    }
);
app.MapPost("/tarefaUsuarioStatus", async (TarefaUsuarioStatus tarefaUsuarioStatus, MainDbContext dbContext) =>
{
    await dbContext.TarefaUsuarioStatus.AddAsync(tarefaUsuarioStatus);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/tarefaUsuarioStatus/{tarefaUsuarioStatus.Id}", tarefaUsuarioStatus);
});
app.MapPut("/tarefaUsuarioStatus/{id}", async (int id, TarefaUsuarioStatus tarefaUsuarioStatus, MainDbContext dbContext) =>
{
    if (id != tarefaUsuarioStatus.Id)
    {
        return Results.BadRequest("Registro não encontrado");
    }

    dbContext.Entry(tarefaUsuarioStatus).State = EntityState.Modified;

    try
    {
        await dbContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (await dbContext.TarefaUsuarioStatus.FindAsync(id) is null)
        {
            return Results.NotFound();
        }

        throw;
    }

    return Results.NoContent();
});
app.MapDelete("/tarefaUsuarioStatus/{id}", async (int id, MainDbContext dbContext) =>
{
    if (await dbContext.TarefaUsuarioStatus.FindAsync(id) is not TarefaUsuarioStatus tarefaUsuarioStatus)
    {
        return Results.NotFound();
    }

    dbContext.TarefaUsuarioStatus.Remove(tarefaUsuarioStatus);
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});


app.UseHttpsRedirection();

app.Run();
