#define _CRT_SECURY_NO_WARNINGS
#include <stdio.h>
#include <string.h>
int main(void)
{
char texto[50];
int tamanho;
// A vari�vel texto recebe a cadeia de
// caracteres: LINGUAGEM DE PROGRAMA��O
// A fun��o strcpy copia a cadeia de caracteres
// LINGUAGEM DE PROGRAMA��O para a vari�vel texto
strcpy(texto, "LINGUAGEM DE PROGRAMA��O");
// A vari�vel tamanho recebe o n�mero de caracteres da cadeia
// armazenada na vari�vel texto
tamanho = strlen(texto);
//Mostra o conte�do da vari�vel tamanho
printf("\nTAMANHO DA CADEIA DE CARACTERES = %d", tamanho);
getchar();
return 0;
}

