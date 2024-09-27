﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Magician : PlayerCharacter
{
    public Magician(string name)
        : base(name, new CharacterStats(100, 8, 16, 3, 5, 6, 0.2f))
    {
        jobName = "매지션";
    }
}
