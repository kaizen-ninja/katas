## A* Problem

### Introduction

Very good problem explanation you can find following link

[Introduction to A* from Red Blob Games](http://www.redblobgames.com/pathfinding/a-star/introduction.html)

### The Problem With Dijkstra’s Algorithm

Dijkstra’s algorithm works great, but has the drawback of being naively implemented - it doesn’t use any special heuristics for choosing the most likely candidates first, and so the solution is only known after each and every possible location is tested.

![Dijkstra](https://github.com/nspectator/katas/raw/master/list/AStar/Dijkstras.gif)

### A-star pathfinding

A-star is a faster and more efficient version of Dijkstra’s algorithm. [Wikipedia defines A-star](http://en.wikipedia.org/wiki/A-star) as a "best-first, graph search algorithm that finds the least-cost path from a given initial node to one goal node".

Put another way, A-star traverses a node graph (a collection of points in space that are connected) and finds the path that costs the least (is the shortest) without having to visit every single node in the entire graph. In the case of a videgame, this “node graph” is the game world; the map our units move around in.

![AStar](https://github.com/nspectator/katas/raw/master/list/AStar/AStar.gif)

### Optimization

Hardcore goes here.

With a few more optimizations, we can do even more guesswork and therefore do even fewer calculations. By assigning weights to the nodes visited along the way, we can predict the direction we should try next.

Using some more agressive heuristics, we are able to predict what the most likely best direction to move is and try it first.

![Heuristics](https://github.com/nspectator/katas/raw/master/list/AStar/Heuristic.gif)

### Goal

Write hardcore optimized A* pathfinder.

* Implement S,N,W,E move directions path finder

* Add diagonal movements and weights

### Suggested test cases

Hardcore and submit your cases.

![Hardcore](https://github.com/nspectator/katas/raw/master/list/AStar/hardcore.gif)

### Real world examples

* [Pathos game](http://mcfunkypants.com/LD25/)