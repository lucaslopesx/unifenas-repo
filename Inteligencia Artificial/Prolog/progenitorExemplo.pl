masculino(joao).
masculino(jose).
masculino(jorge).

feminino(maria).
feminino(ana).
feminino(iris).
feminino(julia).

progenitor(maria,jose).
progenitor(joao,jose).
progenitor(joao,ana).
progenitor(jose,julia).
progenitor(jose,iris).
progenitor(iris,jorge).


pai(Y, Filho):-progenitor(Y, Filho),masculino(Y).
mae(Y, Filho):-progenitor(Y, Filho),feminino(Y).
