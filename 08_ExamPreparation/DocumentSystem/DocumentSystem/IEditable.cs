﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    interface IEditable
    {
        void ChangeContent(string newContent);
    }
}
