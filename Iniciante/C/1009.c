#include <stdio.h>

int main(){
	char nome[20];
	double salFixo, totalVendas, TOTAL;
	
	scanf("%s", nome);
	scanf("%lf", &salFixo);
	scanf("%lf", &totalVendas);
	
	TOTAL = salFixo + totalVendas * 0.15;
	
	printf("TOTAL = R$ %.2lf\n", TOTAL);
	
	return 0;
}
