#define _CRT_SECURY_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <string.h>
int main(void)
{
	// Este exemplo troca todas as vogais da cadeia
	// TEXTO1 pelo caractere ?
	// A vari�vel TEXTO1 recebe a cadeia de caracteres:
	// PROGRAMA DE COMPUTADOR
	char TEXTO1[] = "PROGRAMA DE COMPUTADOR";
	int TAMANHO, I;
	// A fun��o strlen retorna o tamanho da cadeia TEXTO1
	TAMANHO = strlen(TEXTO1);
	// A estrutura de repeti��o abaixo passa por todos os
	// caracteres da cadeia TEXTO1
	// Cada caractere vogal � substitu�do pelo caractere ?
	for (I = 0; I<TAMANHO; I++)
	{
	if (TEXTO1[I] == 'A' || TEXTO1[I] == 'E'
	|| TEXTO1[I] == 'I' || TEXTO1[I] == 'O'
	|| TEXTO1[I] == 'U')
	TEXTO1[I] = '?';
	}
	// Mostra o conte�do da vari�vel TEXTO1
	printf("\nNova cadeia TEXTO1 = %s\n", TEXTO1);
	system("pause");
}

