
class MinTimeToTypeSolution
{
    private const int CharCount = 26;
    public int minTimeToType(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        int stepCount = 0;
        int currentIndex = 0;
        int targetIndex = 0;

        for (int i = 0; i < word.Length; ++i)
        {
            targetIndex = word[i] - 'a';
            stepCount += CalculateSteps(currentIndex, targetIndex);
            currentIndex = targetIndex;
        }

        return stepCount;
    }

    private int CalculateSteps(int currentIndex, int targetIndex)
    {
        int delta = Math.Abs(targetIndex - currentIndex);
        if (delta > CharCount / 2)
        {
            delta = CharCount - delta;
        }
        return delta + 1;
    }
};