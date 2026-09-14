# Projeto Prático - Pessoa Física e Pessoa Jurídica

## Sobre o projeto

Aplicação desenvolvida em C# com .NET para demonstrar conceitos de Programação Orientada a Objetos, cadastro de Pessoa Física e Pessoa Jurídica, validação de dados, cálculo de impostos e manipulação de arquivos.

### Funcionalidades

* Cadastro de Pessoa Física
* Cadastro de Pessoa Jurídica
* Validação da idade da Pessoa Física
* Validação do CNPJ
* Cálculo de imposto
* Armazenamento dos dados em arquivos `.txt`
* Utilização do nome do cliente como nome do arquivo

### Tecnologias utilizadas

* C#
* .NET
* Visual Studio Code
* GitHub
* System.IO
* Markdown

### Estrutura do projeto

```text
PessoaFisica.cs
PessoaJuridica.cs
Program.cs
README.md
```

* `PessoaFisica.cs`: representa os dados e operações da Pessoa Física.
* `PessoaJuridica.cs`: representa os dados e operações da Pessoa Jurídica.
* `Program.cs`: executa e demonstra as funcionalidades do sistema.
* `README.md`: documentação do projeto.

### Pré-requisitos

Antes de executar o projeto, tenha instalado:

* .NET SDK
* Visual Studio Code

### Como baixar o projeto

O projeto pode ser disponibilizado no GitHub.

[https://github.com/](https://github.com/ricardoprm/Projetodotnet-1.git)

### Como executar

No terminal, dentro da pasta do projeto, execute:

```bash
dotnet restore
dotnet build
dotnet run
```

Após a execução, o programa apresenta no terminal as informações de validação e os valores dos impostos.

### Principais funcionalidades

| Funcionalidade  | Descrição                                          |
| --------------- | -------------------------------------------------- |
| Pessoa Física   | Armazena dados pessoais, endereço e renda          |
| Pessoa Jurídica | Armazena dados da empresa, endereço e faturamento  |
| Validar idade   | Verifica se a Pessoa Física possui 18 anos ou mais |
| Validar CNPJ    | Verifica o formato básico do CNPJ                  |
| Pagar imposto   | Calcula o imposto de Pessoa Física e Jurídica      |

### Autor

Paulo Ricardo de Morais

