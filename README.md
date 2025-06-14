# WebApi-estudo-Biblioteca

<img src="wwwroot/videoApiBiblioteca.gif" width="700">

Uma API RESTful desenvolvida em ASP.NET Core para gerenciamento de uma biblioteca, permitindo opera��es de CRUD para livros e autores. O projeto segue boas pr�ticas como Service Layer e uso de DTOs, e est� pronto para integra��o com frontends modernos.

---

## Funcionalidades

- Cadastro, edi��o, listagem e exclus�o de livros
- Cadastro, edi��o, listagem e exclus�o de autores
- Associa��o de livros a autores
- Busca de livros por autor e autores por livro
- Respostas padronizadas com status, mensagem e dados

---

## Arquitetura

O projeto est� organizado em camadas:

- **Models**: Entidades do dom�nio (Livro, Autor)
- **DTOs**: Objetos de transfer�ncia de dados para entrada/sa�da
- **Services**: Regras de neg�cio e orquestra��o
- **Controllers**: Endpoints da API

Tecnologias utilizadas:
- .NET 9
- Entity Framework Core
- SQL Server (ou outro banco relacional)
- C#

---

## Como executar

1. **Pr�-requisitos**:
   - [.NET 9 SDK](https://dotnet.microsoft.com/download)
   - SQL Server ou outro banco relacional configurado

2. **Configura��o do banco de dados**:
   - Ajuste a connection string em `appsettings.json`

3. **Restaurar depend�ncias e rodar as migrations**:
   - `dotnet restore dotnet ef database update`

4. **Executar a aplica��o**:
   - `dotnet run`

   A API estar� dispon�vel em `https://localhost:5001` (ajuste conforme necess�rio).

---

## Principais Endpoints

| M�todo | Rota                        | Descri��o                        |
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

## Cr�ditos

Este projeto foi inspirado pelo tutorial de Crislaine D�Paula dispon�vel no canal do YouTube. Agradecimentos especiais a Crislaine por compartilhar seu conhecimento e ajudar a comunidade de desenvolvedores.
