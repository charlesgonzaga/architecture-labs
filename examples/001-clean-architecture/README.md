# 001 - Clean Architecture

Laboratório prático demonstrando a implementação da Clean Architecture utilizando .NET.

## Objetivos

- Demonstrar separação de responsabilidades;
- Aplicar princípios SOLID;
- Implementar Vertical Slice Architecture;
- Demonstrar CQRS e validações;
- Construir uma base evolutiva para os próximos laboratórios.

## Persistência

Este exemplo utiliza:

- Entity Framework Core
- Provedor InMemory

O objetivo é reduzir dependências externas e manter o foco nos conceitos de:

- Clean Architecture
- Domain-Driven Design (DDD)
- Repository Pattern
- Application Services

Não é necessário:

- PostgreSQL
- Docker
- Migrations
- Configuração de banco de dados

Basta executar:

```bash
dotnet run --project src/ArchitectureLabs.Api
```

## Tecnologias

- .NET 9
- ASP.NET Core
- Entity Framework Core
- EF Core InMemory
- xUnit
- FluentAssertions

## Estrutura da Solução

```text
src/
├── ArchitectureLabs.Api
├── ArchitectureLabs.Application
├── ArchitectureLabs.Domain
├── ArchitectureLabs.Infrastructure
└── ArchitectureLabs.CrossCutting

tests/
├── ArchitectureLabs.UnitTests
├── ArchitectureLabs.IntegrationTests
└── ArchitectureLabs.ArchitectureTests
```

## Decisões Arquiteturais

- ADR-001 - Utilizar Clean Architecture.

## Diagramas

- C4 - Context Diagram
- C4 - Container Diagram

## Roadmap

- [ ] Customer Aggregate
- [ ] CQRS
- [ ] Entity Framework Core
- [ ] PostgreSQL
- [ ] Docker Compose
- [ ] Testes
- [ ] Observabilidade