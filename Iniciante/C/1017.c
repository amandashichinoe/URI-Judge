#include <stdio.h>
 
int main() {
 
	int tempoViagem, velMedia;
	double qtdeCombustivel;
	
	scanf("%i", &tempoViagem);
	scanf("%i", &velMedia);
	
	qtdeCombustivel = ((velMedia * tempoViagem)/12.0);
 
 	printf("%.3lf\n", qtdeCombustivel);
 
    return 0;
}
