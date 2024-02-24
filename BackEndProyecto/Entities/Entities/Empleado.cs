using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Empleado
{
    public int EmpId { get; set; }

    public string EmpNombre1 { get; set; } = null!;

    public string EmpApellido1 { get; set; } = null!;

    public string EmpDireccion { get; set; } = null!;

    public string? EmpTelcelular { get; set; }

    public string? EmpEmail { get; set; }

    public int DepEmpId { get; set; }

    public int GenGeneroGenId { get; set; }

    public int EspEmpId { get; set; }

    public int CarEmpId { get; set; }
}
