# E-Tickets ASP.NET Core MVC

![Main Page](https://github.com/kareemosama/E-Tickets_ASPDotNetCoreMVC/blob/main/wwwroot/img/GitImages/MainPage.png)
![MovieList](https://github.com/kareemosama/E-Tickets_ASPDotNetCoreMVC/blob/main/wwwroot/img/GitImages/MovieList.png)
![Register](https://github.com/kareemosama/E-Tickets_ASPDotNetCoreMVC/blob/main/wwwroot/img/GitImages/Register.png)
![Cart](https://github.com/kareemosama/E-Tickets_ASPDotNetCoreMVC/blob/main/wwwroot/img/GitImages/Order.png)

## Table of Contents

- [About](#about)
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Link](#project-link)
- [References](#references)

## About

E-Tickets ASP.NET Core MVC is a dynamic web application built using ASP.NET Core MVC, offering users a seamless experience for buying and managing event tickets. This project provides a solid foundation for creating ticketing platforms and can be customized to fit specific requirements.

## Features

- **Event Ticket Purchase:** Easily browse and purchase tickets for various events.
- **User Registration:** Secure user accounts with a robust authentication system for ticket purchases.
- **Event Management:** Manage and update event details for a smooth user experience.
- **Shopping Cart:** Add tickets to a cart for convenient checkout.
- **Intuitive UI:** A clean and intuitive user interface for seamless navigation.

## Technologies

The project is primarily built using the following technologies:

- **ASP.NET Core MVC:** The server-side framework for building the web application.
- **C#:** The primary language for server-side logic.
- **Entity Framework Core:** A powerful ORM for interacting with the database.
  1. Code-First model for database interaction.
  2. Migrations for database schema updates.
- **MVC (Model-View-Controller):** The architectural pattern for organizing and managing the application's structure.
- **Repository Design Pattern:** A design pattern used to separate the logic that retrieves data from the underlying storage.
- **ASP.NET Core Identity:** A membership system that adds login functionality and user management to the application.
  1. Authentication and Authorization: Secure user authentication and authorization features.
  2. Role Management: Implement role-based access control for users.

## Getting Started

To get started with E-Tickets ASP.NET Core MVC, follow the [Getting Started](#getting-started) section in this README to set up your development environment and install the necessary dependencies.

### Prerequisites

Before you begin working with E-Tickets ASP.NET Core MVC, ensure that you have the following software installed on your machine:

- [.NET Core SDK](https://dotnet.microsoft.com/download): The framework required to build and run the application.
- [Visual Studio](https://visualstudio.microsoft.com/): A popular integrated development environment (IDE) for .NET applications.

### Installation

Follow these steps to set up and run E-Tickets ASP.NET Core MVC locally:

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/kareemosama/E-Tickets_ASPDotNetCoreMVC.git
   cd E-Tickets_ASPDotNetCoreMVC
   ```

2. **Restore Packages::**

   ```bash
   dotnet restore
   ```

3. **Update Database:**

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the Application:**

   ```bash
   dotnet run
   ```

# References

- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0):Official documentation for ASP.NET Core.
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/):Official documentation for Entity Framework Core.
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0&tabs=visual-studio):Official documentation for ASP.NET Core Identity.
