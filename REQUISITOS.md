# Requisitos CACS

## Requisitos Funcionais

- **RF01:** O sistema deve permitir que o usuário faça login utilizando nome de usuário e senha válidos.
- **RF02:** O sistema deve permitir que o usuário visualize seu limite total de pontos de categoria.
- **RF03:** O sistema deve permitir que o usuário visualize seus pontos de categoria disponíveis.
- **RF04:** O sistema deve permitir que o usuário visualize o limite total de pontos de categoria do grupo.
- **RF05:** O sistema deve permitir que o usuário visualize o limite de pontos de categoria disponível do grupo.
- **RF06:** O sistema deve permitir que o usuário aumente a quantidade de uma categoria, desde que as regras de negócio sejam respeitadas.
- **RF07:** O sistema deve permitir que o usuário reduza a quantidade de uma categoria, desde que as regras de negócio sejam respeitadas.
- **RF08:** O sistema deve permitir a utilização das categorias I, II, III e IV.
- **RF09:** O sistema deve atualizar os limites individuais e do grupo após alterações de categoria.
- **RF10:** O sistema deve refletir alterações realizadas por outros usuários conectados.

## Regras de Negócio

- **RN01:** Cada usuário possui um limite total inicial de 16 pontos de categoria.
- **RN02:** As categorias possuem os seguintes valores:
  - Categoria I = 1 ponto
  - Categoria II = 2 pontos
  - Categoria III = 3 pontos
  - Categoria IV = 4 pontos.
- **RN03:** Os pontos utilizados pelo usuário são calculados pela soma dos valores das categorias que ele possui.
- **RN04:** Os pontos disponíveis do usuário correspondem à diferença entre seu limite total e seus pontos atualmente utilizados.
- **RN05:** A quantidade de uma categoria não pode ser reduzida para um valor inferior a zero.
- **RN06:** Os pontos utilizados pelo usuário não podem ultrapassar seu limite total de 16 pontos.
- **RN07:** O limite total de pontos do grupo corresponde à soma dos limites totais dos usuários participantes.
- **RN08:** O limite de pontos disponível do grupo corresponde à soma dos pontos disponíveis dos usuários participantes.
- **RN09:** Uma alteração de categoria deve preservar a validade dos limites individuais e do grupo.
- **RN10:** Operações concorrentes não podem resultar em um limite disponível negativo, em pontos utilizados superiores ao limite total ou em perda de dados.

## Requisitos Não Funcionais

- **RNF01:** O serviço deve estar disponível 24 horas por dia, 7 dias por semana, exceto durante manutenções programadas.
- **RNF02:** O sistema deve responder às requisições do usuário em no máximo 2 segundos em condições normais de operação.
- **RNF03:** O serviço deve ser acessível por meio de um link utilizando um navegador web.
- **RNF04:** O serviço deve permitir acesso somente aos 7 usuários previamente autorizados.
- **RNF05:** O serviço deve suportar até 7 usuários simultâneos.
- **RNF06:** O sistema deve suportar operações concorrentes de leitura e escrita sem permitir condições de corrida que resultem em perda ou inconsistência de dados.
- **RNF07:** O serviço deve funcionar em computadores, tablets e dispositivos móveis.
