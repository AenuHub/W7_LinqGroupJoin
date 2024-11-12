## W7_LinqGroupJoin

This project is aiming to demonstrate the use of LINQ Group Join for associating students with their respective classes.

## Project Overview

The system includes the following components:

- **Students Table**: Stores student information, including a unique `StudentId`, `StudentName`, and `ClassId` to indicate the class the student belongs to.
- **Classes Table**: Contains class information with a unique `ClassId` and `ClassName`.

## Implementation

1. **Classes**:
    - `Student`: Represents the structure of the **Students** table.
    - `Class`: Represents the structure of the **Classes** table.

2. **LINQ Group Join**:
    - A LINQ group join operation is performed to associate each class with its students, resulting in a list of students grouped under their respective class.

3. **Output**:
    - The result of the LINQ query is printed to display each class name along with the names of students enrolled in that class in a readable format.

## Notes

- The project demonstrates the use of LINQ’s group join operation for organizing relational data.
- The output format presents each class along with the names of its students in an organized way.