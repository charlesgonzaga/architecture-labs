# 001 - Clean Architecture

## Objetivo

Demonstrar uma implementação de Clean Architecture clássica utilizando:

- Domain-Driven Design (DDD)
- Application Services
- Repository Pattern
- Entity Framework Core
- Testes de Integração
- Testes de Arquitetura

## Arquitetura

```text
API
 ↓
Application Services
 ↓
Domain
 ↓
Repositories
 ↓
Infrastructure
```

## Tecnologias

- .NET 8
- ASP.NET Core
- Entity Framework Core
- EF Core InMemory
- xUnit
- FluentAssertions
- NetArchTest

## Funcionalidades

- Criar cliente
- Consultar cliente por Id

## Endpoints

### Criar cliente

POST `/api/customers`

```json
{
  "name": "Charles Gonzaga",
  "email": "charles@labs.com"
}
```

### Consultar cliente

GET `/api/customers/{id}`

## Persistência

Este exemplo utiliza o provedor `EF Core InMemory`.

O objetivo é reduzir dependências externas e manter o foco nos conceitos arquiteturais.

Não é necessário:

- PostgreSQL
- Docker
- Migrations

## Testes

Executar todos os testes:

```bash
dotnet test
```

## Conceitos demonstrados

- Clean Architecture
- Domain-Driven Design (DDD)
- Application Services
- Repository Pattern
- Testes de Integração
- Testes de Arquitetura