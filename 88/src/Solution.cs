namespace src;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m-1; // итератор первого массива
        int j = n-1; // итератор второго массива
        int k = (n+m)-1; // итератор общего массива
        
        // перебираем общий (первый) массив справа налево
        while (k>=0)
        {
            // если второй массив 0 или перемещен - оставляем первый как есть
            if (j<0)
            {
                break;
            }
            // если первый массив остался пустой или перемещен - копируем второй (исключив перемещенные значения) в него
            else if (i<0)
            {
                nums2.Take(j+1).ToArray().CopyTo(nums1,0);
                break;
            }   


            if (nums1[i]>nums2[j])
            {
                nums1[k]=nums1[i];
                // если переместили - затираем старое значение
                if (k!=i)
                {
                    nums1[i]=0;
                }
                i--;
            }
            else if (nums1[i]<nums2[j])
            {
                nums1[k]=nums2[j];
                j--;
            }
            else if (nums1[i]==nums2[j])
            {
                nums1[k]=nums2[j];
                j--;
                k--;
                nums1[k]=nums1[i];
                // если переместили - затираем старое значение
                if (k!=i)
                {
                    nums1[i]=0;
                }
                i--;
            }

            k--;
        }
    }

   

}