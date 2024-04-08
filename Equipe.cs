using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Equipe
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int ProjetoId { get; set; }

    public int TipoId { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Projeto Projeto { get; set; } = null!;

    public virtual Tipo Tipo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
