# ADR-002 - Usar banco de dados InMemory em exemplos educacionais

## Status

Aceito

## Contexto

O propósito deste repositório é educacional.
Exigir PostgreSQL e Docker aumentaria a complexidade de configuração e desviaria a atenção dos conceitos de arquitetura sendo demonstrados.

## Decisão

Usar Entity Framework Core com o provedor InMemory no exemplo `001-clean-architecture`.

## Consequências

### Positivas

- Inicialização mais simples
- Sem dependências externas
- Execução mais rápida
- Foco na arquitetura

### Negativas

- Não demonstra recursos de banco de dados relacional
- Não cobre migrações
- Não reproduz cenários de produção

Esses tópicos serão abordados em exemplos futuros do repositório.
