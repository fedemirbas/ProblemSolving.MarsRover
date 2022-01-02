﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Command
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(Rover.Rover rover)
        {
            rover.TurnRight();
        }
    }
}
