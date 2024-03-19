# Tasker
### Task Management System

## SUMMARY

1. [Objective](#objective)
2. [Requirements](#requirements)
3. [Packages To Install](#packages-to-install)
4. [Installing Packages](#installing-packages)
5. [SQL File](#sql-file)
6. [Key Features](#key-features)
7. [Additional Features](#additional-features)
8. [Security](#security)
9. [User Interface](#user-interface)
10. [Data Storage](#data-storage)
11. [Reports](#reports)
12. [Exceptions and Error Handling](#exceptions-and-error-handling)
13. [Non Functional Requirements](#non-functional-requirements)
14. [Use Cases](#use-cases)

## **Objective:**
Develop an application for task management that allows users to efficiently add, edit, and delete tasks.

## **Requirements**
This is a project built on `C#` Programming Language. `PostgreSQL` as the database. To add these pacakges you need a container image of postgreSQL or it be locally installed on your machine.

It is used a `.env` file with environment varibales. Please rename the file [.env.example](.env.example) to `.env`.

## **Packages To Install**
  1. DotNet.Net - To Read Environment Variables From .Env File;
  2. Npgsql - To Work With PostgreSQL;

## **Installing Packages:**
```bash
dotnet add package dotenv.net
```

```bash
dotnet add package Npgsql
```

## **SQL File**

Here is the link to a `.sql` file named `create_table`, import the file and compile it.
File: [create-table.sql](create_table.sql)

## **Key Features:**
- **Add Task:**
  Allow the user to enter task details such as title, description, priority, due date, etc.
  
- **Edit Task:**
  Enable the modification of details for an existing task.
  
- **Delete Task:**
  Allow the user to remove a specific task from the list.
  
- **List Tasks:**
  Display a list of all tasks, including details such as title, priority, and due date.

## **Additional Features:**
- **Task Sorting:**
  Allow the user to sort tasks based on different criteria, such as priority or due date.
  
- **Task Completion:**
  Add the ability to mark a task as completed.
  
- **Reminders:**
  Implement a reminder system to alert the user about tasks nearing the due date.

## **Security:**
Ensure that access to tasks is protected, possibly with user authentication to prevent unauthorized access.

## **User Interface:**
Develop an intuitive and user-friendly interface, either through a GUI or a console application.

## **Data Storage:**
Utilize a data storage system, such as a database or file storage, to persist task information between sessions.

## **Reports:**
Implement the ability to generate reports on task progress, such as completed and pending tasks.

## **Exceptions and Error Handling:**
Include mechanisms to handle unexpected situations, such as invalid input or database access failure.

## **Non-Functional Requirements:**
- **Performance:**
  Ensure that the system is responsive, even with a large volume of tasks.
  
- **Usability:**
  Prioritize a user-friendly and easily understandable interface.

## **Use Cases:**
- **Add Task:**
  - *Primary Actor:* User
  - *Description:* The user adds a new task with details such as title, description, priority, and due date.
  
- **Edit Task:**
  - *Primary Actor:* User
  - *Description:* The user selects an existing task and modifies its details, such as title, description, or due date.
  
- **Delete Task:**
  - *Primary Actor:* User
  - *Description:* The user removes a specific task from the list.
  
- **List Tasks:**
  - *Primary Actor:* User
  - *Description:* The user views the list of all registered tasks, including relevant details.
  
- **Sort Tasks:**
  - *Primary Actor:* User
  - *Description:* The user chooses a criterion (priority, due date, etc.) to sort the task list.
  
- **Complete Task:**
  - *Primary Actor:* User
  - *Description:* The user marks a task as completed.
  
- **Set Reminder:**
  - *Primary Actor:* User
  - *Description:* The user defines a reminder for a specific task.
  
- **Generate Report:**
  - *Primary Actor:* User
  - *Description:* The user requests and views reports on the status and progress of tasks.
