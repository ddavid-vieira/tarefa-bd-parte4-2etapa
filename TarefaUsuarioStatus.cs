using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class TarefaUsuarioStatus
{
    public int Id { get; set; }

    public int TarefaId { get; set; }

    public int UsuarioId { get; set; }

    public int StatusId { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual Tarefa Tarefa { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
