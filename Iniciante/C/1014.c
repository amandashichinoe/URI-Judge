#include <stdio.h>

int main(){
	double consMedio, Y;
	int X;
	
	scanf("%i", &X);
	scanf("%lf", &Y);
	
	consMedio = X/Y;
	
	printf("%.3lf km/l\n", consMedio);
	
	return 0;
}
