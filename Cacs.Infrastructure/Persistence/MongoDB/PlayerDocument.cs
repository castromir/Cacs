using System;
using System.Collections.Generic;
using System.Text;

namespace Cacs.Infrastructure.Persistence.MongoDB
{
    public class PlayerDocument
    {
        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public List<CategoriaDocument> Categorias { get; set; } = [];
    }

    public class CategoriaDocument
    {
        public int Nivel { get; set; }

        public int Quantidade { get; set; }
    }
}
