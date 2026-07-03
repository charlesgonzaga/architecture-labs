# ADR-001 - Adotar Clean Architecture

- Status: Aceito
- Data: 2026-07-03

## Contexto

Este laboratório tem como objetivo demonstrar a construção de aplicações utilizando princípios de arquitetura de software que favoreçam:

- Baixo acoplamento;
- Alta coesão;
- Facilidade de testes;
- Independência de frameworks;
- Evolução gradual da solução;
- Separação clara de responsabilidades.

Além disso, este laboratório servirá de base para outros exemplos do repositório `architecture-labs`, como:

- CQRS;
- Event-Driven Architecture;
- Outbox Pattern;
- Saga Pattern;
- Event Sourcing.

A arquitetura escolhida precisa permitir a evolução desses cenários sem exigir grandes refatorações estruturais.

---

## Decisão

Adotar a **Clean Architecture**, organizando a solução nas seguintes camadas:

### Domain

Contém:

- Entidades;
- Value Objects;
- Regras de negócio;
- Exceções de domínio;
- Eventos de domínio.

Esta camada não possui dependências externas.

### Application

Contém:

- Casos de uso;
- Contratos;
- DTOs;
- Comandos e consultas;
- Orquestração da aplicação.

Depende apenas da camada `Domain`.

### Infrastructure

Contém:

- Persistência;
- Implementações de repositórios;
- Mensageria;
- Integrações externas;
- Configurações de infraestrutura.

Implementa contratos definidos pela camada `Application`.

### Api

Contém:

- Endpoints HTTP;
- Configurações;
- Middlewares;
- Composição da aplicação.

Responsável apenas pela exposição da aplicação.

---

## Dependências

As dependências devem apontar sempre para o centro da aplicação:

```text
Api
 ↓
Application
 ↓
Domain
 ↑
Infrastructure
```

O domínio não deve conhecer detalhes de infraestrutura, frameworks ou mecanismos de persistência.

---

## Consequências

### Positivas

- Alta testabilidade;
- Independência de frameworks;
- Facilidade de manutenção;
- Evolução incremental da arquitetura;
- Menor acoplamento entre camadas;
- Melhor separação de responsabilidades.

### Negativas

- Maior quantidade de projetos;
- Mais abstrações;
- Curva de aprendizado inicial maior;
- Possível complexidade excessiva em aplicações muito simples.

---

## Alternativas Consideradas

### Arquitetura em Camadas (Layered Architecture)

Não escolhida por apresentar maior tendência ao acoplamento entre as camadas e crescimento desorganizado das dependências.

### Monólito Modular (Modular Monolith)

Pode ser adotado em laboratórios futuros, porém o objetivo deste exemplo é demonstrar explicitamente os princípios da Clean Architecture.

---

## Referências

- Clean Architecture — Robert C. Martin
- Clean Code — Robert C. Martin
- Domain-Driven Design — Eric Evans
- Patterns of Enterprise Application Architecture — Martin Fowler
