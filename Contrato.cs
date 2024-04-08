using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Contrato
{
    public int Id { get; set; }

    public int ProjetoId { get; set; }

    public int Tipo { get; set; }

    public double ValorContrato { get; set; }

    public DateTime DataAssinatura { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Projeto Projeto { get; set; } = null!;
}
