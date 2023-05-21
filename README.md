# FistAspNetCoreAPIProject

ContosoPizza API

English
This project is a web API developed with ASP.NET Core. The primary function of the API is to manipulate data for pizzas in a fictitious "ContosoPizza" application. 
It provides CRUD (Create, Read, Update, Delete) operations on a set of pizza data.

This API was built following Microsoft's training documentation, which can be found (https://learn.microsoft.com/pt-br/training/modules/build-web-api-aspnet-core/).

Classes
This project is composed of three main classes:
Pizza - Represents a pizza in the application.
PizzaService - A static class that performs operations related to Pizzas.
PizzaController - A controller that handles HTTP requests.

Endpoints
The API provides the following endpoints:
GET /Pizza - Returns all pizzas.
GET /Pizza/{id} - Retrieves a specific pizza based on its id.
POST /Pizza - Creates a new pizza.
PUT /Pizza/{id} - Updates an existing pizza.
DELETE /Pizza/{id} - Deletes an existing pizza.

How to use
To run this project on your local machine, follow these steps:
Clone this repository.
Open the project in Visual Studio.
Run the project either by using the "Run" button or the "Ctrl+F5" shortcut.
You can also test the API using any HTTP client such as Postman.

Contributions
Contributions to this project are welcomed. If you want to add or modify any feature, feel free to open an issue or submit a PR.

License
This project is licensed under the MIT license. For more details, please refer to the LICENSE file.


Português
Este projeto é uma API Web desenvolvida com ASP.NET Core. A principal função da API é manipular dados de pizzas em uma aplicação fictícia chamada "ContosoPizza". 
Ela fornece operações CRUD (Criar, Ler, Atualizar, Deletar) em um conjunto de dados de pizzas.

Esta API foi construída seguindo a documentação de treinamento da Microsoft, que pode ser encontrada (https://learn.microsoft.com/pt-br/training/modules/build-web-api-aspnet-core/).

Classes
Este projeto é composto de três classes principais:
Pizza - Representa uma pizza na aplicação.
PizzaService - Uma classe estática que realiza operações relacionadas a pizzas.
PizzaController - Um controlador que manipula solicitações HTTP.

Endpoints
A API fornece os seguintes endpoints:
GET /Pizza - Retorna todas as pizzas.
GET /Pizza/{id} - Recupera uma pizza específica com base em seu ID.
POST /Pizza - Cria uma nova pizza.
PUT /Pizza/{id} - Atualiza uma pizza existente.
DELETE /Pizza/{id} - Deleta uma pizza existente.

Como usar
Para executar este projeto em sua máquina local, siga estas etapas:
Clone este repositório.
Abra o projeto no Visual Studio.
Execute o projeto usando o botão "Executar" ou o atalho "Ctrl+F5".
Você também pode testar a API usando qualquer cliente HTTP, como o Postman.

Contribuições
Contribuições para este projeto são bem-vindas. Se você deseja adicionar ou modificar algum recurso, sinta-se à vontade.

Licença
Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para obter mais detalhes.
