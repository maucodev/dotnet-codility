// ReSharper disable InconsistentNaming

namespace Codility._02_CyclicRotation;

public static class CyclicRotation
{
    public static int[] Solution(int[] A, int K)
    {
        var n = A.Length;

        if (n == 0)
        {
            return A;
        }

        // Normalizing K means adjusting it so that it falls within the bounds of the array size N.
        // In de context of rotating an array, if K is greater than N, performing K rotations is essentially the same
        // as performing K mod N rotations. This is due to the cyclic nature of rotation: after every N rotations,
        // the array returns to its original position.
        K %= n;

        if (K == 0)
        {
            return A;
        }

        var rotatedArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            // The operation % ensures the index wraps around within the bounds of the array size n,
            // effectively handling cases where i + K exceeds n. This operation ensures the rotated index remains
            // within the valid range [0, n-1], simulating the cyclic nature of array rotation.
            var index = (i + K) % n;

            rotatedArray[index] = A[i];
        }

        return rotatedArray;
    }
}