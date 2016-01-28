# Proyecto Interfaces Inteligentes (Laberinto contra IA)
Integrantes:
  - Adrián Mesa Jaubert
  - Juan Tareq González de Chávez Pérez
 
El juego consiste en intentar resolver el laberinto antes de que la IA te alcance.

El jugador, para no hacer el juego imposible tiene una velocidad progresiva creciente.

Elementos utilizados:
- Utilizamos bloques, que por defectos la IA los consideraba walkable, lo cual ocasionaba problemas con la IA para encontrar al jugador. Para solucionar el problema, les dimos la categoría de no walkable y utilizamos el bake para generar el mapa "útil" para que la IA se pudiera mover por el laberinto y perseguir al jugador.
- Para la IA utilizamos el modelo de IA de unity y para que este persiguiese utilizamos el algoritmo de pathfinding de esta misma en unity.
- El juego consta de 3 escenas, la escena del laberinto(la principal) en esta el jugador se mueve a traves del laberinto intentando llegar al final. Si consigue llegar al final del juego saltará la escena segunda(la escena de juego concluido con éxito)  y si no consigues llegar porque la IA te alcanza salta la tercera escena, la escena de game over. Todo eso está realizado dentro de los scripts.
