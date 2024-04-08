using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Tarefa
{
    public int Id { get; set; }

    public int ProjetoId { get; set; }

    public string Nome { get; set; } = null!;

    public int TagId { get; set; }

    public int TipoId { get; set; }

    public string Descricao { get; set; } = null!;

    public int Prioridade { get; set; }

    public DateTime Prazo { get; set; }

    public DateTime Data_Inicio { get; set; }

    public DateTime Data_Entrega { get; set; }

    public DateTime Atraso { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual Projeto Projeto { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;

    public virtual Tipo Tipo { get; set; } = null!;
}
