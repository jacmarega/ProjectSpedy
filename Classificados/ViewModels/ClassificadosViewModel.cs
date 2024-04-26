using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classificados.ViewModels
{
    public class ClassificadosViewModel
    {
        public int? Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
    }
}