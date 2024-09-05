# solução de case de subarray 

Para este projeto tive que calcular qual método de algoritmo usar, por exemplo O(N^2) ou O(N), depois de muito estudar e pensar cheguei a conclusão de usar o algoritmo O(N^2) para um processo mais rápido e com uma performance melhor. 
## Propósito pedido: Soma de um Subarray contínuo 
Dado um array inteiro nums e um inteiro k, return if tem um bom subarray ou não.
Um bom subarray é um subarray onde:
•	o seu comprimento é de pelo menos dois, e
•	A soma dos elementos do subarray é um múltiplo de .k
Observe que:
•	Um subarray é uma parte contígua do array.
•	Um inteiro é um múltiplo de se existe um inteiro tal que . é sempre um múltiplo de .x k n x = n * k0k
## Dados de entrada e saídas pedidos 
Exemplo 1:
Input: nums = [23,2,4,6,7], k = 6
Output: true
Explanation: [2, 4] is a continuous subarray of size 2 whose elements sum up to 6.
Exemplo 2:
Input: nums = [23,2,6,4,7], k = 6
Output: true
Explanation: [23, 2, 6, 4, 7] is an continuous subarray of size 5 whose elements sum up to 42.
42 is a multiple of 6 because 42 = 7 * 6 and 7 is an integer.
Exemplo 3:
Input: nums = [23,2,6,4,7], k = 13
Output: false

## Restrições dadas 

Neste projetos seguimos com estas restrições onde não pode o correr:

1 <= nums.length <= 105
0 <= nums[i] <= 109
0 <= sum(nums[i]) <= 231 - 1
1 <= k <= 231 - 1

##### considerações finais

Gostaria de estar deixando minhas redes para contato, aonde falo mais sobre tecnologia. 

- Email: khristiantomaz@icloud.com
- linkedin: linkedin.com/in/khristian-tomaz/
