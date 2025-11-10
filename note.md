# My Note for Big O Analysis exercises

## Q2

- Console.Writeline(...): constant work
- Outer Loop: runs n times
- Inner Loop: runs fewer times as i gets bigger
  - Each time runs: n, n-1, n-2, ..., 1.
  - Total iterations: n(n+1)/2 = n$^{2}$
- Time Complexity: O(n$^{2}$)
  > Key Idea: Even though the inner loop does less work as i increases, the total still grows like n$^{2}$.
