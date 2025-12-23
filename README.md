📌 Roteiro para Desenvolvimento do App de Organização de Feira (C# + POO)
1. Definição do Escopo (bem simples)

Antes de qualquer coisa, deixe claro:

O app não compra, apenas registra

Não precisa de login

Não precisa de banco de dados complexo (pode ser memória ou arquivo)

Foco em:

Lista de itens

Valor de cada item

Quantidade usada por mês

Cálculo do que precisa comprar

2. Entendimento das Regras de Negócio

Aqui você define como o sistema pensa:

Todo item tem:

Nome

Valor unitário

Quantidade ideal mensal

Quantidade restante do mês anterior

O sistema deve:

Calcular quanto foi gasto no mês

Calcular quanto precisa comprar

Evitar comprar a mais ou a menos

Fórmula principal:

Quantidade a comprar = Quantidade ideal − Quantidade restante

3. Modelagem das Classes (POO)

Defina suas entidades principais:

3.1 Classe Item

Responsável por representar um produto da feira.

Propriedades:

Nome

ValorUnitario

QuantidadeIdealMensal

QuantidadeRestante

Responsabilidades:

Calcular quantidade necessária para compra

Calcular valor total do item

3.2 Classe ListaDeCompras

Responsável por agrupar os itens.

Propriedades:

Lista de itens

Mês de referência

Responsabilidades:

Adicionar item

Remover item

Listar itens

Calcular valor total da lista

3.3 Classe ControleMensal

Responsável pela lógica mensal.

Responsabilidades:

Comparar consumo ideal x sobra

Gerar lista de necessidade

Atualizar dados para o próximo mês

4. Organização do Projeto (Estrutura)

Sugestão simples:

Models

Item

ListaDeCompras

Services (ou Controllers)

ControleMensal

Program (Main)

Interação com o usuário

Isso ajuda a aprender separação de responsabilidades.

5. Fluxo de Uso do Aplicativo

Defina o passo a passo do usuário:

Usuário informa o mês

Cadastra um item

Nome

Valor

Quantidade ideal mensal

Quantidade que sobrou do mês anterior

O sistema:

Calcula automaticamente:

Quantidade a comprar

Valor total do item

Usuário repete até finalizar a lista

O sistema mostra:

Lista de compras

Total gasto no mês

Comparativo com o mês anterior

6. Persistência de Dados (Simples)

Para estudo:

Opção 1: Manter tudo em memória (listas)

Opção 2: Salvar em arquivo (TXT ou JSON)

Objetivo:

Guardar dados do mês anterior

Ler esses dados no próximo mês

7. Conceitos de POO que Você Vai Praticar

Esse app é ótimo para treinar:

Classes e objetos

Encapsulamento (get/set)

Responsabilidade única

Métodos com lógica de negócio

Uso de listas (List<>)

Construtores

Organização em camadas

8. Validações Básicas

Mesmo simples, inclua:

Valor não pode ser negativo

Quantidade não pode ser negativa

Se a sobra for maior que a quantidade ideal → não comprar

9. Saídas do Sistema (Relatórios Simples)

Lista do que comprar

Valor individual por item

Total gasto

Comparação:

Planejado x Comprado

Sobra x Necessidade

10. Evolução Natural do Projeto (Opcional)

Quando se sentir confortável:

Histórico por mês

Média de consumo

Sugestão automática de compra

Interface gráfica (Windows Forms ou WPF)

11. Checklist Final de Conclusão

Você pode considerar o app concluído quando:

 Consegue cadastrar itens

 Define consumo mensal ideal

 Registra sobras

 O sistema calcula corretamente o que comprar

 O total mensal é exibido corretamente

 Consegue reutilizar dados do mês anterior
