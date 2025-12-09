
Algorithm

Question: Write a short c# console application that takes the name of a student and multiple scores. Output the scores in a tabular form. as well as the total score of that student.

1. Break the problem into small tasks — split into four clear responsibilities:

* get the student name,

* get how many scores,

* collect the scores,

* print the table and total.

2. Turn each task into a method — create GetStudentName(), GetScoreCount(), GetScores(int), and PrintScoreTable(...) so each piece is short and testable.

3. Decide how to store scores — use List<int> so we can add items dynamically and loop easily.

4. Add input validation — use int.TryParse inside loops to repeatedly prompt until the user types a valid number (prevents crashes and teaches good practice).

5. Implement the collection loop — for count iterations ask for a score, validate it, then scores.Add(score).

6. Format the output simply — print a header, then loop through scores printing index + score; accumulate total while printing.
