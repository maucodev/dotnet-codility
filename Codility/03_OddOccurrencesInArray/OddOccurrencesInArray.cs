// ReSharper disable InconsistentNaming

namespace Codility._03_OddOccurrencesInArray;

public static class OddOccurrencesInArray
{
    public static int Solution(int[] A)
    {
        var unpairedElement = 0;

        foreach (var number in A)
        {
            unpairedElement ^= number;
        }

        return unpairedElement;
    }
}