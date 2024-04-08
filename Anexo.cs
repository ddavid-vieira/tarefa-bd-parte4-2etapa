using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Anexo
{
    public int Id { get; set; }

    public int TipoAnexoId { get; set; }

    public int TarefaId { get; set; }

    public string Nome { get; set; } = null!;

    public string Caminho { get; set; } = null!;

    public int Ordem { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Tarefa Tarefa { get; set; } = null!;

    public virtual TipoAnexo TipoAnexo { get; set; } = null!;
}
