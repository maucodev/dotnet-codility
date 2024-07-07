namespace Codility._01_BinaryGap;

public static class BinaryGap
{
    public static int Solution(int n)
    {
        var longestBinaryGap = 0;
        var binaryRepresentation = Convert.ToString(n, 2);

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