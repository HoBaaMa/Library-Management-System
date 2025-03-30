## Overview

The **Library Management System** is an object-oriented programming (OOP) project designed to manage library operations, including book management, user management, borrowing and returning books, and logging activities. The system is implemented in C# and follows modular principles for scalability and maintainability.

This project adheres to the **SOLID principles** to ensure clean, maintainable, and extensible code:

- **S**ingle Responsibility Principle: Each class has a single, well-defined purpose (e.g., `Book`, `Library`, `LibraryCard`, `User`, `BooksLog`, etc.).
- **O**pen/Closed Principle: Classes are open for extension but closed for modification (e.g., the `LogBase` class allows creating specific logs like `BooksLog` and `EventLogger` without altering the base class).
- **L**iskov Substitution Principle: Derived classes can substitute their base classes without affecting the system (e.g., `Librarian` and `LibraryUser` extending `User`).
- **I**nterface Segregation Principle: Interfaces or base classes are designed to include only the methods relevant to their use cases.
- **D**ependency Inversion Principle: High-level modules depend on abstractions rather than concrete implementations (e.g., `BooksLog` uses `EventLogger` as a dependency for logging events).

---

## Features

- **Book Management**: Add, remove, and display books in the library.
- **User Management**: Manage library users, including regular users and librarians.
- **Library Card**: Track borrowed books and user activities using a library card system.
- **Logging**: Log important events like book additions, removals, and user activities.
- **UML Design**: Accompanied by a UML diagram for better understanding of the system's architecture.

---

## File Structure

### Main Files and Classes:

1. **Book.cs**: Handles the `Book` class, which contains properties like title, author, year, and ISBN.
2. **Library.cs**: Contains core functionality for managing the library's books and operations.
3. **LibraryCard.cs**: Represents a library card for users, tracking borrowed books.
4. **LibraryUser.cs**: Handles regular user-related functionalities.
5. **Librarian.cs**: Implements the functionalities specific to the librarian.
6. **User.cs**: Base class for common properties and methods shared between users and librarians.
7. **Program.cs**: Entry point for the application, containing the `Main` method.
8. **Logs**: Contains logging logic for tracking system operations.
   - `BooksLog.cs`: Logs book-related activities (e.g., adding and removing books).
   - `EventLogger.cs`: Logs general events like operations and errors.

---

## UML Diagram

The project includes a UML diagram (`UML Diagram.drawio`) to visualize the relationships between classes and the overall system structure.

---

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/your-repo/LibraryManagementSystem.git
   ```
2. Open the project in Visual Studio or your preferred IDE.
3. Build and run the solution.

---

## Usage

### Adding a Book:
1. Open the application.
2. Enter book details (title, author, year, ISBN).
3. The system adds the book and logs the activity.

### Removing a Book:
1. Select a book from the list.
2. Confirm the removal.
3. The system removes the book and logs the activity.

### Displaying Books:
- View the list of all available books.

### Borrowing and Returning Books:
1. Assign books to users through the library card system.
2. Log each borrowing and returning activity.

---

## Logging

- **BooksLog**: Tracks all operations related to books, such as additions and deletions.
- **EventLogger**: Logs events with timestamps and details about operations performed.

Logs are stored in the `/Logs` directory:
- `booksLog.txt`
- `eventsLog.txt`

---

## Contributions

Feel free to fork the repository, make changes, and create pull requests.

---

## Author

Developed by a passionate software engineering student for learning OOP concepts in C# and applying SOLID principles.

---