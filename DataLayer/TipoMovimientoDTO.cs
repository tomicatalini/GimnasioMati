﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public enum TipoMovimientoDTO
    {
        [Key]
        compra, venta
    }
}
