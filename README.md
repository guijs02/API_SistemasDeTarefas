Este Projeto é uma API de cadastro de usúarios realizado em C# e recursos do .NET CORE, utilizando o ORM Entity Framework para o mapeamento das entidades para o banco de dados SQL Server e aplicando a estruturação das pastas em camadas para melhor legibilidade. Neste desígnio foi utilizado injeções de dependência, utilização do pattern Repository como camada anterior ao do banco de dados, aplicação de conceitos do SOLID para que o Controller dependa de abstrações, consequentemente, diminuindo o alto acoplamento do código.

Nesta API é possível realizar todas as instruções de CRUD com os endpoints:

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





