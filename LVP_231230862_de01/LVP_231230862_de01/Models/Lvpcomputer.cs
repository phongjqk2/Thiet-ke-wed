using System;
using System.Collections.Generic;

namespace LVP_231230862_de01.Models;

public partial class Lvpcomputer
{
    public int LvpcomId { get; set; }

    public string LvpcomName { get; set; } = null!;

    public decimal LvpcomPrice { get; set; }

    public string? LvpcomImage { get; set; }

    public bool Lvpcomstatus { get; set; }
}
