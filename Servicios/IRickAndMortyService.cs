﻿using MauiEjemploAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEjemploAPI.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();
    }
}
