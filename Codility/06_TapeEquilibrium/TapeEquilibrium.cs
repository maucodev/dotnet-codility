// ReSharper disable InconsistentNaming

using System;
using System.Linq;

namespace Codility._06_TapeEquilibrium;

public static class TapeEquilibrium
{
    public static int Solution(int[] A)
    {
        var totalSum = A.Sum();
        var leftSum = 0;
        var rightSum = totalSum;
        var minDifference = int.MaxValue;

        for (var i = 0; i < A.Length - 1; i++)
        {
            leftSum += A[i];
            rightSum -= A[i];

            var difference = Math.Abs(leftSum - rightSum);

            if (difference < minDifference)
            {
                minDifference = difference;
            }
        }

        return minDifference;
    }
}