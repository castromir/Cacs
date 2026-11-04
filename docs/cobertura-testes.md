# Cobertura de testes — Requisitos CACS

Testes de unidade em `Cacs.Domain.Tests` cobrem as **regras de negócio** do domínio.

## Regras de negócio

| Regra | Teste(s) |
|-------|----------|
| RN01 — Limite individual de 16 pontos | `PlayerTests.Criar_RN01_RN03_*`, `MudarCategoria_RN06_*` |
| RN02 — Valores por categoria (I=1, II=2, III=3, IV=4) | `CategoriaTests.Pontos_RN02_*` |
| RN03 — Pontos utilizados = soma das categorias | `PlayerTests.MudarCategoria_RN03_*`, `GrupoResumoTests.Calcular_RN03_*` |
| RN04 — Disponíveis = limite − utilizados | `PlayerTests.PontosDisponiveis_RN04_*` |
| RN05 — Quantidade não pode ser negativa | `CategoriaTests.*_RN05_*`, `PlayerTests.MudarCategoria_RN05_*` |
| RN06 — Não ultrapassar 16 pontos | `PlayerTests.MudarCategoria_RN06_*` |
| RN07 — Limite do grupo = soma dos limites | `GrupoResumoTests.Calcular_RN07_*` |
| RN08 — Disponível do grupo = soma dos disponíveis | `GrupoResumoTests.Calcular_RN08_*` |
| RN09 — Alteração preserva limites | `PlayerTests.MudarCategoria_RN09_*`, `GrupoResumoTests.Calcular_RN09_*` |
| RN10 — Concorrência sem inconsistência | _Pendente — teste de integração no repositório_ |

## Requisitos funcionais (escopo dos testes atuais)

| Requisito | Cobertura |
|-----------|-----------|
| RF02 — Visualizar limite total individual | Via `16 - PontosDisponiveis` em `PontosDisponiveis_RN04_*` |
| RF03 — Visualizar pontos disponíveis | `PontosDisponiveis_RN04_*` |
| RF04 — Visualizar limite total do grupo | `GrupoResumoTests.Calcular_RN07_*` |
| RF05 — Visualizar disponível do grupo | `GrupoResumoTests.Calcular_RN08_*` |
| RF06 — Aumentar categoria | `PlayerTests.MudarCategoria_RF06_*` |
| RF07 — Reduzir categoria | `PlayerTests.MudarCategoria_RF07_*`, `CategoriaTests.AlterarQuantidade_RF07_*` |
| RF08 — Categorias I, II, III, IV | `PlayerTests.Criar_RF08_*` |
| RF09 — Atualizar limites após alteração | `GrupoResumoTests.Calcular_RN09_*` |
| RF01 — Login | _Pendente — camada Web/Auth_ |
| RF10 — Sync em tempo real | _Pendente — teste de integração SignalR_ |

## Executar

```powershell
dotnet test Cacs.Domain.Tests
```
