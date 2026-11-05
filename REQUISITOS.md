# Requisitos do Sistema — Gerenciador de Inventário RPG

**Projeto:** CACS  
**Documento:** Requisitos funcionais, requisitos não funcionais e regras de negócio  
**Versão:** 1.1  
**Status:** Em elaboração  
**Escopo atual:** Gerenciamento de inventário individual  
**Público-alvo:** Grupo de RPG com até 7 usuários

---

## 1. Introdução

### 1.1. Objetivo

Este documento especifica os requisitos funcionais, requisitos não funcionais e regras de negócio do sistema de gerenciamento de inventário de RPG.

O sistema será desenvolvido de forma incremental, permitindo a implementação de funcionalidades em módulos independentes e a ampliação progressiva de seu escopo.

A primeira versão terá como objetivo o gerenciamento de inventários individuais previamente estabelecidos, permitindo consultar, adicionar, alterar e remover itens, respeitando os limites de categoria e espaço definidos pelas regras do RPG.

O desenvolvimento posterior contemplará a criação de itens personalizados, a seleção de itens disponíveis no Arsenal, a aplicação de modificações nos itens e o gerenciamento de inventários compartilhados de veículos.

### 1.2. Objetivo do produto

O objetivo final do sistema é disponibilizar um gerenciador de fichas de RPG para um grupo de até 7 usuários.

Cada usuário poderá gerenciar uma ou mais fichas. Cada ficha representará exatamente um personagem, que possuirá atributos, vida, habilidades e inventário.

Cada personagem terá um inventário individual. Adicionalmente, o sistema poderá disponibilizar inventários compartilhados, como o inventário de um veículo, acessíveis aos integrantes do grupo.

O desenvolvimento será realizado em etapas, iniciando pelo gerenciamento de inventários e evoluindo posteriormente para o gerenciamento completo de personagens e fichas.

### 1.3. Referência para elaboração dos requisitos

A especificação utiliza como referência os princípios de engenharia de requisitos da ISO/IEC/IEEE 29148:2018.

Os requisitos devem ser necessários, claros, consistentes, viáveis e verificáveis. Sempre que possível, devem descrever o comportamento esperado do sistema sem determinar antecipadamente sua implementação.

Referência: [ISO/IEC/IEEE 29148:2018 — Requirements Engineering](https://www.iso.org/standard/72089.html).

---

## 2. Escopo

### 2.1. Escopo atual — Gerenciamento de inventário

O escopo atual contempla o gerenciamento de inventários individuais previamente estabelecidos.

O sistema deverá permitir:

- Consultar o inventário individual disponibilizado ao usuário.
- Consultar os itens cadastrados no inventário.
- Adicionar itens ao inventário.
- Alterar os dados dos itens cadastrados.
- Remover itens do inventário.
- Calcular os pontos de categoria utilizados.
- Calcular o espaço utilizado.
- Consultar os pontos e o espaço disponíveis.
- Alterar os limites de categoria e espaço.
- Identificar quando o inventário ultrapassar algum limite.
- Persistir os itens selecionados e as alterações realizadas.

O inventário será responsável por manter a consistência de seus itens e calcular os valores derivados.

O usuário não será responsável por criar ou excluir inventários.

### 2.2. Escopo futuro — Criação de itens personalizados

Após a implementação funcional do inventário, será disponibilizada a criação de itens personalizados.

O usuário poderá cadastrar itens próprios, informando suas características e custos.

Os itens personalizados deverão respeitar as mesmas regras de categoria, quantidade, espaço e limites aplicáveis aos demais itens.

Os itens personalizados serão persistidos separadamente dos itens padrão do Arsenal.

### 2.3. Escopo futuro — Arsenal

Após a implementação da criação de itens personalizados, será disponibilizado o Arsenal.

O Arsenal será responsável por apresentar o catálogo de itens padrão disponíveis no RPG.

O usuário poderá:

- Consultar os itens disponíveis.
- Buscar itens pelo nome.
- Consultar as características dos itens.
- Consultar seus custos de categoria.
- Consultar o espaço ocupado.
- Selecionar um item do Arsenal.
- Adicionar o item selecionado ao inventário individual.

Os itens padrão do Arsenal serão previamente cadastrados e persistidos em uma estrutura própria.

A seleção de um item do Arsenal deverá criar um registro correspondente no inventário do usuário, sem alterar o cadastro original do item padrão.

### 2.4. Escopo futuro — Modificações de itens

O sistema deverá permitir aplicar modificações aos itens, conforme as regras do RPG.

Uma modificação poderá:

- Alterar características do item.
- Conceder bônus.
- Aumentar ou diminuir valores associados ao item.
- Alterar o custo de categoria do item.
- Possuir requisitos de aplicação.

As modificações não serão consideradas itens independentes do inventário.

Uma modificação deverá estar associada a um item e produzir seus efeitos sobre esse item.

Exemplo: uma pistola pode receber uma mira laser, que concede determinado bônus e aumenta sua categoria em um nível.

A aplicação de modificações deverá respeitar as regras de categoria e espaço do inventário.

### 2.5. Escopo futuro — Inventário de veículo

O sistema deverá permitir o gerenciamento de inventários compartilhados de veículos.

O inventário de um veículo será acessível aos integrantes do grupo, além dos inventários individuais dos personagens.

O inventário de veículo deverá possuir regras próprias de acesso e capacidade, conforme as características do veículo.

Essa funcionalidade será implementada após a disponibilização do Arsenal.

### 2.6. Funcionalidades fora do escopo atual

As seguintes funcionalidades não serão implementadas na primeira versão:

- Cadastro e autenticação de usuários.
- Criação de fichas.
- Gerenciamento de personagens.
- Gerenciamento de atributos.
- Gerenciamento de vida.
- Gerenciamento de habilidades.
- Associação de inventários a fichas.
- Arsenal.
- Criação de itens personalizados.
- Modificações de itens.
- Inventários compartilhados.
- Inventários de veículos.
- Gerenciamento de recursos compartilhados do grupo.

Essas funcionalidades serão incorporadas em etapas posteriores, conforme a evolução do sistema.

### 2.7. Evolução prevista do produto

A evolução planejada do sistema é:

1. Gerenciamento funcional de inventários individuais.
2. Criação e gerenciamento de itens personalizados.
3. Arsenal de itens padrão e seleção de itens para o inventário.
4. Aplicação de modificações nos itens.
5. Gerenciamento de inventários compartilhados de veículos.
6. Gerenciamento de fichas e personagens.
7. Gerenciamento de atributos, vida e habilidades.
8. Associação de inventários às fichas.
9. Gerenciamento de usuários e recursos compartilhados do grupo.

A ordem representa o planejamento atual e poderá ser ajustada conforme as necessidades do projeto.

---

## 3. Definições e terminologia

| Termo | Definição |
|---|---|
| Inventário | Conjunto de itens pertencentes a um personagem ou veículo. |
| Inventário individual | Inventário associado exclusivamente a um personagem. |
| Inventário compartilhado | Inventário acessível a mais de um usuário, conforme as permissões definidas. |
| Item | Elemento individual cadastrado em um inventário. |
| Item padrão | Item previamente cadastrado no catálogo do Arsenal. |
| Item personalizado | Item criado pelo usuário para utilização em seu inventário. |
| Arsenal | Catálogo de itens padrão disponíveis para consulta e seleção. |
| Categoria | Classificação de um item que determina seu custo em pontos de categoria. |
| Nível da categoria | Valor de I a V associado ao custo de categoria de um item. |
| Quantidade | Número inteiro de unidades representadas por um item do inventário. |
| Pontos do item | Custo de categoria calculado a partir do nível da categoria e da quantidade. |
| Pontos utilizados | Soma dos pontos de categoria de todos os itens do inventário. |
| Limite de categoria | Quantidade máxima de pontos de categoria definida para o inventário. |
| Pontos disponíveis | Diferença entre o limite de categoria e os pontos utilizados. |
| Espaço do item | Espaço ocupado por uma unidade do item. |
| Espaço utilizado | Soma do espaço ocupado por todos os itens do inventário. |
| Limite de espaço | Capacidade máxima de espaço definida para o inventário. |
| Espaço disponível | Diferença entre o limite de espaço e o espaço utilizado. |
| Modificação | Alteração aplicada a um item que modifica suas características ou efeitos. |
| Ficha | Representação de um personagem no sistema. |
| Personagem | Entidade do RPG representada por uma ficha. |
| Usuário | Pessoa que utiliza o sistema para gerenciar suas fichas e inventários. |
| Grupo | Conjunto de usuários que compartilham recursos ou informações no contexto do RPG. |
| Veículo | Elemento do RPG que pode possuir um inventário compartilhado. |

---

# 4. Requisitos funcionais

Os requisitos funcionais descrevem as funcionalidades e os comportamentos que o sistema deverá oferecer.

## 4.1. Gerenciamento de inventário individual

| ID | Requisito funcional | Prioridade |
|---|---|---|
| RF01 | O sistema deve disponibilizar um inventário individual previamente estabelecido para cada personagem ou usuário provisionado. | Alta |
| RF02 | O sistema deve permitir consultar o inventário individual disponibilizado ao usuário. | Alta |
| RF03 | O sistema deve permitir consultar os itens cadastrados no inventário. | Alta |
| RF04 | O sistema deve permitir adicionar itens ao inventário. | Alta |
| RF05 | O sistema deve permitir informar os dados necessários para o cadastro de um item personalizado. | Alta |
| RF06 | O sistema deve permitir consultar os dados de um item individualmente. | Média |
| RF07 | O sistema deve permitir alterar os dados de um item cadastrado. | Alta |
| RF08 | O sistema deve permitir remover um item do inventário. | Alta |
| RF09 | O sistema deve permitir consultar os limites de categoria e espaço do inventário. | Alta |
| RF10 | O sistema deve calcular os pontos de categoria utilizados pelo inventário. | Alta |
| RF11 | O sistema deve calcular o espaço utilizado pelo inventário. | Alta |
| RF12 | O sistema deve calcular os pontos de categoria disponíveis no inventário. | Alta |
| RF13 | O sistema deve calcular o espaço disponível no inventário. | Alta |
| RF14 | O sistema deve permitir alterar os limites de categoria e espaço do inventário. | Alta |
| RF15 | O sistema deve identificar quando os pontos de categoria utilizados ultrapassarem o limite definido. | Alta |
| RF16 | O sistema deve identificar quando o espaço utilizado ultrapassar o limite definido. | Alta |
| RF17 | O sistema deve apresentar o estado atualizado do inventário após uma operação válida. | Alta |
| RF18 | O sistema deve permitir consultar os itens e os valores calculados do inventário. | Alta |

### 4.1.1. Dados de um item

O cadastro de um item deverá contemplar os seguintes dados:

| Campo | Descrição |
|---|---|
| Identificador | Identificação individual do item no inventário. |
| Nome | Nome do item. |
| Descrição | Descrição detalhada do item. |
| Categoria | Categoria à qual o item pertence. |
| Quantidade | Quantidade inteira de unidades representadas pelo item. |
| Espaço | Espaço ocupado por uma unidade do item. |

Os itens personalizados poderão possuir características adicionais conforme a evolução do sistema.

### 4.1.2. Dados de um inventário

O inventário deverá possuir:

| Campo | Descrição |
|---|---|
| Identificador | Identificação individual do inventário. |
| Limite de categoria | Quantidade máxima de pontos de categoria permitida. |
| Limite de espaço | Capacidade máxima de espaço permitida. |
| Itens | Conjunto de itens cadastrados no inventário. |
| Pontos utilizados | Soma dos pontos de categoria dos itens. |
| Espaço utilizado | Soma do espaço ocupado pelos itens. |
| Pontos disponíveis | Diferença entre o limite de categoria e os pontos utilizados. |
| Espaço disponível | Diferença entre o limite de espaço e o espaço utilizado. |
| Situação do inventário | Indicação de conformidade ou excesso em relação aos limites. |

Os valores de pontos utilizados, espaço utilizado, pontos disponíveis, espaço disponível e situação do inventário deverão ser calculados a partir dos dados do inventário.

---

## 4.2. Gerenciamento de limites

| ID | Requisito funcional | Prioridade |
|---|---|---|
| RF19 | O sistema deve permitir alterar o limite de categoria de um inventário. | Alta |
| RF20 | O sistema deve permitir alterar o limite de espaço de um inventário. | Alta |
| RF21 | O sistema deve recalcular os valores disponíveis após a alteração de um limite. | Alta |
| RF22 | O sistema deve permitir a alteração de um limite mesmo quando o novo valor resultar em excesso de categoria ou espaço. | Alta |
| RF23 | O sistema deve apresentar um aviso quando a alteração de um limite resultar em inventário fora de limite. | Alta |
| RF24 | O sistema deve manter os itens cadastrados após a alteração de um limite. | Alta |

---

## 4.3. Criação de itens personalizados

Os requisitos desta seção representam a próxima etapa de desenvolvimento.

| ID | Requisito funcional |
|---|---|
| RF25 | O sistema deve permitir criar itens personalizados para o inventário. |
| RF26 | O sistema deve permitir informar o nome, a descrição, a categoria, a quantidade e o espaço do item personalizado. |
| RF27 | O sistema deve permitir alterar os dados de um item personalizado. |
| RF28 | O sistema deve permitir remover um item personalizado. |
| RF29 | O sistema deve aplicar as mesmas regras de categoria, quantidade e espaço aos itens personalizados. |
| RF30 | O sistema deve persistir os itens personalizados separadamente dos itens padrão do Arsenal. |

---

## 4.4. Arsenal

Os requisitos desta seção representam a etapa posterior à criação de itens personalizados.

| ID | Requisito funcional |
|---|---|
| RF31 | O sistema deve disponibilizar um Arsenal contendo os itens padrão do RPG. |
| RF32 | O sistema deve permitir consultar os itens disponíveis no Arsenal. |
| RF33 | O sistema deve permitir buscar itens do Arsenal pelo nome. |
| RF34 | O sistema deve permitir consultar a descrição, categoria, custo e espaço dos itens do Arsenal. |
| RF35 | O sistema deve permitir selecionar um item do Arsenal para inclusão no inventário individual. |
| RF36 | O sistema deve permitir informar a quantidade do item selecionado. |
| RF37 | O sistema deve validar os limites do inventário antes de adicionar um item do Arsenal. |
| RF38 | O sistema deve persistir a seleção do item no inventário sem alterar o cadastro original do item padrão. |
| RF39 | O sistema deve permitir consultar os itens selecionados a partir do inventário individual. |

---

## 4.5. Modificações de itens

Os requisitos desta seção representam uma etapa futura.

| ID | Requisito funcional |
|---|---|
| RF40 | O sistema deve permitir consultar as modificações disponíveis para os itens. |
| RF41 | O sistema deve permitir aplicar modificações compatíveis com um item. |
| RF42 | O sistema deve permitir remover modificações aplicadas a um item. |
| RF43 | O sistema deve calcular os efeitos das modificações aplicadas. |
| RF44 | O sistema deve calcular o custo de categoria do item considerando suas modificações. |
| RF45 | O sistema deve permitir consultar as modificações aplicadas a um item. |
| RF46 | O sistema deve validar os requisitos de aplicação das modificações. |
| RF47 | O sistema deve recalcular os pontos de categoria e o espaço do inventário após alterações nos itens modificados. |

---

## 4.6. Inventário de veículo

Os requisitos desta seção representam uma etapa futura, posterior à disponibilização do Arsenal.

| ID | Requisito funcional |
|---|---|
| RF48 | O sistema deve permitir disponibilizar um inventário compartilhado para um veículo. |
| RF49 | O sistema deve permitir consultar os itens do inventário de veículo. |
| RF50 | O sistema deve permitir adicionar itens ao inventário de veículo. |
| RF51 | O sistema deve permitir alterar itens do inventário de veículo. |
| RF52 | O sistema deve permitir remover itens do inventário de veículo. |
| RF53 | O sistema deve permitir que os integrantes autorizados do grupo acessem o inventário de veículo. |
| RF54 | O sistema deve controlar os limites de categoria e espaço do inventário de veículo. |

---

## 4.7. Evolução futura — Fichas e personagens

| ID | Requisito funcional |
|---|---|
| RF55 | O sistema deve permitir que um usuário gerencie uma ou mais fichas. |
| RF56 | O sistema deve permitir criar uma ficha de personagem. |
| RF57 | O sistema deve permitir consultar uma ficha de personagem. |
| RF58 | O sistema deve permitir alterar os dados de uma ficha. |
| RF59 | O sistema deve permitir excluir uma ficha. |
| RF60 | Cada ficha deve representar exatamente um personagem. |
| RF61 | Cada personagem deve possuir um inventário individual. |
| RF62 | O sistema deve permitir consultar o inventário a partir da ficha do personagem. |
| RF63 | O sistema deve permitir gerenciar os atributos do personagem. |
| RF64 | O sistema deve permitir gerenciar as habilidades do personagem. |
| RF65 | O sistema deve permitir controlar a vida do personagem. |
| RF66 | O sistema deve calcular o limite de categoria conforme os atributos do personagem. |
| RF67 | O sistema deve calcular o limite de espaço conforme os atributos do personagem. |

---

## 4.8. Evolução futura — Usuários e grupo

| ID | Requisito funcional |
|---|---|
| RF68 | O sistema deve permitir o cadastro de usuários. |
| RF69 | O sistema deve permitir que os usuários acessem suas fichas. |
| RF70 | O sistema deve permitir a formação de um grupo com até 7 usuários. |
| RF71 | O sistema deve permitir consultar os recursos compartilhados do grupo. |
| RF72 | O sistema deve permitir gerenciar os recursos compartilhados do grupo. |
| RF73 | O sistema deve permitir compartilhar informações conforme as permissões definidas. |

---

# 5. Requisitos não funcionais

Os requisitos não funcionais descrevem atributos de qualidade e restrições operacionais do sistema.

Os requisitos desta seção deverão ser verificáveis por meio de testes, inspeções ou evidências técnicas.

## 5.1. Arquitetura e manutenção

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF01 | O sistema deve permitir a evolução incremental de suas funcionalidades sem exigir a implementação antecipada dos módulos futuros. | Alta |
| RNF02 | As regras de negócio devem ser independentes da interface gráfica. | Alta |
| RNF03 | As regras de negócio devem ser independentes da tecnologia de persistência. | Alta |
| RNF04 | A alteração de uma regra de negócio deve exigir mudanças apenas nos componentes afetados por essa regra. | Alta |
| RNF05 | O sistema deve permitir a execução de testes automatizados sobre as regras de negócio sem depender da interface gráfica ou de serviços externos. | Alta |
| RNF06 | O sistema deve permitir a evolução do inventário individual para inventários compartilhados sem exigir a reimplementação das regras comuns de gerenciamento de itens. | Alta |
| RNF07 | O sistema deve permitir a evolução do modelo de limites para incorporar atributos do personagem sem exigir alterações desnecessárias nas regras de gerenciamento dos itens. | Alta |

## 5.2. Integridade e consistência

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF08 | O sistema deve manter a consistência dos dados do inventário após operações válidas. | Alta |
| RNF09 | Uma operação inválida não deve deixar o inventário em um estado parcialmente alterado. | Alta |
| RNF10 | Os dados calculados do inventário devem corresponder aos dados dos itens cadastrados. | Alta |
| RNF11 | O sistema deve preservar a integridade dos dados durante a persistência e recuperação do inventário. | Alta |
| RNF12 | O sistema deve manter a consistência entre o inventário e os itens persistidos. | Alta |

## 5.3. Persistência

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF13 | O sistema deve persistir os inventários e seus itens selecionados. | Alta |
| RNF14 | O sistema deve permitir recuperar os dados persistidos após o encerramento da aplicação. | Alta |
| RNF15 | A recuperação de um inventário deve preservar seus itens e limites configurados. | Alta |
| RNF16 | O sistema deve manter os itens padrão do Arsenal separados dos itens selecionados nos inventários. | Alta |
| RNF17 | A alteração de um item selecionado no inventário não deve modificar o cadastro original do item padrão do Arsenal. | Alta |
| RNF18 | O sistema deve permitir a persistência independente dos itens padrão e dos itens personalizados. | Alta |

## 5.4. Segurança e isolamento

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF19 | O sistema deve impedir alterações não autorizadas nos dados persistidos. | Alta |
| RNF20 | O sistema deve manter o isolamento dos dados pertencentes a diferentes inventários individuais. | Alta |
| RNF21 | O sistema deve garantir que usuários não autorizados não possam alterar inventários de outros personagens. | Alta |
| RNF22 | O sistema deve permitir acesso compartilhado apenas aos inventários explicitamente definidos como compartilhados. | Alta |

Os mecanismos de autenticação e autorização serão especificados quando o módulo de usuários for implementado.

## 5.5. Concorrência

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF23 | O sistema deve preservar a consistência dos dados quando ocorrerem alterações concorrentes sobre o mesmo inventário. | Média |
| RNF24 | O sistema deve impedir que alterações concorrentes resultem em perda silenciosa de dados. | Média |

O mecanismo de controle de concorrência será definido durante a implementação da persistência.

## 5.6. Usabilidade

| ID | Requisito não funcional | Prioridade |
|---|---|---|
| RNF25 | A interface deve apresentar os pontos de categoria utilizados e disponíveis de forma compreensível. | Alta |
| RNF26 | A interface deve apresentar o espaço utilizado e disponível de forma compreensível. | Alta |
| RNF27 | O sistema deve informar ao usuário quando uma operação for rejeitada por violar uma regra de negócio. | Alta |
| RNF28 | As mensagens de erro devem identificar a condição que impediu a operação, sem exigir que o usuário conheça detalhes internos da implementação. | Alta |
| RNF29 | A interface deve apresentar avisos visíveis quando o inventário ultrapassar os limites de categoria ou espaço. | Alta |
| RNF30 | Os avisos de excesso devem permitir identificar qual limite foi ultrapassado. | Alta |

---

# 6. Regras de negócio

As regras de negócio representam as condições e restrições que devem ser respeitadas independentemente da interface utilizada ou da tecnologia de persistência.

## 6.1. Regras de provisionamento do inventário

| ID | Regra de negócio |
|---|---|
| RN01 | Cada personagem deve possuir exatamente um inventário individual. |
| RN02 | O inventário individual deve ser previamente estabelecido pelo sistema. |
| RN03 | O usuário não deve criar ou excluir o inventário individual. |
| RN04 | Todo inventário deve possuir um identificador único. |
| RN05 | O inventário deve estar associado ao personagem ou usuário correspondente. |
| RN06 | Um inventário individual não deve ser compartilhado entre personagens. |

## 6.2. Regras de limite do inventário

| ID | Regra de negócio |
|---|---|
| RN07 | O limite de categoria de um inventário não pode ser negativo. |
| RN08 | O limite de espaço de um inventário não pode ser negativo. |
| RN09 | O limite de categoria poderá variar conforme o personagem. |
| RN10 | Na primeira versão, o limite de categoria será definido independentemente dos atributos do personagem. |
| RN11 | Na primeira versão, o limite de espaço será inicialmente definido como 20. |
| RN12 | O limite de espaço deverá ser definido de forma que possa ser substituído futuramente por um cálculo baseado nos atributos do personagem. |
| RN13 | Os limites do inventário poderão ser alterados após sua criação. |
| RN14 | A alteração de um limite poderá resultar em inventário fora de limite. |
| RN15 | A alteração de um limite não deverá remover automaticamente os itens existentes. |
| RN16 | A alteração de um limite deverá atualizar os valores disponíveis e a situação do inventário. |
| RN17 | O sistema deverá identificar separadamente o excesso de categoria e o excesso de espaço. |

## 6.3. Regras de cadastro de item

| ID | Regra de negócio |
|---|---|
| RN18 | Todo item deve possuir um identificador único dentro do inventário. |
| RN19 | Todo item deve possuir um nome válido. |
| RN20 | Todo item deve possuir uma categoria válida. |
| RN21 | A quantidade de um item deve ser um número inteiro maior que zero. |
| RN22 | Itens não podem possuir quantidades fracionárias. |
| RN23 | O espaço ocupado por uma unidade do item não pode ser negativo. |
| RN24 | O cadastro de um item deve respeitar os limites de categoria e espaço do inventário. |
| RN25 | O custo de categoria de um item deve ser calculado a partir de seu nível e quantidade. |
| RN26 | O espaço ocupado por um item deve ser calculado a partir do espaço de uma unidade multiplicado pela quantidade. |

## 6.4. Regras de categoria

| ID | Regra de negócio |
|---|---|
| RN27 | Os níveis válidos de categoria são I, II, III, IV e V. |
| RN28 | Cada nível de categoria deve possuir um valor numérico correspondente de 1 a 5. |
| RN29 | Os pontos de categoria de um item devem ser calculados pela multiplicação do nível da categoria pela quantidade do item. |
| RN30 | Os pontos de categoria de um inventário devem corresponder à soma dos pontos de todos os seus itens. |
| RN31 | O inventário não deve ultrapassar seu limite de pontos de categoria durante uma operação regular de inclusão ou alteração de item. |

### Cálculo dos pontos de categoria

O custo de categoria de um item será calculado pela seguinte fórmula:

`PontosItem = NivelCategoria × Quantidade`

Os pontos utilizados pelo inventário serão calculados pela soma dos pontos de todos os itens:

`PontosUtilizados = Σ PontosItem`

Os pontos disponíveis serão calculados pela diferença entre o limite de categoria e os pontos utilizados:

`PontosDisponiveis = LimiteCategoria − PontosUtilizados`

## 6.5. Regras de espaço

| ID | Regra de negócio |
|---|---|
| RN32 | O espaço utilizado pelo inventário deve corresponder à soma do espaço ocupado por todos os seus itens. |
| RN33 | O espaço ocupado por um item deve corresponder ao espaço de uma unidade multiplicado pela quantidade. |
| RN34 | O inventário não deve ultrapassar seu limite de espaço durante uma operação regular de inclusão ou alteração de item. |
| RN35 | O espaço disponível deve corresponder à diferença entre o limite de espaço e o espaço utilizado. |
| RN36 | A alteração da quantidade de um item deve considerar o impacto sobre o espaço total do inventário. |

### Cálculo do espaço

O espaço ocupado por um item será calculado pela seguinte fórmula:

`EspacoItem = EspacoUnitario × Quantidade`

O espaço utilizado será calculado pela soma do espaço ocupado pelos itens:

`EspacoUtilizado = Σ EspacoItem`

O espaço disponível será calculado pela diferença entre o limite de espaço e o espaço utilizado:

`EspacoDisponivel = LimiteEspaco − EspacoUtilizado`

## 6.6. Regras de alteração de item

| ID | Regra de negócio |
|---|---|
| RN37 | A alteração de um item deve respeitar os limites de categoria e espaço do inventário. |
| RN38 | A alteração de um item deve considerar seu custo anterior e seu novo custo. |
| RN39 | A alteração de um item não deve contabilizar seu custo anterior como um novo consumo de recursos. |
| RN40 | A alteração de um item deve ser rejeitada quando resultar em violação de qualquer limite. |
| RN41 | Uma alteração rejeitada não deve modificar o estado anterior do inventário. |
| RN42 | A alteração de um item deverá atualizar os valores calculados do inventário. |

### Exemplo de alteração

Considere um inventário com:

- Limite de categoria: 16 pontos.
- Pontos utilizados: 12.
- Pontos disponíveis: 4.

Um item existente possui categoria II e quantidade 2:

`PontosAtuais = 2 × 2 = 4`

Se a quantidade for alterada para 4:

`NovosPontos = 2 × 4 = 8`

O custo adicional será:

`CustoAdicional = NovosPontos − PontosAtuais`

`CustoAdicional = 8 − 4 = 4`

Como o inventário possui 4 pontos disponíveis, a operação pode ser realizada, desde que também respeite o limite de espaço.

## 6.7. Regras de alteração de limites

| ID | Regra de negócio |
|---|---|
| RN43 | A alteração de um limite deverá ser permitida quando o novo valor for válido. |
| RN44 | A alteração de um limite não deverá ser bloqueada apenas porque o inventário ficará fora de limite. |
| RN45 | O sistema deverá manter os itens existentes após a alteração do limite. |
| RN46 | O sistema deverá apresentar um aviso quando o inventário ultrapassar o limite de categoria. |
| RN47 | O sistema deverá apresentar um aviso quando o inventário ultrapassar o limite de espaço. |
| RN48 | O inventário deverá ser considerado fora de limite quando os pontos utilizados forem superiores ao limite de categoria ou quando o espaço utilizado for superior ao limite de espaço. |
| RN49 | O inventário deverá ser considerado dentro dos limites quando os pontos utilizados e o espaço utilizado forem menores ou iguais aos respectivos limites. |
| RN50 | A situação do inventário deverá ser recalculada após alterações nos itens ou nos limites. |

A situação fora de limite não deverá impedir a consulta ou a remoção de itens.

A inclusão ou alteração de itens deverá respeitar os limites vigentes, mesmo quando o inventário já estiver fora de limite.

## 6.8. Regras de remoção de item

| ID | Regra de negócio |
|---|---|
| RN51 | A remoção de um item deve retirar o item do inventário. |
| RN52 | A remoção de um item deve liberar os pontos de categoria anteriormente utilizados por ele. |
| RN53 | A remoção de um item deve liberar o espaço anteriormente ocupado por ele. |
| RN54 | A remoção de um item deve atualizar os valores calculados do inventário. |
| RN55 | A remoção de um item inexistente deve ser rejeitada ou tratada como uma operação sem alteração, conforme o contrato do caso de uso. |

## 6.9. Regras de consistência do inventário

| ID | Regra de negócio |
|---|---|
| RN56 | O inventário deve permanecer consistente após cada operação concluída com sucesso. |
| RN57 | Os pontos utilizados devem ser derivados dos itens cadastrados. |
| RN58 | O espaço utilizado deve ser derivado dos itens cadastrados. |
| RN59 | Os pontos disponíveis não podem ser negativos quando o inventário estiver dentro dos limites. |
| RN60 | O espaço disponível não pode ser negativo quando o inventário estiver dentro dos limites. |
| RN61 | Uma operação regular que viole os limites do inventário deve ser rejeitada. |
| RN62 | Uma alteração de limite que resulte em excesso deve ser permitida, desde que o novo limite seja válido. |

## 6.10. Regras do Arsenal

| ID | Regra de negócio |
|---|---|
| RN63 | O Arsenal deverá conter os itens padrão previamente cadastrados no sistema. |
| RN64 | Os itens padrão do Arsenal não deverão ser alterados diretamente por operações realizadas nos inventários. |
| RN65 | A seleção de um item do Arsenal deverá criar um registro correspondente no inventário. |
| RN66 | A alteração de um item selecionado não deverá modificar o item padrão do Arsenal. |
| RN67 | A inclusão de um item do Arsenal deverá respeitar os limites do inventário. |
| RN68 | Os itens padrão do Arsenal deverão ser persistidos separadamente dos itens selecionados nos inventários. |

## 6.11. Regras de itens personalizados

| ID | Regra de negócio |
|---|---|
| RN69 | Um item personalizado deverá possuir os dados obrigatórios de um item. |
| RN70 | Um item personalizado deverá respeitar os níveis válidos de categoria. |
| RN71 | Um item personalizado deverá respeitar as regras de quantidade e espaço. |
| RN72 | Um item personalizado deverá respeitar os limites do inventário no qual será cadastrado. |
| RN73 | Um item personalizado deverá ser persistido independentemente dos itens padrão do Arsenal. |

## 6.12. Regras de modificações de itens

| ID | Regra de negócio |
|---|---|
| RN74 | Uma modificação deverá estar associada a um item. |
| RN75 | Uma modificação não deverá ser contabilizada como um item independente do inventário. |
| RN76 | Uma modificação poderá alterar características ou efeitos do item. |
| RN77 | Uma modificação poderá alterar o custo de categoria do item. |
| RN78 | O custo de categoria do item deverá considerar as modificações aplicadas. |
| RN79 | A aplicação de uma modificação deverá respeitar os limites de categoria e espaço do inventário. |
| RN80 | A remoção de uma modificação deverá recalcular os valores do item e do inventário. |

As regras específicas de compatibilidade, bônus e cálculo de categoria das modificações deverão ser definidas conforme a mecânica do RPG.

## 6.13. Regras de inventários compartilhados

| ID | Regra de negócio |
|---|---|
| RN81 | Um inventário de veículo poderá ser acessado por mais de um usuário autorizado. |
| RN82 | O inventário de veículo deverá possuir um identificador próprio. |
| RN83 | O inventário de veículo deverá possuir limites próprios de categoria e espaço. |
| RN84 | O acesso ao inventário de veículo deverá ser independente do acesso aos inventários individuais. |
| RN85 | A alteração de um item no inventário de veículo deverá respeitar as regras desse inventário. |

---

# 7. Casos de uso principais

## UC01 — Consultar inventário individual

**Ator:** Usuário.

**Pré-condições:**

- O inventário individual deve estar previamente estabelecido.
- O usuário deve possuir acesso ao inventário.

**Fluxo principal:**

1. O usuário solicita a consulta do inventário.
2. O sistema recupera os dados do inventário.
3. O sistema apresenta os itens cadastrados.
4. O sistema apresenta os limites de categoria e espaço.
5. O sistema apresenta os pontos utilizados e disponíveis.
6. O sistema apresenta o espaço utilizado e disponível.
7. O sistema apresenta a situação do inventário.

**Pós-condição:**

- Nenhum dado do inventário deve ser alterado.

## UC02 — Adicionar item personalizado

**Ator:** Usuário.

**Pré-condições:**

- O inventário individual deve existir.
- O usuário deve possuir acesso ao inventário.

**Fluxo principal:**

1. O usuário solicita a inclusão de um item.
2. O usuário informa os dados do item.
3. O sistema valida os dados informados.
4. O sistema calcula os pontos de categoria do item.
5. O sistema calcula o espaço ocupado pelo item.
6. O sistema verifica os limites do inventário.
7. O sistema adiciona o item.
8. O sistema apresenta o inventário atualizado.

**Fluxos alternativos:**

- Se os dados do item forem inválidos, a operação é rejeitada.
- Se o limite de categoria for ultrapassado, a operação é rejeitada.
- Se o limite de espaço for ultrapassado, a operação é rejeitada.

**Pós-condição:**

- O item deve estar cadastrado.
- Os valores calculados devem refletir o novo estado.

## UC03 — Alterar item

**Ator:** Usuário.

**Pré-condições:**

- O inventário deve existir.
- O item deve estar cadastrado.

**Fluxo principal:**

1. O usuário seleciona um item.
2. O usuário informa os novos dados.
3. O sistema valida os dados.
4. O sistema calcula o custo anterior e o novo custo.
5. O sistema verifica os limites do inventário.
6. O sistema altera o item.
7. O sistema apresenta o inventário atualizado.

**Fluxos alternativos:**

- Se os dados forem inválidos, a operação é rejeitada.
- Se a alteração ultrapassar o limite de categoria, a operação é rejeitada.
- Se a alteração ultrapassar o limite de espaço, a operação é rejeitada.

**Pós-condição:**

- O item deve estar atualizado.
- O inventário deve permanecer dentro dos limites vigentes.

## UC04 — Remover item

**Ator:** Usuário.

**Pré-condições:**

- O inventário deve existir.
- O item deve estar cadastrado.

**Fluxo principal:**

1. O usuário seleciona o item.
2. O usuário solicita sua remoção.
3. O sistema remove o item.
4. O sistema recalcula os valores do inventário.
5. O sistema apresenta o inventário atualizado.

**Pós-condição:**

- O item não deve mais pertencer ao inventário.
- Os pontos e o espaço anteriormente utilizados devem estar disponíveis.

## UC05 — Alterar limite do inventário

**Ator:** Usuário autorizado.

**Pré-condições:**

- O inventário deve existir.
- O usuário deve possuir permissão para alterar os limites.

**Fluxo principal:**

1. O usuário solicita a alteração de um limite.
2. O usuário informa o novo valor.
3. O sistema valida o valor informado.
4. O sistema atualiza o limite.
5. O sistema recalcula os valores disponíveis.
6. O sistema verifica se o inventário ultrapassa algum limite.
7. O sistema apresenta o inventário atualizado.

**Fluxo alternativo:**

- Se o novo valor for inválido, a operação é rejeitada.
- Se o novo limite resultar em excesso, o sistema mantém a alteração e apresenta um aviso.

**Pós-condição:**

- O limite deve estar atualizado.
- Os itens existentes devem ser preservados.
- A situação do inventário deve refletir os limites atuais.

## UC06 — Consultar Arsenal

**Ator:** Usuário.

**Pré-condições:**

- O Arsenal deve estar disponível.

**Fluxo principal:**

1. O usuário acessa o Arsenal.
2. O sistema apresenta os itens padrão disponíveis.
3. O usuário consulta ou busca um item.
4. O sistema apresenta as características do item selecionado.

**Pós-condição:**

- Nenhum inventário deve ser alterado.

## UC07 — Adicionar item do Arsenal ao inventário

**Ator:** Usuário.

**Pré-condições:**

- O Arsenal deve estar disponível.
- O inventário individual deve existir.
- O item padrão deve estar cadastrado no Arsenal.

**Fluxo principal:**

1. O usuário seleciona um item do Arsenal.
2. O usuário informa a quantidade desejada.
3. O sistema valida a quantidade.
4. O sistema calcula o custo de categoria e o espaço.
5. O sistema verifica os limites do inventário.
6. O sistema adiciona o item ao inventário.
7. O sistema apresenta o inventário atualizado.

**Fluxos alternativos:**

- Se a quantidade for inválida, a operação é rejeitada.
- Se o limite de categoria for ultrapassado, a operação é rejeitada.
- Se o limite de espaço for ultrapassado, a operação é rejeitada.

**Pós-condição:**

- O item deve estar cadastrado no inventário.
- O item padrão do Arsenal deve permanecer inalterado.

---

# 8. Critérios de aceitação do módulo de inventário

| ID | Critério de aceitação |
|---|---|
| CA01 | O usuário deve conseguir consultar o inventário previamente estabelecido. |
| CA02 | O sistema não deve exigir que o usuário crie um inventário. |
| CA03 | Deve ser possível adicionar um item que respeite os limites do inventário. |
| CA04 | O sistema deve rejeitar o cadastro de um item com quantidade inválida. |
| CA05 | O sistema deve rejeitar o cadastro de um item que ultrapasse o limite de categoria. |
| CA06 | O sistema deve rejeitar o cadastro de um item que ultrapasse o limite de espaço. |
| CA07 | Os pontos de categoria utilizados devem corresponder à soma dos pontos dos itens. |
| CA08 | O espaço utilizado deve corresponder à soma do espaço dos itens. |
| CA09 | Deve ser possível alterar um item sem contabilizar seu custo anterior como novo consumo. |
| CA10 | O sistema deve rejeitar uma alteração que ultrapasse qualquer limite. |
| CA11 | Deve ser possível remover um item e liberar seus pontos e espaço. |
| CA12 | Uma operação rejeitada não deve modificar o estado anterior do inventário. |
| CA13 | Deve ser possível consultar o inventário e seus valores calculados. |
| CA14 | Os dados do inventário devem permanecer disponíveis após o encerramento e a reabertura da aplicação. |
| CA15 | Deve ser possível alterar o limite de categoria mesmo quando o inventário ficar fora de limite. |
| CA16 | Deve ser possível alterar o limite de espaço mesmo quando o inventário ficar fora de limite. |
| CA17 | O sistema deve apresentar um aviso quando o inventário ultrapassar o limite de categoria. |
| CA18 | O sistema deve apresentar um aviso quando o inventário ultrapassar o limite de espaço. |
| CA19 | A alteração de um limite não deve remover automaticamente os itens existentes. |
| CA20 | A situação do inventário deve ser recalculada após alterações nos itens ou limites. |

---

# 9. Decisões pendentes

As decisões abaixo precisam ser definidas antes ou durante a implementação dos requisitos correspondentes.

| ID | Decisão pendente | Impacto |
|---|---|---|
| DP01 | Qual será o limite de categoria inicial de cada personagem? | Provisionamento dos inventários. |
| DP02 | Como os limites de categoria serão definidos quando os personagens forem implementados? | Integração entre inventário e personagem. |
| DP03 | Qual será a fórmula de cálculo do limite de categoria por atributos? | Evolução do domínio. |
| DP04 | O limite inicial de espaço será sempre 20 para todos os inventários individuais? | Configuração do inventário. |
| DP05 | Como será calculado o limite de espaço a partir dos atributos do personagem? | Evolução do domínio. |
| DP06 | O espaço de um item poderá ser fracionário? | Tipo e validação do espaço. |
| DP07 | Um inventário poderá possuir vários registros do mesmo item? | Organização dos itens e persistência. |
| DP08 | A alteração de um limite poderá ser realizada por todos os usuários ou apenas por usuários autorizados? | Permissões. |
| DP09 | Quais características poderão ser alteradas em um item personalizado? | Modelo de domínio. |
| DP10 | Como serão definidos os bônus e requisitos das modificações? | Regras de modificações. |
| DP11 | Quais modificações serão compatíveis com cada categoria de item? | Validação das modificações. |
| DP12 | Como será calculado o custo de categoria após aplicação de modificações? | Regras de categoria. |
| DP13 | Quais serão os limites de categoria e espaço dos inventários de veículos? | Inventários compartilhados. |
| DP14 | Como serão definidas as permissões de acesso aos inventários de veículos? | Segurança e compartilhamento. |
| DP15 | Qual será a estratégia de identificação dos inventários e itens? | Persistência e operações individuais. |
| DP16 | Qual será o mecanismo de controle de concorrência na persistência? | Integridade em operações simultâneas. |

As decisões pendentes não devem ser tratadas como regras confirmadas até que sejam definidas.

---

# 10. Referências

- [ISO/IEC/IEEE 29148:2018 — Systems and software engineering: Requirements engineering](https://www.iso.org/standard/72089.html)
- [IEEE 29148-2018 — Requirements Engineering](https://standards.ieee.org/ieee/29148/6937/)
