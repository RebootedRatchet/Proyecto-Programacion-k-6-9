using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class VentasVerdura
{
    public int IdVenta { get; set; }

    public string? NombreCliente { get; set; }

    public string? Descripcion { get; set; }

    public decimal? CostoTotal { get; set; }

    public DateOnly? FechaRealizacion { get; set; }
}
