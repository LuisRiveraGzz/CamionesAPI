﻿using System;
using System.Collections.Generic;

namespace CamionesAPI.Models.Entities;

public partial class Rol
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuario { get; set; } = new List<Usuario>();
}
