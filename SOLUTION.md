# PROJETO

## Funcionalidades

As seguintes funcionalidades seriam muito bem vindas:

### Clientes

Esta funcionalidade deve compreender o cadastro do cliente, através da sua criação de conta, autorização de acesso, encerramento de conta e dashboard.

#### Criando Conta de Cliente

Para criar uma conta o cliente deve informar os seguintes dados

- E-mail
- Nome
- CPF
- Sexo
- Estado Civil
- Endereço
- Naturalidade

#### Autenticando Acesso

O cliente deve informar seu e-mail e sua senha para ter acesso a plataforma.

#### Alterando Cadastro

O cliente poderá alterar seus dados cadastrais através da confirmação de senha, mas não poderá alterar seu CPF.

#### Encerrando Conta

O cliente poderá encerrar a conta em qualquer momento, mediante informação de dados bancários para transferência do saldo ou pagamento da dívida em aberto caso exista.

#### Movimentando Conta

O cliente poderá fazer saques de rendimentos.

#### Verificando extrato da Conta

Mostrar o saldo não aplicado em nenhum produto (saldo em conta corrente).

Detalhar mensalmente o rendimento de cada produto mostrando as seguintes informações:

- descontos de taxa de administração
- rendimento do produto mensalmente
- saques
- aportes
- transações de entrada e saída

#### Dashboard

Deverá mostrar em gráfico pizza, a representação de cada produto no montante total da carteira do cliente

### Produtos

Página com os produtos disponíveis

#### Aderindo a um Produto

Listar os produtos disponíveis para o cliente informando a taxa de administração, previsão de rendimento, aporte mínimo e aportes mensais mínimos se houver. Dentre a lista disponível permitir que o cliente faça a adesão informando o valor do aporte inicial.

#### Fazendo Aportes
Dentre a lista de produtos aderidos o cliente poderá escolher um para informar o aporte que deseja fazer.

#### Cancelando Adesão de um Produto
Ao cancelar a adesão de um produto deve ser descontadas as taxas de administração prevista da vigência do contrato, e o saldo deve movimentado para  conta corrente do cliente.