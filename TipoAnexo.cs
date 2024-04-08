﻿using System;
using System.Collections.Generic;

namespace tarefa_bd_parte4_2etapa;

public partial class TipoAnexo
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime Criado_em { get; set; }

    public DateTime Atualizado_em { get; set; }

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();
}
