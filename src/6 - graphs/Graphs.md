# Graphs

São estruturas de dados que consistem em um conjunto de vértices (ou nós) e um conjunto de arestas que conectam pares de vértices. Eles são usados para modelar relações entre objetos. Existem dois tipos principais de grafos:

- Grafos não direcionados: As arestas não têm direção, ou seja, a relação entre os vértices é bidirecional.
- Grafos direcionados (ou dígrafos): As arestas têm direção, indicando uma relação unidirecional entre os vértices.

### Componentes de um Grafo:
- Vértices (Nodos): Representam os objetos ou entidades.
- Arestas: Representam as conexões ou relações entre os vértices.

### Representações de Grafos
- Matriz de Adjacência: Uma matriz 2D onde cada célula (i, j) indica a presença ou ausência de uma aresta entre os vértices i e j.
- Lista de Adjacência: Um array de listas onde cada índice representa um vértice e a lista associada contém os vértices adjacentes.

### Tipos de Grafos
- Grafo Ponderado: As arestas têm pesos associados, representando o custo ou a distância entre os vértices.
- Grafo Não Ponderado: As arestas não têm pesos.
- Grafo Conexo: Existe um caminho entre qualquer par de vértices.
- Grafo Desconexo: Não existe um caminho entre todos os pares de vértices.

### Algoritmos Comuns
- Busca em Largura (BFS): Explora os vértices em camadas, útil para encontrar o caminho mais curto em grafos não ponderados.
- Busca em Profundidade (DFS): Explora o mais fundo possível antes de retroceder, útil para detectar ciclos e componentes conectados.
- Dijkstra: Encontra o caminho mais curto em grafos ponderados.
- Kruskal e Prim: Encontram a árvore geradora mínima em grafos ponderados.