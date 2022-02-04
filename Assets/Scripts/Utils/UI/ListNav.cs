public class ListNav
{
    public static int SetIndex(int maxIndex, int nextIndex)
    {
        if (nextIndex == -1)
        {
            return maxIndex - 1;
        }
        else
        {
            if (nextIndex > maxIndex - 1)
            {
                return 0;
            }
            else
            {
                return nextIndex;
            }
        }

    }
}
