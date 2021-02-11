/* Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias. */
 #include <stdio.h>
 int main(){
 	int N, notas100, notas50, notas20, notas10, notas5, notas2, notas1;
 	do{
 		scanf("%d", &N);
	 }while(N<0 || N>1000000);
	 
 	
 	notas100 = N/100;
 	N-= (notas100*100);
 	
 	notas50 = N/50;
 	N-= (notas50*50);
 	
 	notas20 = N/20;
 	N-= (notas20*20);
 	
 	notas10 = N/10;
 	N-= (notas10*10);
 	
 	notas5 = N/5;
 	N-= (notas5*5);
 	
 	notas2 = N/2;
 	N-= (notas2*2);
 	
 	notas1 = N/1;
 	N-= (notas1*1);
	
 	
 	printf("%d nota(s) de R$ 100,00\n", notas100);
 	printf("%d nota(s) de R$ 500,00\n", notas50);
 	printf("%d nota(s) de R$ 20,00\n", notas20);
 	printf("%d nota(s) de R$ 10,00\n", notas10);
 	printf("%d nota(s) de R$ 5,00\n", notas5);
 	printf("%d nota(s) de R$ 2,00\n", notas2);
 	printf("%d nota(s) de R$ 1,00\n", notas1);
 	printf("\n");
 	

	 return 0;
 }
