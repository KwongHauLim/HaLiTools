﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaLi.Tools.SecretMemory.Protector
{
    internal class Accounter
    {
        public Block Block { get; set; }

        public int Hash { get; private set; }

        public bool FindShake { get; private set; }
    }
}