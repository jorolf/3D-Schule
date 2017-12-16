﻿using System;

namespace Project.Games.Circuit.Blocks
{
    public class StraightConnection : Block
    {
        public override Direction[] GetPathsFor(Direction dir)
        {
            switch (dir.RotateBy((int)transform.rotation.eulerAngles.z))
            {
                case Direction.Up:
                    return new[] { Direction.Down };
                case Direction.Down:
                    return new[] { Direction.Up };
                default:
                    return new Direction[0];
            }
        }
    }
}
