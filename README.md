Este Projeto é uma API de sistema de tarefas realizado em C# e recursos do .NET CORE, utilizando o ORM Entity Framework para o mapeamento das entidades para o banco de dados SQL Server e aplicando a estruturação das pastas em camadas para melhor legibilidade. Neste desígnio foi utilizado injeções de dependência, utilização do pattern Repository como camada anterior ao do banco de dados, aplicação de conceitos do SOLID para que o Controller dependa de abstrações, consequentemente, diminuindo o alto acoplamento do código.

Nesta API é possível realizar todas as instruções de CRUD com os endpoints:

POST: api/Usuario -> Criar usúario no determinado recurso
<br>
GET: api/Usuario/{id} -> Obter o usúario específico
<br>
GET: api/Usuario -> Obter todos os usúarios
<br>
PUT: api/Usuario -> alterar determinado usúario
<br>
DELETE: api/Usuario/{id} -> excluir determinado usúario

Os endpoints foram executados pelo swagger para melhor documentação das API's.





