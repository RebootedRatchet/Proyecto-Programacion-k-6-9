using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class HorariosEmpleado
{
    public int HorarioId { get; set; }

    public string? DiaSemana { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public TimeOnly? HoraFin { get; set; }

    public int? EmpId { get; set; }
}
