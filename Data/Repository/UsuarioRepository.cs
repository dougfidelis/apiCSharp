﻿using Data.Model;
using Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override string Create(Usuario entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            return base.Create(entity);
        }
    }
}
