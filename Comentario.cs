using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Comentario
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int TarefaId { get; set; }

    public int ComentarioPaiId { get; set; }

    public string Texto { get; set; } = null!;

    public int Ordem { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Comentario ComentarioPai { get; set; } = null!;

    public virtual ICollection<Comentario> InverseComentarioPai { get; set; } = new List<Comentario>();

    public virtual Tarefa Tarefa { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
