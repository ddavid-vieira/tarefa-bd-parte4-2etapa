using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Usuario
{
    public int Id { get; set; }

    public int EquipeId { get; set; }

    public string Nome { get; set; } = null!;

    public List<string> Emails { get; set; } = null!;

    public List<string> Telefones { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public int Enderecoid { get; set; }

    public DateTime Data_Nascimento { get; set; }

    public int Idade { get; set; }

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual Endereco Endereco { get; set; } = null!;

    public virtual Equipe Equipe { get; set; } = null!;

}
