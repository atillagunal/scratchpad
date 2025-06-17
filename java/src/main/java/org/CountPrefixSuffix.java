class CountPrefixSuffixSolution
{
    public int countPrefixSuffixPairs(String[] words)
    {
        int count = 0;

        if(words == null)
        {
            return count;
        }

        for(int i = 0; i < words.length - 1; ++i)
        {
            for(int j = i + 1; j < words.length; ++j)
            {
                if(isPrefixSuffix(words[i], words[j]))
                {
                    ++count;
                }
            }
        }

        return count;    
    }

    private boolean isPrefixSuffix(String str1, String str2)
    {
        if(str1 == null || str1.isEmpty())
        {
            return false;
        }
            
        return str2.startsWith(str1) && str2.endsWith(str1);
    }

    public static void main(String[] args)
    {
        CountPrefixSuffixSolution solution = new CountPrefixSuffixSolution();
        int count = solution.countPrefixSuffixPairs(new String[] {"a", "aba", "ababa", "aa"});
        System.out.println(count);
    }
}