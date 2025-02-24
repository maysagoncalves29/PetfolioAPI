--- Repositório para os meus estudos pessoais ----

# PetController - Explicação dos Conceitos

Este repositório apresenta um exemplo de um controller em ASP.NET Core chamado `PetController`. Ele gerencia operações relacionadas a pets, utilizando **REST API**. Aqui estão algumas explicações detalhadas de principais conceitos utilizados no código.

## Definição do Controller
No ASP.NET Core, um **Controller** é uma classe que lida com as requisições HTTP e define as regras de como os dados serão processados.

```csharp
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
```
### Explicação:
- **[Route("api/[controller]")]**: Define a rota base para as requisições. O `[controller]` será substituído pelo nome da classe (`Pet`), tornando a rota `api/Pet`.
- **[ApiController]**: Informa que a classe é um controller de API, ativando recursos como validação automática de entradas e respostas HTTP padronizadas.
- **ControllerBase**: Uma classe base para controllers de API, sem suporte para Views (diferente de `Controller`, que é usado em MVC).

## [ProducesResponseType]
Este atributo é utilizado para documentar os possíveis retornos de um endpoint.

Exemplo no método `GetAll`:
```csharp
[ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status204NoContent)]
```
### Explicação:
- **200 OK**: Indica sucesso na requisição e retorna uma lista de pets.
- **204 No Content**: Indica que não há pets cadastrados para retornar.

Esse atributo ajuda no Swagger (documentação da API) e facilita o entendimento do comportamento dos endpoints.


## IActionResult
A interface `IActionResult` é usada para definir o tipo de resposta que um endpoint retorna.

Exemplo no método `Delete`:
```csharp
public IActionResult Delete(int id)
{
    var useCase = new DeletePetByIdUseCase();
    useCase.Execute(id);
    return NoContent();
}
```
### Explicação:
- `IActionResult` permite retornar diferentes tipos de respostas HTTP, como `Ok()`, `Created()`, `NoContent()`, `BadRequest()`, etc.
- **NoContent()** (204) indica que a operação foi bem-sucedida, mas não há dados para retornar.

Outros exemplos comuns:
- `return Ok(data);` → Retorna status 200 com dados.
- `return BadRequest(errors);` → Retorna status 400 com erros.
- `return NotFound();` → Retorna status 404 se o recurso não for encontrado.


## Conclusão
Esses conceitos são fundamentais para criar APIs REST com **ASP.NET Core**. O `PetController` segue boas práticas ao utilizar **Controllers**, **Use Cases** e **tipos de resposta padronizados**.

Se você é iniciante, vale a pena testar e modificar esse código para entender melhor como funcionam os controllers no ASP.NET Core!

Fique à vontade para contribuir e deixar sugestões! :)

