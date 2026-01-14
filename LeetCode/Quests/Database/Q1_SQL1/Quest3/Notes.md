# LeetCode SQL 1
## Quest 3
Not Boring Movies

## Thought Process
- Given 1 tables, Return non "boring" movies
- look through only odd number Ids
- Order by ratting
- Any entry where description is not boring
- Removing boring is easy as this is just a where clause
- Ordering by rating is easy as this is just an order by desc
- Modulus does work, but it does not feel like the right way to do it.
- Iteration one will use Modulus.

## Solutions
-  MS SQL Server
    - FileName: MsSqlSolution.sql
    - Notes:
        - With thinking this through, I couldn't think of a better wway than modulus.
        - Strings are encapsulated by single quotes

## Statistics
According to LeetCode Runtime Analysis.
- MS SQL Server
    - Runtime - 247 MS
