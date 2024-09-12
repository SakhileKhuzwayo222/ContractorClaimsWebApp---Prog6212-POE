This repository contains the code for the Contract Monthly Claim System (CMCS), a web-based application that facilitates the submission and tracking of work claims by lecturers. The system manages core data entities such as lecturers, claims, and optional detailed work hour entries. It is built with ASP.NET and utilizes Entity Framework Core for database management and ORM (Object Relational Mapping).

Core Features
Lecturer Management: Allows lecturers to register and submit claims for work done.
Claim Submission: Lecturers can submit claims for hours worked, with an optional attachment for supporting documents.
Detailed Work Hours Tracking: Optional feature to log specific work dates and hours for each claim.
Entity Framework Integration: The project uses Entity Framework Core for database interaction, ensuring proper handling of relationships between lecturers and their claims.
Key Classes
Lecturer: Represents a lecturer in the system, storing basic details and linking them to multiple claims.
Claim: Represents a work claim submitted by a lecturer, capturing hours worked, rate, and submission date.
HoursWorked (Optional): Stores detailed records of work hours, tracking specific dates and hours for each claim.
How to Use
Add the Lecturer, Claim, and optional HoursWorked classes to the Models folder in the project.
Define relationships using Entity Framework to ensure the lecturer-claim structure is mapped in the database.
Use the DbContext to handle interactions with the database, allowing for smooth submission and retrieval of data within the application.
This system streamlines the process of submitting and managing monthly work claims, providing an intuitive and efficient solution for contract work tracking.

You said:
Write a readme for this project
ChatGPT said:
ChatGPT
Contract Monthly Claim System (CMCS)
The Contract Monthly Claim System (CMCS) is a web application built with ASP.NET Core, designed to simplify the process of submitting, managing, and tracking monthly work claims by lecturers. It allows lecturers to log hours worked, submit claims, and attach supporting documents, providing a streamlined and efficient way for institutions to handle contract claims.

Table of Contents
Features
Technology Stack
Getting Started
Database Configuration
Models Overview
Usage
Contributing
License
Features
Lecturer Management: Store details for each lecturer, including first name, last name, department, and email.
Claim Submission: Lecturers can submit claims for hours worked with rate per hour, including the ability to attach supporting documents (e.g., PDF invoices).
Work Hours Tracking: Optional detailed tracking of specific dates and hours worked.
Entity Framework Core Integration: Automatic database management with relationships between lecturers, claims, and optional detailed hours worked.
User Interface: A simple GUI for lecturers to submit and review claims.
Technology Stack
ASP.NET Core: The main framework for building the web application.
Entity Framework Core: ORM used to manage database interactions.
SQL Server: The database for storing lecturer and claim information.
C#: Programming language used for the backend logic.
HTML/CSS: For building the frontend user interface.
Getting Started
Prerequisites
.NET SDK (latest version)
SQL Server (or another database provider compatible with EF Core)
Visual Studio (or any other IDE compatible with .NET Core development)
