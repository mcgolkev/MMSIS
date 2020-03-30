# MMSIS

A generic customer information system using C# business layer and front end with a SQL Server v18.4 database.

This is a work in process.

This application was originally developed as a generic Customer Information System as a local WinForm application. It is a standard 3 tier application that uses C# for the front end and business layer and a local SQL Server database.

The application is modular and is designed to be easily modified and changed to support various types of service businesses. The base functionality allows for contact information to be created and then classifying that contact as needed whether it be a customer, supplier, or administrative contact. Job objects are built into the base functionality and allow users to link contacts to jobs and input details about these jobs. Lookup functionality allows users to view and edit contact and job data.

I had created the database schema to allow for a much more broad definition of contact and to improve database normalization.

The application makes use of custom data access code and stored procedures rather than LINQ functionality.

Updates to the application will be posted as they occur.
