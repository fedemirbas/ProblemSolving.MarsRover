﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Models
{
    public interface ICoordinate
    {
        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
    }
}
