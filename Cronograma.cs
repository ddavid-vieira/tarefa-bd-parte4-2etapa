using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Cronograma
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int ProjetoId { get; set; }

    public DateTime Data { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Projeto Projeto { get; set; } = null!;
}
