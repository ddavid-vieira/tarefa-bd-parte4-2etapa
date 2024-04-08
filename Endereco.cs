using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class Endereco
{
    public int Id { get; set; }

    public string Uf { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Logradouro { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
