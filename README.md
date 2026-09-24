# MTG Deck Lab

> Gerenciador, analisador e simulador de decks de **Magic: The Gathering**, desenvolvido com foco em arquitetura de software, análise de dados e experiência de usuário.

![MTG Deck Lab — Interface](./assets/interface-preview.png)

## Sobre o projeto

O **MTG Deck Lab** é uma aplicação desktop para gerenciamento e análise de decks de Magic: The Gathering.

A proposta é reunir em uma única aplicação ferramentas para:

* Criar e editar decks
* Pesquisar e organizar cartas
* Analisar a composição dos decks
* Simular mãos iniciais e mulligans
* Registrar partidas
* Acompanhar estatísticas
* Visualizar dados através de gráficos

O projeto também tem como objetivo servir como um projeto completo de portfólio, explorando arquitetura em camadas, Entity Framework Core, banco de dados, testes automatizados e boas práticas de desenvolvimento.

## Interface

A interface foi projetada com foco em uma experiência moderna de aplicativo desktop, utilizando **Dark Mode**, navegação lateral e painéis de informação.

### Principais telas

* Dashboard
* Meus Decks
* Deck Builder
* Catálogo de Cartas
* Analisador de Deck
* Simulador de Mãos
* Histórico de Partidas

> Coloque a imagem da interface em `assets/interface-preview.png` para que ela apareça automaticamente aqui no GitHub.

## Funcionalidades

### Deck Builder

* Criar decks
* Editar decks
* Excluir decks
* Adicionar cartas
* Remover cartas
* Alterar quantidade de cartas
* Validação dos decks

### Catálogo de Cartas

* Importação de cartas
* Pesquisa por nome
* Filtro por cor
* Filtro por tipo
* Filtro por custo de mana
* Visualização detalhada

### Deck Analyzer

Análise automática da composição do deck:

* Curva de mana
* Distribuição de cores
* Tipos de cartas
* Quantidade de terrenos
* Custo médio de mana
* Gráficos estatísticos

### Simulador

Sistema para testar a consistência do deck:

* Embaralhamento
* Compra inicial
* Compra de cartas
* Mulligan
* Simulação de milhares de mãos
* Cálculo de probabilidades

### Partidas

* Registrar partidas
* Vitória / derrota
* Adversário
* Deck utilizado
* Histórico
* Estatísticas

## Roadmap

### Fase 1 — Fundação

* [x] Criar solução
* [x] Criar projetos
* [x] Configurar referências
* [x] Criar entidades
* [x] Definir relacionamentos
* [x] Criar banco SQLite

### Fase 2 — Deck Builder

* [ ] Criar deck
* [ ] Editar deck
* [ ] Excluir deck
* [ ] Adicionar cartas
* [ ] Remover cartas
* [ ] Alterar quantidade
* [ ] Validações

### Fase 3 — Catálogo de Cartas

* [ ] Importar cartas
* [ ] Pesquisar cartas
* [ ] Filtrar por cor
* [ ] Filtrar por tipo
* [ ] Filtrar por custo
* [ ] Visualizar detalhes

### Fase 4 — Interface

* [ ] Dashboard
* [ ] Lista de decks
* [ ] Tela de criação
* [ ] Tela de edição
* [ ] Tela de cartas
* [ ] Dark mode

### Fase 5 — Deck Analyzer

* [ ] Curva de mana
* [ ] Distribuição de cores
* [ ] Tipos de cartas
* [ ] Quantidade de terrenos
* [ ] Média de custo
* [ ] Gráficos

### Fase 6 — Simulador

* [ ] Embaralhamento
* [ ] Compra inicial
* [ ] Compra de cartas
* [ ] Mulligan
* [ ] Simulação de milhares de mãos
* [ ] Probabilidades

### Fase 7 — Partidas

* [ ] Registrar partida
* [ ] Vitória / derrota
* [ ] Adversário
* [ ] Deck utilizado
* [ ] Histórico
* [ ] Estatísticas

### Fase 8 — Projeto Profissional

* [ ] Testes automatizados
* [ ] Logging
* [ ] Tratamento de erros
* [ ] CI/CD
* [ ] Installer
* [ ] Documentação
* [ ] Publicação no GitHub

## Arquitetura

O projeto utiliza uma arquitetura separada em camadas, buscando manter responsabilidades bem definidas:

```text
MTGDeckLab
│
├── MTGDeckLab.Domain
│   ├── Entities
│   ├── Enums
│   └── Interfaces
│
├── MTGDeckLab.Application
│   ├── Services
│   ├── DTOs
│   └── UseCases
│
├── MTGDeckLab.Infrastructure
│   ├── Data
│   ├── Repositories
│   └── Migrations
│
└── MTGDeckLab.Presentation
    ├── Views
    ├── ViewModels
    └── Components
```

## Tecnologias

* C#
* .NET
* Entity Framework Core
* SQLite
* LINQ
* Git
* GitHub

Tecnologias planejadas para etapas futuras:

* xUnit
* Moq
* Serilog
* CI/CD
* Docker

## Objetivos do projeto

Além de criar uma ferramenta para jogadores de Magic: The Gathering, o projeto busca demonstrar conhecimentos práticos em:

* Arquitetura de software
* Orientação a objetos
* Entity Framework Core
* Banco de dados
* Design de APIs e serviços
* Testes automatizados
* Desenvolvimento de aplicações desktop
* Análise e visualização de dados
* Git e GitHub
* Boas práticas de desenvolvimento

## Status

**Em desenvolvimento**

O projeto está sendo desenvolvido de forma incremental, começando pela fundação da aplicação e evoluindo até o simulador e sistema de estatísticas.

## Licença

Este projeto está em desenvolvimento. A licença será definida posteriormente.

