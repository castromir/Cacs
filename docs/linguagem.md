# Linguagem e contextos

Vocabulário do CACS e fronteira entre os modelos. Este arquivo não é especificação de requisito. Os requisitos do incremento atual estão em [REQUISITOS.md](../REQUISITOS.md). A ordem das features está em [roadmap.md](roadmap.md).

## Termos

| Termo | Significado |
|---|---|
| Usuário | Pessoa que entra no sistema. Tem um papel: jogador ou admin. |
| Jogador | Pessoa da mesa. Pode ter mais de um personagem. |
| Admin | Papel que publica no catálogo. |
| Personagem | Dono da ficha, quando a ficha existir. Não é modelo deste incremento. |
| Ficha | O que o personagem é no jogo. Cresce por agregados. A tela completa é uma consulta sobre esses agregados. Não é modelo deste incremento. |
| Inventário | Itens, limites e totais calculados. Neste incremento, de um usuário já provisionado. Quando houver personagem, do personagem. |
| Item de inventário | Entrada do inventário. O usuário altera e remove esta entrada no próprio inventário. |
| Especificação do item | Nome, descrição, espaço, categoria e detalhe do tipo. É o que se informa ao incluir ou alterar. |
| Estado no inventário | O que só existe com o item no inventário: a identidade do item e, na munição, a quantidade já utilizada. |
| Categoria | Nível de custo do item, de sem categoria a V. |
| Catálogo | O que o admin publica para o jogador consultar e copiar. O jogador não altera o publicado. |
| Arsenal | Parte de itens do catálogo. Habilidades e opções de classe, quando existirem, ficam no catálogo e fora do Arsenal. |
| Item de catálogo | Especificação publicada. A cópia vira um item de inventário novo. |

Usuário, jogador e personagem não são o mesmo conceito e não compartilham o mesmo objeto.

## Contextos

| Contexto | Quem escreve | O que o modelo garante |
|---|---|---|
| Ficha | Jogador, no próprio personagem | O que o personagem possui e pode alterar |
| Catálogo | Admin | O que está publicado para cópia |
| Acesso | Sistema | Quem entrou e qual papel tem |

O incremento atual tem o agregado Inventário. Catálogo ainda não é modelo. Personagem e ficha ainda não são modelo, e não há função de criar ficha.

Acesso, neste incremento, limita-se a sete usuários já provisionados: um com papel admin e seis com papel jogador. Não há cadastro de usuário. Cada um desses usuários possui um inventário já criado. O usuário não o cria nem o exclui. O papel não muda o inventário: admin e jogador usam as mesmas regras de item, limite e total. O admin não publica no catálogo neste incremento.

Enquanto não houver personagem, o inventário permanece associado ao usuário que o recebeu. Usuário, jogador e personagem continuam conceitos distintos. Quando a ficha existir, o inventário passa a ser do personagem, sem mudar o cálculo de limites e totais.

O catálogo é a origem da especificação publicada. A ficha fica com a cópia. Alterar a cópia não altera o publicado. Alterar o publicado não reescreve fichas já preenchidas.

A autorização fica no caso de uso. O caso de uso opera o inventário do usuário que atua. O inventário não consulta papel de usuário. O catálogo não consulta inventário.

## O que permanece quando a ficha crescer

- Inventário continua um agregado. Quando o personagem existir, passa a estar associado a ele. O cálculo de limites e totais permanece o mesmo.
- Habilidades, atributos, perícias, vida e sanidade entram como outros agregados da ficha.
- Cada espécie publicada no catálogo (item, depois habilidade) é um agregado do catálogo. A consulta geral lista esses agregados.
- Incluir no inventário recebe a especificação do item. Item digitado pelo jogador e item copiado do catálogo passam pelo mesmo comportamento de limites e totais.
- A cópia pode guardar a identidade de origem no catálogo, sem ligação que faça um lado alterar o outro.
- A quantidade de munição já utilizada fica no estado do item no inventário. Ela não faz parte da especificação publicada.

Os vocabulários fechados do item (categoria, tipos, alcance, dano e os demais) estão nos requisitos do inventário.
