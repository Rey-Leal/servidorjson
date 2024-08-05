# Servidor JSON

![Badge em Desenvolvimento](https://img.shields.io/static/v1?label=STATUS&message=FINALIZADO&color=GREEN&style=for-the-badge)

## Introdução
Este projeto é um servidor JSON destinado a testes de comunicação de API com a aplicação Cliente JSON. Ele inclui controllers que respondem a solicitações HTTP e fornecem dados em formato JSON para o cliente. As principais tecnologias utilizadas são:

* C#
* MVC
* Console Application

## Caminhos de Acesso aos Dados da API
Abaixo estão os endpoints para acessar os dados da API quando ela estiver em execução:

- **Produtos**: `http://localhost:64195/api/produto`
- **Usuários**: `http://localhost:64195/api/usuario`

## Estrutura do Projeto
O projeto está organizado da seguinte forma:
* **Controllers**: Contém os controllers da API que gerenciam as requisições HTTP e enviam respostas em formato JSON.
* **Models**: Contém as classes de modelo que representam os dados retornados pela API.
* **Program**: Contém a lógica principal da aplicação de console.

## Funcionalidades
* **Fornecer dados em formato JSON**: Os endpoints da API respondem com dados estruturados em JSON para as solicitações recebidas.

## Configuração e Execução
Para executar este projeto localmente, siga os passos abaixo:

1. **Clone o repositório**:
   ```bash
   git clone <URL-do-repositorio>
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd nome-do-projeto
   ```

3. **Instale as dependências**:
   Certifique-se de que você tenha o .NET SDK instalado em sua máquina. Instale as dependências com:
   ```bash
   dotnet restore
   ```

4. **Atualize as configurações da API**:
   Configure as definições necessárias no arquivo `appsettings.json`.

5. **Execute o projeto**:
   ```bash
   dotnet run
   ```

6. **Acesse os Endpoints**:
   Utilize um navegador ou ferramenta como Postman para acessar os endpoints da API:
   - Produtos: `http://localhost:64195/api/produto`
   - Usuários: `http://localhost:64195/api/usuario`