# Cobertura de testes

A suíte em `Cacs.Domain.Tests` exercita o modelo antigo de jogador com contagem de categorias. Esse modelo não é o do incremento atual.

Nenhum teste cobre as regras de [REQUISITOS.md](../REQUISITOS.md). O mapeamento anterior de RN01–RN10 não vale para este documento: a numeração e o conceito de categoria mudaram.

A verificação exigida por este incremento está em [REQUISITOS.md](../REQUISITOS.md): sete usuários já provisionados, um admin e seis jogadores, cada um com inventário já criado, sem função de criar ficha. A suíte ainda não cobre esse cenário.

Quando houver testes do inventário, a tabela deve citar o identificador da regra neste documento e o teste que a demonstra.
