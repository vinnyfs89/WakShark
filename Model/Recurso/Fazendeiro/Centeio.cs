﻿using Model.Base;
namespace Model.Recurso.Fazendeiro
{
    public class Centeio : ARecurso, IFazendeiro
    {
        public Centeio() : base("Centeio", 50, 1500, System.IO.Directory.GetCurrentDirectory() + @"\assets\imagem\recurso\fazendeiro\centeio.png") {}
    }
}
