using System;
using System.Collections.Generic;
using System.Linq;
 
public partial class Program
{
    private static int countIt;
    public static List<int> MergePiles(List<List<int>> v) {

        List<int> ans = new List<int>();
 
        while (true)
        {
            
            int minu = int.MaxValue;
 
            int index = -1;
            for (int i = 0; i < v.Count; i++)
            {
            
                if (v[i].Any() && minu > v[i].Last()) {
                    minu = v[i].Last();
                    index = i;
                }
                countIt++;

            }
            if (index == -1) {
                break;
            }
 
            ans.Add(minu);
            v[index].RemoveAt(v[index].Count - 1);
            
            if (!v[index].Any()) {
                v.RemoveAt(index);
            }
            countIt++;
        }
 
        return ans;
        
    }
 
    public static List<int> PatienceSorting(List<int> arr) {
        List<List<int>> piles = new List<List<int>>();
 
        for (int i = 0; i < arr.Count; i++) {
            
            if (!piles.Any()) {
                List<int> temp = new List<int>();
                temp.Add(arr[i]);
                piles.Add(temp);
            } else {
                int flag = 1;
                for (int j = 0; j < piles.Count; j++) {
                    if (arr[i] < piles[j].Last()) {
                        piles[j].Add(arr[i]);
                        flag = 0;
                        break;
                    }
                    countIt++;
                }
                if (flag == 1) {
                    List<int> temp = new List<int>();

                    temp.Add(arr[i]);
                    piles.Add(temp);
                }
            }
            countIt++;
        }
 
        List<int> ans = MergePiles(piles);
 
        foreach (int num in ans) {
            Console.Write(num + " ");
        }
 
        return ans;
    }
 
    
}