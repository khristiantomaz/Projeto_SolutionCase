
public class Solution {

    //Aqui criamos um check do subarray onde determinamos um dicionario para podermos calcular a soma do subarray.
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> dicSum = new Dictionary<int, int>();
        dicSum.Add(0, -1);
        int sum = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            //Aqui temos o método para calcular e ver se sum é ou não divisivel pela virante K 
            sum += nums[i]; 
            if(k == 0)
            {
                if(sum == k)
                 return true;
            }
            else
            {
                sum = sum % k;
                if(dicSum.ContainsKey(sum))
                {
                    if(dicSum[sum] < i - 1)
                     return true;
                }
                else
                 dicSum.Add(sum, i);
            }
        }
        return false;
    }
}

// aqui rodamos os exemplos para sabermos o resultado.
class Program {
    static void Main() {
        Solution solution = new Solution();

        // Exemplo 1
        int[] nums1 = { 23, 2, 4, 6, 7 };
        int k1 = 6;
        Console.WriteLine(solution.CheckSubarraySum(nums1, k1)); // Saída esperada: True

        // Exemplo 2
        int[] nums2 = { 23, 2, 6, 4, 7 };
        int k2 = 6;
        Console.WriteLine(solution.CheckSubarraySum(nums2, k2)); // Saída esperada: True

        // Exemplo 3
        int[] nums3 = { 23, 2, 6, 4, 7 };
        int k3 = 13;
        Console.WriteLine(solution.CheckSubarraySum(nums3, k3)); // Saída esperada: False
    }
}