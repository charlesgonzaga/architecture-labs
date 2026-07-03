# 001 - Clean Architecture

Laboratório prático demonstrando a implementação da Clean Architecture utilizando .NET.

## Objetivos

- Demonstrar separação de responsabilidades;
- Aplicar princípios SOLID;
- Implementar Vertical Slice Architecture;
- Demonstrar CQRS e validações;
- Construir uma base evolutiva para os próximos laboratórios.

## Tecnologias

- .NET 9
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- MediatR
- FluentValidation
- Docker

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