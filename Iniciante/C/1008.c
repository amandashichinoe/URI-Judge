#include <stdio.h>
 
 int main(){
 	
 	int NUMBER, qtdeHoras;
 	double salHora, SALARY;
 	
 	scanf("%i", &NUMBER);
 	scanf("%i", &qtdeHoras);
 	scanf("%lf", &salHora);
 	
 	SALARY = (qtdeHoras * salHora);
 	
 	printf("NUMBER = %i\nSALARY = U$ %.2lf\n", NUMBER, SALARY);
 	
 	return 0;
 	
 }
