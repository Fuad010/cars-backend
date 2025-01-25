# 🚀 Technologies & Architecture Used

### Backend:
- **Clean Architecture**: Structured, maintainable, and scalable architecture pattern.
- **ASP.NET Core .NET 6**: A powerful framework for building web applications and APIs.
- **REST API**: A stateless architectural style for designing networked applications.
- **MediatR**: A simple mediator pattern implementation for handling requests and responses.
- **CQRS (Command Query Responsibility Segregation)**: Separating reading and writing operations for better scalability and optimization.
- **Entity Framework Core**: ORM for data access and database management.
- **AutoMapper**: Object-to-object mapping library for simplifying data transformations.
- **Fluent Validation**: A validation library for .NET to create clean, readable validation rules.
- **SQLite**: Lightweight, serverless, self-contained SQL database engine.

### Frontend:
- **React + Vite**: Lightning-fast development environment with optimized build capabilities.
- **Feature-Sliced Design (FSD)**: A structured and scalable approach for organizing frontend code.
- **MobX**: Simple and scalable state management for React applications.
- **KY**: A lightweight and modern HTTP client for making API requests.
- **React Router**: Declarative routing for React applications to manage navigation.
- **TypeScript**: Static typing to improve code quality and developer experience.

---

## 🛠️ How to Run the Application

### Prerequisites:
1. Install [Node.js](https://nodejs.org/) (for frontend).
2. Install [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (for backend).

---

### 1. Run the Backend
The backend is powered by ASP.NET Core Web API. Follow these steps to start it:

1. Open your terminal or IDE.
2. Navigate to the project folder containing `Cars.WebApi`.
3. Run the following command to start the backend:
   ```bash
   dotnet run --project Cars.WebApi

## 🔄 Important Note:
The frontend communicates with the backend API. Ensure that the backend is running before starting the frontend. You may need to configure the base URL for API requests in the frontend's environment configuration file.

1. Create a `.env` file in the frontend root directory (if it doesn't exist).
2. Add the following configuration to the `.env` file:
   ```env
   VITE_API_BASE_URL=http://localhost:5000
3. Install the required dependencies by running the following command:
   ````
   npm install
4. After installing the dependencies, run the following command to start the frontend:
   ````
   npm run dev
    
