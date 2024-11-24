# Stacks

É uma estrutura de dados linear do tipo LIFO (Last In First Out), onde o último elemento a entrar será o primeiro a sair. Para acessar um elemento, é necessário remover todos os elementos que estão acima dele.

A implementação de pilhas pode ser realizada através de vetor (alocação do espaço de memória para os elementos é contígua) ou através de listas encadeadas.

## Exemplos de Uso
- Funçoes recursivas em compiladores
- Mecanismo de desfazer/refazer em editores de texto
- Navegação entre páginas em um navegador

## Operações
- Push: Adiciona um elemento ao topo da pilha
- Pop: Remove o elemento do topo da pilha
- Peek: Retorna o elemento do topo da pilha sem remover
- isEmpty: Verifica se a pilha está vazia
- Count: Retorna o número de elementos na pilha
