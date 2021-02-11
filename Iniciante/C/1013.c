#include <stdio.h>

int main(){
	int a, b, c, maiorDe2, maiorDe3;
	
	scanf("%i %i %i", &a, &b, &c);
	
	maiorDe2 = ((a+b+abs(a-b))/2);
	maiorDe3 = ((maiorDe2 + c + abs(maiorDe2 - c))/2);
	 
	printf("%i eh o maior\n", maiorDe3);
	
	return 0; 
}
