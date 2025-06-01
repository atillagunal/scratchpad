public class BinarySearch
{
    public int Search(int[] array, int value)
    {
        if (array == null)
        {
            return -1;
        }

        return Search(array, 0, array.Length - 1, value);
    }

    private int Search(int[] array, int start, int end, int value)
    {
        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (array[mid] == value)
            {
                return mid;
            }

            if (value < array[mid])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return -1;
    }
}