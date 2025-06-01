public class ConvertArrayTo2dSolution {
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();

        if(nums == null)    
        {
            return result;
        }

        int numsLength = nums.Length;
        int usedNumCount = 0;
        bool[] processedTracker = new bool[numsLength];

        while(usedNumCount < numsLength)
        {
            HashSet<int> usedNums = new HashSet<int>();
            List<int> localResult = new List<int>();

            for(int i = 0; i < numsLength; ++i)
            {
                if(processedTracker[i] == false)
                {
                    if(usedNums.Contains(nums[i]) == false)
                    {
                        processedTracker[i] = true;
                        localResult.Add(nums[i]);
                        usedNums.Add(nums[i]);
                    }
                }
            }

            usedNumCount += localResult.Count;

            result.Add(localResult);
        }

        return result;
    }
}