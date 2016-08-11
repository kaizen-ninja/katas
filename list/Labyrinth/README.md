## Labyrinth Kata

### Problem Description

The goal is to write a function that returns a bool value indicating whether it is possible to find the exit or
not. If it was possible to find the exit, print the path followed.

Given labyrinth is a multidimensional char array contains `s` in some cell indicating start point and `e` in some cell indicating the destination point.
Border is a cell marked as `*` and there is no way to go through it directly.

### Suggested Test Cases

    *  *  *  *  *  *
    _  *  _  _  _  *
    *  s  _  *  _  *
    *  *  *  *  _  *
    _  _  e  _  _  *
    _  *  *  *  _  *

Output

    Path found: S R U R R D D D L L