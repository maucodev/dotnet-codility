// ReSharper disable InconsistentNaming

namespace Codility._01_BinaryGap;

using System;

public static class BinaryGap
{
    public static int Solution(int N)
    {
        var longestBinaryGap = 0;
        var binaryRepresentation = Convert.ToString(N, 2);

        var countingBinaryGap = false;
        var currentBinaryGapLength = 0;

        foreach (var c in binaryRepresentation)
        {
            if (c == '1')
            {
                if (countingBinaryGap)
                {
                    if (currentBinaryGapLength > longestBinaryGap)
                    {
                        longestBinaryGap = currentBinaryGapLength;
                    }

                    currentBinaryGapLength = 0;
                }

                countingBinaryGap = true;
            }
            else if (c == '0' && countingBinaryGap)
            {
                currentBinaryGapLength++;
            }
        }

        return longestBinaryGap;
    }
}