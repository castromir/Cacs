# Requisitos — Inventário

**Projeto:** CACS  
**Versão:** 2.1  
**Status:** Incremento atual  
**Escopo:** Incluir, alterar e remover itens do inventário individual, verificado com sete usuários já provisionados  
**Público:** Grupo de RPG com até 7 usuários. A verificação deste incremento usa o grupo completo: 1 admin e 6 jogadores.

A linguagem dos contextos está em [docs/linguagem.md](docs/linguagem.md). A ordem das próximas features está em [docs/roadmap.md](docs/roadmap.md).

Este documento substitui a versão 1.1. A versão 2.1 troca a posse do inventário, neste incremento, do personagem para o usuário: personagem e ficha não existem, e a verificação usa sete usuários já provisionados, cada um com um inventário já criado. Saíram deste incremento a quantidade de unidades por entrada, a alteração de limites pelo jogador, o Arsenal, o item personalizado como fase separada, o inventário de veículo e o resumo de pontos do grupo. A aplicação, a infraestrutura e a interface ainda descrevem o modelo antigo e não realizam estes requisitos.

---

## 1. Como as frases se separam

Cada frase ocupa um só lugar.

| Tipo | O que afirma | Fonte |
|---|---|---|
| Regra de negócio | Verdade do jogo, declarativa e atômica. Continua válida escrita fora do sistema. | *Business Rules Manifesto* (Business Rules Group); vocabulário e regras no espírito do SBVR (OMG) |
| Requisito funcional | Função que o usuário observa ou comanda. | ISO/IEC/IEEE 29148:2018 |
| Requisito não funcional | Qualidade ou restrição sobre como o sistema sustenta as funções. | ISO/IEC/IEEE 29148:2018, para requisitos de qualidade e restrições. Características nomeadas pela ISO/IEC 25010:2023 |

Critério prático:

- A frase fala do jogo, sem tela e sem banco: regra de negócio.
- A frase fala do que o sistema faz diante do usuário: requisito funcional.
- A frase fala de isolamento, preservação, clareza ou de uma restrição sobre a solução: requisito não funcional.

O requisito cita a regra que operacionaliza. A fórmula fica na regra. O caso de uso, no fim, é cenário de verificação.

Características exigidas pela ISO/IEC/IEEE 29148: necessário, não ambíguo, consistente, verificável, singular e livre de tecnologia de implementação.

---

## 2. Escopo

### 2.1. Neste incremento

- Sete usuários já provisionados: um com papel admin e seis com papel jogador.
- Um inventário individual já criado para cada um desses usuários.
- Atuar como qualquer um dos sete e consultar o inventário de quem atua.
- Incluir um item a partir dos dados informados por quem atua, sem catálogo.
- Alterar os dados de um item do inventário.
- Remover um item do inventário.
- Calcular pontos de categoria e espaço, e apresentar a situação diante dos limites.

O inventário já nasce criado para o usuário. Quem atua não cria nem exclui inventário, usuário ou ficha.

### 2.2. Fora deste incremento

Cadastro de usuário, alteração de papel, criação de ficha e de personagem, catálogo e Arsenal, habilidades, atributos, perícias, vida, sanidade, ficha completa, inventário compartilhado e inventário de veículo. A ordem está no roadmap. O papel admin não publica no catálogo neste incremento.

---

## 3. Definições

| Termo | Definição |
|---|---|
| Usuário | Pessoa que atua no sistema neste incremento. Tem um papel: admin ou jogador. |
| Admin | Papel de um dos sete usuários provisionados. Neste incremento não publica no catálogo. |
| Jogador | Papel de seis dos sete usuários provisionados. |
| Inventário | Conjunto dos itens de um usuário, com limites e totais. |
| Item de inventário | Uma entrada do inventário. Representa um item, não uma quantidade de unidades. |
| Especificação do item | Nome, descrição, espaço, categoria e detalhe conforme o tipo. |
| Categoria | Nível de custo do item. |
| Custo da categoria | Valor numérico do nível. |
| Pontos do item | Custo da categoria desse item. |
| Pontos utilizados | Soma dos pontos dos itens do inventário. |
| Pontos da categoria | Soma dos pontos dos itens daquela categoria. |
| Limite de categoria | Máximo de pontos de categoria do inventário neste incremento: 16. |
| Pontos disponíveis | Limite de categoria menos os pontos utilizados. |
| Espaço do item | Espaço ocupado pela entrada. |
| Espaço utilizado | Soma do espaço dos itens. |
| Limite de espaço | Máximo de espaço do inventário neste incremento: 20. |
| Espaço disponível | Limite de espaço menos o espaço utilizado. |
| Situação do inventário | Dentro dos limites, em excesso de categoria, em excesso de espaço, ou nos dois excessos. |

### 3.1. Vocabulário fechado

**Categoria.** Sem categoria (custo 0), I (1), II (2), III (3), IV (4), V (5).

**Tipo de item.** Acessório, arma, explosivo, munição, operacional, proteção.

**Alcance.** Curto, médio, longo, extremo.

**Domínio.** Simples, tático, pesado.

**Empunhadura.** Uma mão, duas mãos, versátil.

**Tipo de arma.** Arremesso, corpo a corpo, disparo, fogo.

**Tipo de dano.** Balístico, conhecimento, corte, eletricidade, energia, fogo, frio, impacto, mental, medo, morte, perfuração, químico, sangue.

**Tipo de traço.** Letal, ocultável.

**Tipo de proteção.** Leve, pesada.

**Tipo de munição.** Curtas, escopeta, flechas, granadas, longas.

---

## 4. Requisitos funcionais

| ID | Requisito | Regras |
|---|---|---|
| RF01 | O sistema deve disponibilizar, para cada um dos sete usuários provisionados, um inventário individual já criado. | RN01, RN02, RN03 |
| RF02 | O sistema deve permitir consultar o inventário do usuário que atua, com itens, limites, totais e situação. | RN21–RN25, RN34–RN37 |
| RF03 | O sistema deve permitir consultar um item do inventário. | RN04 |
| RF04 | O sistema deve permitir incluir um item a partir da especificação informada pelo usuário que atua. | RN05–RN18, RN26 |
| RF05 | O sistema deve permitir alterar a especificação de um item do inventário e, na munição, a quantidade já utilizada. | RN05–RN18, RN26, RN27 |
| RF06 | O sistema deve permitir remover um item do inventário. | RN28, RN29, RN30, RN31 |
| RF07 | O sistema deve calcular os pontos utilizados, os pontos disponíveis e os pontos de cada categoria. | RN08, RN21, RN22, RN23 |
| RF08 | O sistema deve calcular o espaço utilizado e o espaço disponível. | RN09, RN24, RN25 |
| RF09 | O sistema deve apresentar a situação do inventário, distinguindo excesso de categoria e excesso de espaço. | RN35, RN36 |
| RF10 | O sistema deve recusar inclusão ou alteração inválida e manter o inventário como estava. | RN26, RN32 |
| RF11 | O sistema deve apresentar o inventário conforme o estado resultante de uma operação aceita. | RN33 |
| RF12 | O sistema deve persistir o inventário e devolvê-lo após o encerramento da aplicação, com os mesmos itens, limites e totais. | RN04 |
| RF13 | O sistema deve disponibilizar sete usuários já provisionados, um com papel admin e seis com papel jogador. | RST01 |
| RF14 | O sistema deve permitir atuar como qualquer um desses sete usuários. | RN02, RN38 |
| RF15 | O sistema deve aplicar a consulta, a inclusão, a alteração e a remoção ao inventário do usuário que atua. | RN01, RN02, RN38 |

### 4.1. Dados informados na inclusão e na alteração

| Dado | Presença |
|---|---|
| Nome | Obrigatório |
| Descrição | Opcional |
| Categoria | Obrigatória, conforme o vocabulário |
| Espaço | Obrigatório |
| Detalhe do tipo | Obrigatório e compatível com o tipo |
| Quantidade de munição já utilizada | Somente munição. Na inclusão, zero |

Arma: alcance, domínio, empunhadura, tipo de arma, dano, crítico e a lista de traços.

Acessório: perícia a que se aplica e bônus. A perícia é um nome até o incremento de perícias.

Explosivo: alcance e dano.

Munição: tipo e capacidade. A quantidade já utilizada acompanha o item no inventário.

Proteção: tipo e bônus de defesa.

Operacional: nenhum dado além da especificação comum.

Dano: tipo e expressão. A expressão informa quantidade de dados, faces opcionais e bônus.

Crítico: margem e multiplicador.

Traço, quando houver: tipo e descrição.

---

## 5. Requisitos não funcionais

Característica de qualidade conforme a ISO/IEC 25010:2023.

| ID | Característica | Requisito |
|---|---|---|
| RNF01 | Manutenibilidade (testabilidade) | As regras do inventário devem poder ser verificadas por teste automatizado, sem interface gráfica e sem serviço externo. |
| RNF02 | Manutenibilidade (modularidade) | As regras do inventário devem permanecer independentes da interface e da tecnologia de persistência. |
| RNF03 | Manutenibilidade (modificabilidade) | Incluir um item cuja especificação tenha sido copiada de um catálogo futuro deve reutilizar o mesmo cálculo de limites e de totais da inclusão informada pelo usuário. |
| RNF04 | Confiabilidade | Uma operação recusada não deve deixar item incluído, alterado ou removido pela metade. |
| RNF05 | Confiabilidade | Pontos e espaço consultados após recuperar o inventário devem corresponder aos itens recuperados. |
| RNF06 | Segurança | A alteração do inventário de um usuário deve permanecer isolada dos inventários dos demais usuários. |
| RNF07 | Usabilidade | Pontos utilizados, pontos disponíveis, espaço utilizado e espaço disponível devem aparecer como informações distintas. |
| RNF08 | Usabilidade | A mensagem de recusa deve nomear a condição violada, em linguagem do jogo. |
| RNF09 | Usabilidade | Excesso de categoria e excesso de espaço devem poder ser reconhecidos separadamente. |

### 5.1. Restrições

| ID | Restrição |
|---|---|
| RST01 | Este incremento não inclui cadastro de usuário, alteração de papel, criação de ficha ou de personagem, nem criação ou exclusão de inventário. Os sete usuários e os seus inventários já nascem provisionados. |
| RST02 | O limite de categoria e o limite de espaço deste incremento são os de RN19 e RN20. A alteração desses limites por quem atua fica fora do incremento. |
| RST03 | O papel admin não acrescenta, neste incremento, função de catálogo. Admin e jogador operam o próprio inventário pelas mesmas regras. |

---

## 6. Regras de negócio

### 6.1. Inventário e usuário

Neste incremento não há personagem nem ficha. O inventário pertence ao usuário para o qual foi provisionado. O grupo do público continua de até sete pessoas. A população verificada neste incremento, um admin e seis jogadores, está em RST01.

| ID | Regra |
|---|---|
| RN01 | Cada usuário possui um inventário individual. |
| RN02 | Um inventário individual pertence a um único usuário. |
| RN03 | O usuário não cria nem exclui o inventário. |
| RN04 | Inventário e item de inventário possuem identidade própria. A identidade do item distingue o item dentro do inventário. |
| RN38 | O papel do usuário, admin ou jogador, não altera a posse do inventário nem as regras de item, limite e total. |

### 6.2. Especificação do item

| ID | Regra |
|---|---|
| RN05 | Todo item possui nome não vazio, uma categoria do vocabulário, espaço inteiro igual ou maior que zero e um detalhe compatível com o seu tipo. |
| RN06 | A descrição do item pode ser omitida. |
| RN07 | Uma entrada do inventário representa um item. Os pontos dessa entrada são o custo da categoria dela. |
| RN08 | O custo da categoria é 0 para sem categoria, 1 para I, 2 para II, 3 para III, 4 para IV e 5 para V. |
| RN09 | O espaço ocupado por uma entrada é o espaço informado na especificação. |

### 6.3. Detalhe conforme o tipo

| ID | Regra |
|---|---|
| RN10 | Arma possui alcance, domínio, empunhadura, tipo de arma, dano e crítico. Cada traço presente possui tipo admitido e descrição não vazia. A lista de traços pode ser vazia. |
| RN11 | O dano possui um tipo admitido e uma expressão cuja quantidade de dados é inteiro maior que zero. |
| RN12 | A margem do crítico é um inteiro de 1 a 20. O multiplicador do crítico é um inteiro maior ou igual a 2. |
| RN13 | Acessório informa a perícia a que se aplica, com nome não vazio, e um bônus inteiro maior que zero. |
| RN14 | Explosivo possui alcance admitido e dano. |
| RN15 | Munição possui um tipo admitido e capacidade inteira maior que zero. |
| RN16 | A quantidade de munição já utilizada é um inteiro de zero até a capacidade, inclusive. Item de munição incluído começa com quantidade utilizada igual a zero. |
| RN17 | Proteção possui tipo leve ou pesada e bônus de defesa inteiro maior que zero. |
| RN18 | Item operacional não possui dado além da especificação comum. |

### 6.4. Limites e totais

| ID | Regra |
|---|---|
| RN19 | O limite de categoria do inventário neste incremento é 16 pontos. |
| RN20 | O limite de espaço do inventário neste incremento é 20. |
| RN21 | Os pontos utilizados são a soma dos pontos dos itens. |
| RN22 | Os pontos de uma categoria são a soma dos pontos dos itens dessa categoria. |
| RN23 | Os pontos disponíveis são o limite de categoria menos os pontos utilizados. |
| RN24 | O espaço utilizado é a soma do espaço dos itens. |
| RN25 | O espaço disponível é o limite de espaço menos o espaço utilizado. |

### 6.5. Inclusão, alteração e remoção

| ID | Regra |
|---|---|
| RN26 | Inclusão ou alteração cujo resultado deixe os pontos utilizados acima do limite de categoria, ou o espaço utilizado acima do limite de espaço, é inválida. |
| RN27 | A alteração vale para um item já presente. A especificação anterior deixa de compor os totais. Na munição, a quantidade já utilizada informada substitui a anterior e obedece RN16. |
| RN28 | A remoção vale para um item já presente. |
| RN29 | A remoção retira o item do inventário. |
| RN30 | A remoção retira dos totais os pontos e o espaço daquele item. |
| RN31 | Alteração ou remoção de item que não pertence ao inventário é inválida. |
| RN32 | Operação inválida deixa o inventário como estava. |
| RN33 | Após operação aceita, os totais e a situação correspondem aos itens presentes e aos limites. |

### 6.6. Situação

| ID | Regra |
|---|---|
| RN34 | O inventário está dentro dos limites quando os pontos utilizados são menores ou iguais a 16 e o espaço utilizado é menor ou igual a 20. |
| RN35 | Há excesso de categoria quando os pontos utilizados são maiores que 16. |
| RN36 | Há excesso de espaço quando o espaço utilizado é maior que 20. |
| RN37 | Consultar o inventário ou um item não altera itens, limites nem totais. |

RN35 e RN36 descrevem a situação observável. Neste incremento, inclusão e alteração que produziriam esses excessos são inválidas (RN26). A remoção permanece válida.

---

## 7. Casos de uso

Cenários de verificação dos requisitos. O ator é o usuário que atua, admin ou jogador.

### UC01 — Consultar inventário

**Requisitos:** RF02, RF03, RF07, RF08, RF09.

**Pré-condição:** o usuário que atua possui inventário já criado. Não existe ficha.

1. O usuário pede o inventário.
2. O sistema mostra os itens, os limites, os pontos, o espaço e a situação.

**Pós-condição:** o inventário permanece como estava (RN37).

### UC02 — Incluir item

**Requisitos:** RF04, RF07, RF08, RF10, RF11.

**Pré-condição:** o inventário existe.

1. O usuário informa a especificação do item.
2. O sistema confere a especificação e os limites.
3. O sistema inclui o item e mostra o inventário atualizado.

**Alternativas:** especificação inválida, ou resultado acima de um limite: o sistema recusa e o inventário permanece como estava.

### UC03 — Alterar item

**Requisitos:** RF05, RF07, RF08, RF10, RF11.

**Pré-condição:** o item pertence ao inventário.

1. O usuário indica o item e informa a nova especificação.
2. O sistema confere a especificação e os limites, desconsiderando a contribuição anterior desse item.
3. O sistema substitui os dados e mostra o inventário atualizado.

**Alternativas:** as mesmas de UC02. Item ausente: o sistema recusa.

### UC04 — Remover item

**Requisitos:** RF06, RF07, RF08, RF11.

**Pré-condição:** o item pertence ao inventário.

1. O usuário indica o item.
2. O sistema retira o item e mostra os totais sem a contribuição dele.

**Alternativa:** item ausente: o sistema recusa e o inventário permanece como estava.

### UC05 — Verificar a mesa de sete usuários

**Requisitos:** RF01, RF13, RF14, RF15, RNF06.

**Pré-condição:** os sete usuários e os sete inventários já estão provisionados. Não há ficha nem comando para criá-la.

1. Confere-se um usuário com papel admin e seis com papel jogador.
2. Cada usuário pede o próprio inventário, já criado.
3. Um usuário inclui, altera ou remove um item no próprio inventário.
4. Os inventários dos outros seis usuários permanecem como estavam.

**Pós-condição:** não surge ficha, usuário nem inventário novo (RN03, RST01).

---

## 8. Critérios de aceitação

| ID | Critério | Origem |
|---|---|---|
| CA01 | O usuário consulta o próprio inventário já criado, sem criar inventário e sem criar ficha. | RF01, RF02, RST01 |
| CA02 | Um item com nome vazio, categoria fora do vocabulário, espaço negativo ou detalhe incompatível com o tipo é recusado. | RF04, RF10, RN05 |
| CA03 | Um item cuja inclusão deixe os pontos acima de 16, ou o espaço acima de 20, é recusado, e o inventário anterior permanece. | RF10, RN26, RN32 |
| CA04 | Após inclusão aceita, os pontos utilizados são a soma dos custos das categorias dos itens. | RF07, RN07, RN21 |
| CA05 | Após inclusão aceita, o espaço utilizado é a soma do espaço dos itens. | RF08, RN24 |
| CA06 | Alterar um item deixa de contar o custo e o espaço anteriores e passa a contar os novos. | RF05, RN27 |
| CA07 | Alteração que deixe o inventário acima de qualquer limite é recusada, e o item permanece como estava. | RF10, RN26, RN32 |
| CA08 | Remover um item retira os pontos e o espaço dele dos totais. | RF06, RN30 |
| CA09 | Remover um item ausente é recusado. | RF06, RN31 |
| CA10 | Munição incluída começa com quantidade utilizada zero. Quantidade utilizada acima da capacidade, ou negativa, é recusada. | RF04, RF05, RN16 |
| CA11 | Arma com margem de crítico fora de 1 a 20, ou com multiplicador menor que 2, é recusada. | RF04, RN12 |
| CA12 | Pontos de uma categoria são a soma dos custos dos itens dessa categoria. | RF07, RN22 |
| CA13 | Excesso de categoria e excesso de espaço são reconhecíveis separadamente. | RF09, RNF09 |
| CA14 | Depois de encerrar e abrir de novo, itens, limites e totais são os mesmos. | RF12, RNF05 |
| CA15 | A mensagem de recusa nomeia a condição violada, em linguagem do jogo. | RNF08 |
| CA16 | Os usuários provisionados são um admin e seis jogadores. Cada um encontra o próprio inventário já criado. | RF01, RF13, RN01 |
| CA17 | Uma operação no inventário de um usuário deixa itens, limites e totais dos outros inventários como estavam. | RF15, RNF06, RN02 |
| CA18 | Admin e jogador incluem, alteram e removem item no próprio inventário pelas mesmas regras. | RF14, RF15, RN38, RST03 |

---

## 9. Referências

- ISO/IEC/IEEE 29148:2018 — *Systems and software engineering — Life cycle processes — Requirements engineering*
- ISO/IEC 25010:2023 — *Systems and software engineering — Systems and software Quality Requirements and Evaluation (SQuaRE) — Product quality model*
- Business Rules Group — *Business Rules Manifesto*
- Object Management Group — *Semantics of Business Vocabulary and Business Rules* (SBVR)
