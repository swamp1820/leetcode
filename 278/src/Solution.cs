using Common;
namespace src;

public class Solution : VersionControl
{

    public int FirstBadVersion(int n)
    {
        int maxBadVersion = int.MaxValue;
        int minBadVersion = 0;
        while (minBadVersion < maxBadVersion)
        {
            // если версия плохая 
            if (IsBadVersion(n))
            {
                // проверим предыдущую
                if (!IsBadVersion(n - 1))
                {
                    return n;
                }
                else
                {
                    maxBadVersion = n - 1;
                }
            }
            // если версия хорошая - минимальная плохая версия это n+1
            else
            {
                minBadVersion = n + 1;
            }
            n = (minBadVersion + (maxBadVersion - minBadVersion) / 2);
        }

        return n;

    }
}

public class VersionControl
{
    private int badVersion = 4;
    public bool IsBadVersion(int version)
    {
        if (version >= badVersion)
        {
            return true;
        }

        return false;
    }
}