# Trees

Arvore é uma estrutura de dados não linear, onde cada elemento pode ter vários filhos.

## Elementos básicos:

- Nó: Contém o dado armazenado e ponteiros para seus filhos
- Raiz: O primeiro nó da árvore
- Folha: Nós que não têm filhos
- Altura: Número máximo de níveis da árvore
- Nível: Número de nós do caminho da raiz até o nó

## Tipos de árvores

- Árvore Binária Comum: Cada nó pode ter até dois filhos, sem restrições específicas.
- Árvore Binária Completa: Todos os níveis estão preenchidos, exceto possivelmente o último, com os nós mais à esquerda possível.
- Árvore Binária Perfeita: Todos os níveis estão completamente preenchidos, e as folhas estão no mesmo nível.
- Árvore Binária de Busca (BST): Os valores à esquerda de um nó são menores, e os da direita são maiores, usada para busca eficiente.
- Heap Binário: Árvore binária completa que segue regras de prioridade (Heap Máximo ou Mínimo).
- Árvore Binária Balanceada: As subárvores têm alturas equilibradas (ex.: AVL ou Red-Black).

## Vantagens:

- Busca eficiente (O(log n) em árvores balanceadas)
- Boa organização de dados
- Fácil inserção e remoção

## Desvantagens:

- Pode ficar desbalanceada
- Uso maior de memória comparado a arrays
- Complexidade de implementação