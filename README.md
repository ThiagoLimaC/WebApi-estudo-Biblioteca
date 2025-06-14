# WebApi-estudo-Biblioteca

<img src="wwwroot/videoApiBiblioteca.gif" width="700">

Uma API RESTful desenvolvida em ASP.NET Core para gerenciamento de uma biblioteca, permitindo operações de CRUD para livros e autores. O projeto segue boas práticas como Service Layer e uso de DTOs, e está pronto para integração com frontends modernos.

---

## Funcionalidades

- Cadastro, edição, listagem e exclusão de livros
- Cadastro, edição, listagem e exclusão de autores
- Associação de livros a autores
- Busca de livros por autor e autores por livro
- Respostas padronizadas com status, mensagem e dados

---

## Arquitetura

O projeto está organizado em camadas:

- **Models**: Entidades do domínio (Livro, Autor)
- **DTOs**: Objetos de transferência de dados para entrada/saída
- **Services**: Regras de negócio e orquestração
- **Controllers**: Endpoints da API

Tecnologias utilizadas:
- .NET 9
- Entity Framework Core
- SQL Server (ou outro banco relacional)
- C#

---

## Como executar

1. **Pré-requisitos**:
   - [.NET 9 SDK](https://dotnet.microsoft.com/download)
   - SQL Server ou outro banco relacional configurado

2. **Configuração do banco de dados**:
   - Ajuste a connection string em `appsettings.json`

3. **Restaurar dependências e rodar as migrations**:
   - `dotnet restore dotnet ef database update`

4. **Executar a aplicação**:
   - `dotnet run`

   A API estará disponível em `https://localhost:5001` (ajuste conforme necessário).

---

## Principais Endpoints

| Método | Rota                        | Descrição                        |
|--------|-----------------------------|----------------------------------|
| GET    | /api/livros                 | Lista todos os livros            |
| GET    | /api/livros/{id}            | Busca livro por ID               |
| POST   | /api/livros                 | Cria um novo livro               |
| PUT    | /api/livros                 | Edita um livro                   |
| DELETE | /api/livros/{id}            | Exclui um livro                  |
| GET    | /api/autores                | Lista todos os autores           |
| GET    | /api/autores/{id}           | Busca autor por ID               |
| POST   | /api/autores                | Cria um novo autor               |
| PUT    | /api/autores                | Edita um autor                   |
| DELETE | /api/autores/{id}           | Exclui um autor                  |

---

## Créditos

Este projeto foi inspirado pelo tutorial de Crislaine D´Paula disponível no canal do YouTube. Agradecimentos especiais a Crislaine por compartilhar seu conhecimento e ajudar a comunidade de desenvolvedores.
