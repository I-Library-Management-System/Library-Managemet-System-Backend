# 📚 Library Management System – Backend API

## 🚀 Overview

This project is a RESTful Web API built using **ASP.NET Core 8**, **Entity Framework Core**, and **SQLite**.  
It provides full CRUD functionality for managing book records in a Library Management System.

The backend follows a **Layered Architecture** pattern to ensure clean separation of concerns, maintainability, and scalability.

---

## 🏗 Architecture

The project uses a structured layered architecture:

```
Controller → Service → Data (DbContext) → SQLite Database
            ↓
           DTO
            ↓
          Mapper
            ↓
        Middleware
```

### Layers Explanation

- **Controller** – Handles HTTP requests and responses
- **Service** – Contains business logic
- **Data** – Entity Framework DbContext
- **DTO** – Data Transfer Objects for API communication
- **Mapper** – Converts between Entity and DTO
- **Middleware** – Global exception handling

---

## 🛠 Technologies Used

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQLite Database
- Swagger / OpenAPI
- CORS Configuration
- DataAnnotations Validation

---

## 📦 Project Structure

```
api/
├── Controller/
├── Service/
├── Data/
├── Dto/
├── Mapper/
├── Middleware/
├── Model/
├── Migrations/
├── Program.cs
```

---

## 🗄 Database

The system uses **SQLite** as the database engine.

### Book Entity Fields

| Field       | Type      | Description |
|------------|-----------|------------|
| Id         | int       | Primary key |
| Title      | string    | Book title |
| Author     | string    | Book author |
| Description| string?   | Optional description |
| CreatedAt  | DateTime  | Creation timestamp |
| UpdatedAt  | DateTime? | Last updated timestamp |

Entity Framework **Migrations** were used to generate the database schema.

---

## 🌐 API Endpoints

Base URL:

```
http://localhost:5112/api/Books
```

| Method | Endpoint              | Description |
|--------|----------------------|-------------|
| GET    | /api/Books           | Get all books |
| GET    | /api/Books/{id}      | Get book by ID |
| POST   | /api/Books           | Create new book |
| PUT    | /api/Books?id=1      | Update existing book |
| DELETE | /api/Books?id=1      | Delete book |

---

## ⚠ Error Handling

- Global `ExceptionMiddleware` handles unhandled exceptions
- Proper HTTP status codes are returned:
  - 200 OK
  - 201 Created
  - 204 No Content
  - 400 Bad Request
  - 404 Not Found
  - 500 Internal Server Error
- Model validation is handled using **DataAnnotations**

---

## ▶ How to Run the Backend

### 1️⃣ Navigate to API folder

```bash
cd api
```

### 2️⃣ Restore packages

```bash
dotnet restore
```

### 3️⃣ Apply migrations (if needed)

```bash
dotnet ef database update
```

### 4️⃣ Run application

```bash
dotnet run
```

---

## 📄 Swagger Documentation

After running:

```
http://localhost:5112/swagger
```

---

## 🧠 Key Concepts Implemented

- RESTful API Design
- Clean Layered Architecture
- DTO Pattern
- Entity–DTO Mapping
- Dependency Injection
- Async/Await Pattern
- SQLite Integration
- Global Exception Handling
- CORS Policy Configuration

---

## 📌 Author

Nawanjana Oshadi
