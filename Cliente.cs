using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace tarefa_bd_parte4_2etapa;

public partial class Cliente
{   
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public List<string> Telefones { get; set; } = null!;

    public List<string> Emails { get; set; } = null!;

    public DateTime Criado_em { get; set; }

    public DateTime? Atualizado_em { get; set; }

   
}
