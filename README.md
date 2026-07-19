# Enterprise Inventory Management System (EIMS)

A production-oriented backend application built using modern .NET technologies, Clean Architecture, and Domain-Driven Design principles. This project is intended to simulate how enterprise-grade inventory systems are designed and implemented in real product companies.

---

## Overview

Enterprise Inventory Management System (EIMS) is a portfolio-quality backend application developed to demonstrate production-ready software engineering practices.

The project focuses on much more than implementing business features—it emphasizes software architecture, maintainability, scalability, and clean design. Every feature is developed incrementally while following industry best practices used in enterprise environments.

---

## Technology Stack

| Category | Technologies |
|-----------|--------------|
| Language | C# |
| Framework | .NET 9, ASP.NET Core Web API |
| Database | SQL Server |
| ORM | Entity Framework Core |
| Architecture | Clean Architecture |
| Design Principles | SOLID, Domain-Driven Design (DDD) |
| API | REST |
| Authentication | JWT *(Planned)* |
| Validation | FluentValidation *(Planned)* |
| Testing | xUnit *(Planned)* |
| Containerization | Docker *(Planned)* |

---

## Architecture

```
                API
              /     \
             ▼       ▼
     Application   Infrastructure
            │          │
            └────┬─────┘
                 ▼
               Domain
```

### Project Structure

```
src/
│
├── EIMS.API
│   ├── Controllers
│   ├── Middleware
│   └── Dependency Injection
│
├── EIMS.Application
│   ├── Commands
│   ├── Queries
│   ├── Interfaces
│   ├── DTOs
│   └── Validators
│
├── EIMS.Domain
│   ├── Entities
│   ├── Value Objects
│   ├── Enums
│   ├── Domain Events
│   └── Exceptions
│
└── EIMS.Infrastructure
    ├── Persistence
    ├── Repositories
    ├── Configurations
    └── External Services
```

---

## Current Progress

### Documentation

- [x] Business Domain Discovery
- [x] Vision Document
- [x] Functional Requirements Specification
- [x] Domain Model
- [x] Event Storming

### Project Setup

- [x] Solution Structure
- [x] Clean Architecture Setup
- [x] Project References
- [x] Git Repository

### Implementation

- [ ] Product Module
- [ ] Warehouse Module
- [ ] Supplier Module
- [ ] Purchase Orders
- [ ] Goods Receipt
- [ ] Inventory Management
- [ ] Stock Reservations
- [ ] Authentication & Authorization
- [ ] Audit Logging
- [ ] Docker Deployment

---

## Project Goals

- Build a production-ready backend application
- Apply Clean Architecture principles
- Practice Domain-Driven Design concepts
- Write maintainable and scalable code
- Follow SOLID principles throughout the project
- Prepare for enterprise backend engineering interviews
- Create a portfolio-quality .NET application

---

## Engineering Principles

This project follows the following engineering practices:

- Clean Code
- SOLID Principles
- DRY (Don't Repeat Yourself)
- KISS (Keep It Simple)
- YAGNI (You Aren't Gonna Need It)
- Dependency Injection
- Asynchronous Programming
- Domain-Driven Design
- RESTful API Design

---

## Repository Structure

```
Enterprise-Inventory-Management-System/
│
├── docs/
│
├── src/
│   ├── EIMS.API
│   ├── EIMS.Application
│   ├── EIMS.Domain
│   └── EIMS.Infrastructure
│
├── tests/
│
├── README.md
└── EIMS.slnx
```

---

## Development Roadmap

### Phase 1 – Project Foundation
- [x] Requirements Gathering
- [x] Domain Discovery
- [x] Event Storming
- [x] Solution Setup

### Phase 2 – Core Domain
- [ ] Product Management
- [ ] Warehouse Management
- [ ] Supplier Management

### Phase 3 – Inventory Operations
- [ ] Purchase Orders
- [ ] Goods Receipt
- [ ] Stock Transactions
- [ ] Inventory Tracking

### Phase 4 – Enterprise Features
- [ ] Authentication & Authorization
- [ ] Audit Trail
- [ ] Optimistic Concurrency
- [ ] Pagination & Filtering
- [ ] Global Exception Handling
- [ ] Logging

### Phase 5 – Production Readiness
- [ ] Unit Testing
- [ ] Integration Testing
- [ ] Docker
- [ ] CI/CD
- [ ] Monitoring

---

## Status

🚧 **Active Development**

The project is being developed incrementally using a feature-by-feature approach while maintaining production-quality architecture, comprehensive documentation, and enterprise software engineering practices.

---

## Author

**Bhaskar Soman**

Backend Software Engineer | C#/.NET Developer

---

> **Note:** This project is intended as a learning journey into enterprise backend software development. Every architectural decision, design pattern, and implementation is documented with an emphasis on understanding the rationale behind the approach rather than simply producing working code.