## Sobre a API de Usuários

Este Projeto é uma API de cadastro de usúarios realizado em .NET Core para realizar as operações de um CRUD.

## 📡 Tecnologias
- Entity Framework Core
- C#
- .NET Core
- SQL Server

 ## 📖 Recursos e Conceitos aplicados
 - SOLID
 - Injeção de dependência
 - LINQ
 - API REST
 - Swagger

 ## 🛠 Patterns
- Repository
- Controller
- Model
<br><br>

<h2>Endpoints:</h2>

POST: api/Usuario
```json
{
  "id": 5,
  "nome": "clojure",
  "email": "clojure@gmail.com"
}
```
<br>

GET: api/Usuario/{id} -> Obter o usúario específico
```json
{
  "id": 3,
  "nome": "json",
  "email": "json@outlook.com"
}
```
<br>
GET: api/Usuario -> Obter todos os usúarios

```json
[
  {
    "id": 2,
    "nome": "gui",
    "email": "gui@gmail.com"
  },
  {
    "id": 3,
    "nome": "json",
    "email": "json@outlook.com"
  },
  {
    "id": 4,
    "nome": "docker",
    "email": "dockerps@outlook.com"
  },
  {
    "id": 5,
    "nome": "clojure",
    "email": "clojure@gmail.com"
  }
]
```

<br>
PUT: api/Usuario -> alterar determinado usúario
id=5

```json
{
  "id": 5,
  "nome": "nubank",
  "email": "nubank@email.com"
}
```
<br>
DELETE: api/Usuario/{id} -> excluir determinado usúario

```json
true
```
<br>
Os endpoints foram executados pelo swagger para melhor uma melhor visualização.





