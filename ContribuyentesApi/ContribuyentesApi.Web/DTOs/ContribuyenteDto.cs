﻿using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Web.DTOs
{
    public class ContribuyenteDto
    {
        public string RncCedula { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Estatus { get; set; }
    }
}
