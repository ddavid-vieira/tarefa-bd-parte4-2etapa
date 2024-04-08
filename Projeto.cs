using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Projeto
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int CategoriaId { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime Data_Inicio { get; set; }

    public DateTime Data_Entrega { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;
}


