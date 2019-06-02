# ESCOPO

## Objetivo

Um sistema onde o usuário veja produtos disponíveis para investimento (com suas taxas e rendimentos) possa selecionar aquele(s) no qual deseja investir, realizar um cadastro, fazer aquisição e aportes nos produtos e também visualizar suas movimentações e seus rendimentos.

## Funcionalidades

As seguintes funcionalidades seriam muito bem vindas:

- Cadastro do cliente
- Página com os produtos disponíveis (você pode inserir eles diretamente no banco de dados ou fazer um CRUD, deixamos a seu critério)
- Aquisição do produto (com investimento inicial que gera uma movimentação de entrada na conta)
- Dashboard do cliente com  as movimentações e  rendimentos (simule aportes mensais para termos dados relevantes, não esqueça de descontar a taxa de administração e calcular o rendimento do produto mensalmente através de transações de entrada e saída na Conta Movimentação)

## Como

Criar um modelo de domínio que envolve os seguintes itens:

Entidades \_\_\_\_\_\_\_\_\_\_\_

Atributos sugeridos    \_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

Cliente :

- Nome,
- CPF,
- Sexo,
- Estado Civil,
- Endereço,
- Naturalidade



Produto Investimento:

- Nome, Descrição,
- Taxa de Administração,
- Percentual de Rendimento

Conta de Movimentação:

- Tipo de Movimentação (Entrada/Saída),
- Data/Hora ,
- Valor,
- Descrição (edited)

## Tecnologias

A tecnologia utilizada pode ser a escolha do participante. Sendo recomendadas as duas possibilidades abaixo, usando:

- C# + MySQL
- VueJS

## O que será avaliado

- Capacidade de _&quot;se virar&quot;_ e _&quot;Get shit done&quot;_;
- Lógica, organização e clareza de código;
- ReadMe;
- Arquitetura da solução;
- Se conseguir extrair dados interessantes, melhor;

## Interessante, mas não fundamental

- Guardar os dados em um banco de dados usando um ORM.
- Preocupação com segurança (apenas um teste);