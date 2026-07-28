# CTS Deep Skilling – .NET FSE

This repository contains the mandatory hands-on exercises, practical implementations, and assessment results completed as part of the **Cognizant (CTS) Digital Nurture 5.0 Deep Skilling Program – .NET Full Stack Engineer (FSE)** track.

The exercises are organized week-wise and cover Design Principles and Patterns, Data Structures and Algorithms, Advanced SQL, NUnit and Moq, Entity Framework Core, ASP.NET Core Web API, Microservices, Angular, Git, Docker, and Generative AI assessments.

---

## Week 1 – Core Programming and Testing Concepts

### Design Principles and Patterns

- Exercise 1: Implementing the Singleton Pattern
- Exercise 2: Implementing the Factory Method Pattern

### Data Structures and Algorithms

- Exercise 2: E-commerce Platform Search Function
- Exercise 7: Financial Forecasting

### Advanced SQL

- Ranking and Window Functions
- Stored Procedures
- Creating a Stored Procedure
- Returning Data from a Stored Procedure

### NUnit and Moq

- NUnit Hands-on Exercises
- Writing Testable Code with Moq

### Topics Covered

- Design Principles
- Design Patterns
- Singleton Pattern
- Factory Method Pattern
- Data Structures and Algorithms
- Searching Techniques
- Recursion
- SQL Window Functions
- Stored Procedures
- Unit Testing
- Mocking with Moq

---

## Week 2 – Entity Framework Core 8.0

Hands-on exercises covering Object-Relational Mapping (ORM), database configuration, migrations, data insertion, and data retrieval using Entity Framework Core.

### Hands-on Exercises

- Lab 1: Understanding ORM with a Retail Inventory System
- Lab 2: Setting Up the Database Context for a Retail Store
- Lab 3: Using EF Core CLI to Create and Apply Migrations
- Lab 4: Inserting Initial Data into the Database
- Lab 5: Retrieving Data from the Database

### Topics Covered

- Object-Relational Mapping (ORM)
- Entity Framework Core
- DbContext
- Entity Models
- Database Configuration
- EF Core Migrations
- Data Insertion
- Data Retrieval
- LINQ

---

## Week 3 – ASP.NET Core 8.0 Web API

Hands-on exercises focused on developing RESTful services using ASP.NET Core Web API.

### Web API Hands-on

- Web API Hands-on 1
- Web API Hands-on 2
- Web API Hands-on 3
- Web API Hands-on 4
- Web API Hands-on 5
- Web API Hands-on 6

### Topics Covered

- ASP.NET Core Web API
- Controllers
- Routing
- HTTP Methods
- RESTful Services
- Swagger / OpenAPI
- API Testing
- Request and Response Handling
- Exception Handling

---

## Week 4 – Microservices

Hands-on exercises focused on understanding and implementing Microservices Architecture using ASP.NET Core Web API.

### Topics Covered

- Microservices Architecture
- Building Microservices using ASP.NET Core Web API
- REST-based Service Communication
- Independent Services
- JWT Authentication
- Authentication and Authorization
- Securing ASP.NET Core Web APIs

---

## Week 5 – Angular

Hands-on exercises covering Angular application development through a **Student Course Portal**.

The Student Course Portal was progressively developed to demonstrate both fundamental and advanced Angular concepts.

### Angular Hands-on

- Environment Setup and Angular Project Structure
- Angular Components
- Data Binding
- Lifecycle Hooks
- Component Communication
- Directives and Pipes
- Template-Driven Forms
- Reactive Forms
- Services and Dependency Injection
- Angular Routing
- Route Guards and Lazy Loading
- HttpClient and API Integration
- RxJS and Observables
- NgRx State Management
- Unit Testing with Jasmine and Karma

### Student Course Portal Features

- Student Dashboard
- Course Catalog
- Course Search
- Course Enrollment
- Template-Driven Enrollment Form
- Reactive Enrollment Form
- Student Profile
- Enrolled Courses
- Mock REST API Integration
- Shared Angular Services
- Application Routing
- NgRx Store Integration
- Unit Testing and Code Coverage

### Technologies and Concepts

- Angular
- TypeScript
- Components
- `@Input` and `@Output`
- Lifecycle Hooks
- Directives
- Pipes
- Template-Driven Forms
- Reactive Forms
- FormGroup
- FormBuilder
- FormArray
- Validators
- Services
- Dependency Injection
- Angular Router
- Lazy Loading
- HttpClient
- Observables
- RxJS
- HTTP Interceptors
- NgRx Store
- Actions
- Reducers
- Effects
- Selectors
- Jasmine
- Karma
- TestBed
- JSON Server

The Angular application was also tested using Jasmine and Karma, with **11 specs passing and 0 failures**.

---

## Week 6 – Git

Hands-on exercises covering Git and version control.

### Git Hands-on

- Git HOL 1
- Git HOL 2
- Git HOL 3
- Git HOL 4
- Git HOL 5

### Topics Covered

- Git Fundamentals
- Repository Initialization
- Staging and Commits
- Branching
- Merging
- Merge Conflict Resolution
- Git Workflows
- Remote Repositories
- GitHub Integration
- Version Control Best Practices

---

## Week 7 – Docker and GenAI Assessments

Week 7 contains hands-on practice with **Docker** along with **Generative AI (GenAI) quiz assessment results**.

### Docker Hands-on

Docker hands-on practice covers fundamental containerization concepts and Docker resource management.

#### Topics Covered

- Docker Installation Verification
- Docker Engine
- Docker Images
- Docker Containers
- Pulling Images from Docker Hub
- Creating and Running Containers
- Executing Linux Commands inside Containers
- Viewing Docker Images and Containers
- Stopping Containers
- Removing Containers
- Removing Docker Images
- Docker Desktop
- Basic Containerization Workflow

#### Docker Commands Practiced

```bash
docker version
docker pull ubuntu
docker images
docker run -it --name ubuntu-practice ubuntu
pwd
ls
cat /etc/os-release
echo "Hello Docker"
exit
docker ps -a
docker stop ubuntu-practice
docker rm ubuntu-practice
docker rmi ubuntu
```

### Generative AI Quiz Assessments

Week 7 also contains the results of the **Generative AI (GenAI) quizzes** completed at different difficulty levels.

#### GenAI Quiz Levels

- Beginner Level
- Intermediate Level
- Advanced Level

The corresponding quiz-result screenshots are included in the Week 7 folder as proof of completion.

---

## Technologies and Concepts Covered

### Backend

- C#
- .NET
- ASP.NET Core 8.0
- ASP.NET Core Web API
- Entity Framework Core 8.0
- REST APIs
- Microservices Architecture
- JWT Authentication

### Frontend

- Angular
- TypeScript
- HTML
- CSS
- RxJS
- NgRx

### Database

- SQL
- Advanced SQL
- Entity Framework Core
- LINQ

### Testing

- NUnit
- Moq
- Jasmine
- Karma
- Angular TestBed

### DevOps and Version Control

- Git
- GitHub
- Docker
- Docker Desktop

### Generative AI

- Generative AI Fundamentals
- Beginner-Level GenAI Assessment
- Intermediate-Level GenAI Assessment
- Advanced-Level GenAI Assessment

### Programming and Software Engineering Concepts

- Data Structures and Algorithms
- Design Principles
- Design Patterns
- Object-Oriented Programming
- Dependency Injection
- RESTful Architecture
- State Management
- Containerization

---

## Repository Structure

```text
CTS-Deep-Skilling/
│
├── Week-1/
│   ├── Design-Principles-and-Patterns/
│   ├── Data-Structures-and-Algorithms/
│   ├── Advanced-SQL/
│   └── NUnit-and-Moq/
│
├── Week-2/
│   └── Entity-Framework-Core/
│
├── Week-3/
│   └── ASP.NET-Core-Web-API/
│
├── Week-4/
│   └── Microservices/
│
├── Week-5/
│   └── Angular/
│
├── Week-6/
│   └── Git/
│
├── Week-7/
│   ├── Docker/
│   └── GenAI-Quiz-Results/
│       ├── Beginner/
│       ├── Intermediate/
│       └── Advanced/
│
└── README.md
```

---

## Learning Outcomes

Through the Cognizant Digital Nurture Deep Skilling Program, I gained hands-on experience in:

- Applying software Design Principles and Design Patterns
- Solving problems using Data Structures and Algorithms
- Writing advanced SQL queries and stored procedures
- Writing unit tests using NUnit and Moq
- Performing database operations using Entity Framework Core
- Developing RESTful APIs using ASP.NET Core Web API
- Understanding Microservices Architecture
- Implementing JWT-based authentication
- Developing frontend applications using Angular
- Building template-driven and reactive Angular forms
- Implementing Angular routing and lazy loading
- Integrating REST APIs using Angular HttpClient
- Working with Observables and RxJS
- Managing application state using NgRx
- Testing Angular applications using Jasmine and Karma
- Using Git and GitHub for version control
- Working with Docker images and containers
- Managing Docker resources using CLI and Docker Desktop
- Understanding basic containerization workflows
- Completing Beginner, Intermediate, and Advanced Generative AI quizzes

---

## About

This repository documents my practical work and learning progress during the **Cognizant Digital Nurture 5.0 – .NET Full Stack Engineer Deep Skilling Program**.

Each week contains the corresponding hands-on implementations, source code, outputs, screenshots, documentation, and assessment results completed during the program.
