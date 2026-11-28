
# Context Map

No incremento do inventário, personagem e ficha ainda não existem. A verificação usa sete usuários já provisionados (um admin e seis jogadores), cada um com um inventário já criado, sem função de criar ficha. O desenho abaixo é a fronteira quando catálogo e ficha estiverem no modelo.

```mermaid
flowchart LR
    subgraph C["Bounded Context: Catálogo"]
        direction TB
        CI["Catálogo de Itens"]
        CH["Catálogo de Habilidades"]
        CR["Catálogo de Rituais"]
    end

    subgraph F["Bounded Context: Ficha"]
        direction TB
        FI["Inventário"]
        FH["Habilidades"]
        FR["Rituais"]
    end

    CI -->|"EspecificacaoItemPublicada"| FI
    CH -->|"EspecificacaoHabilidadePublicada"| FH
    CR -->|"EspecificacaoRitualPublicada"| FR
```
