﻿using System;

namespace DataLayer
{
    public class OperacionDTO
    {
        //Properties navigation
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaOperacion { get; set; }
        public DateTime FechaRecuperacion { get; set; }

        //Relationship navigation
        public FichaMedicaDTO FichaMedica { get; set; }
    }
}
