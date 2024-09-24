# Collaborative Blogging Platform

This is a collaborative blog project where multiple users can create, edit, view and comment on posts. The application uses **ASP.NET Core** for the backend, **MySQL** as the database and Docker for containerization.

## Features

- Creation, reading, updating and deleting of posts and comments (CRUD).
- Authentication and authorization system with different access levels (Admin, Editor, Reader).
- Single Page Application (SPA) with complete integration between frontend and backend.
- Use of Docker to ensure environment consistency.

## Technologies Used

- **ASP.NET Core** (Backend)
- **MySQL** (Database)
- **Docker** (Containerization)
- **Swagger** for API documentation

## How to Set Up the Project

### Prerequisites

- **Git**: To clone the repository.
- **Docker** and **Docker Compose**: To run the containers.
- **.NET SDK 8.0** (if you want to run the project outside of Docker).

### Configuration Steps

1. **Clone the repository**:

Clone the project to your local directory:

```bash
git clone https://github.com/feeoliveira-oficial/CollaborativeBlog.git
cd CollaborativeBlog
