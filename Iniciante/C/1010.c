#include <stdio.h>

int main(){
	int cod1, cod2, num1, num2;
	double valUnit1, valUnit2, valorPagar;
	
	scanf("%i %i %lf", &cod1, &num1, &valUnit1);
	scanf("%i %i %lf", &cod2, &num2, &valUnit2);
	
	valorPagar = (num1 * valUnit1) + (num2 * valUnit2);
	
	printf("VALOR A PAGAR: R$ %.2lf\n", valorPagar);
	
	return 0;
}
