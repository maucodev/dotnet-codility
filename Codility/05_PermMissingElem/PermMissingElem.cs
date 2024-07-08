// ReSharper disable InconsistentNaming

namespace Codility._05_PermMissingElem;

public static class PermMissingElem
{
    public static int Solution(int[] A)
    {
        var n = A.Length;
        var expectedSum = (long)(n + 1) * (n + 2) / 2;
        
        long inputSum = 0;

        foreach (var value in A)
        {
            inputSum += value;
        }

        return (int)(expectedSum - inputSum);
    }
}