# LSP — Liskov Substitution Principle
No princípio da Substituição de Liskov (LSP) diz que “Os subtipos devem ser substituíveis pelos seus tipos base”, e que as classes/tipos base podem ser substituídas por qualquer uma das suas subclasses, ponderando sobre os cuidados para usar a herança no seu projeto de software. Mesmo a herança sendo um mecanismo poderoso, ela deve ser utilizada de forma contextualizada e moderada, evitando os casos de classes serem estendidas apenas por possuírem algo em comum. Esse princípio foi descrito pela pesquisadora Barbara Liskov, em seu artigo de 1988, em que ela explica que, antes de optar pela herança, precisamos pensar nas pré-condições e pós-condições da sua classe.

## Implementando LSP
Após observar as classes, verificará que a herança agora faz sentido, pois ambos classes Quadrado e Retângulo são do tipo Paralelograma.
E como herdam de Paralelograma, podem serem tratado do mesmo tipo no exemplo do método "ObObterAreaParalelogramo(Paralelograma obj)"

Aliás, é importante saber o que é um paralelogramo, é um polígono de quatro lados cujos lados opostos são paralelos. Por consequência, tem ângulos opostos e lados opostos congruentes.

