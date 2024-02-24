using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Verdura
{
    public int VerduraId { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }
}
