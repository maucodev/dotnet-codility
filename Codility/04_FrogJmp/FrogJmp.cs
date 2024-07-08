// ReSharper disable InconsistentNaming

namespace Codility._04_FrogJmp;

using System;

public static class FrogJmp
{
    public static int Solution(int X, int Y, int D)
    {
        return (int)Math.Ceiling((double)(Y - X) / D);
    }
}