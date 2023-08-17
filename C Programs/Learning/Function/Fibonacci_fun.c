//0 1 1 2 3 5 8

#include <stdio.h>

void main()
{
    int a=0, b=1, c=0, n, i;
    printf("Enter a value for n: ");
    scanf("%d", &n);

    printf("Fibonacci Series with %d elements\n", n);
    for(i=0;i<n;i++)
    {
      printf("%d ",fibbonacci(i));
    }

 /*   for(i=0;i<n;i++)
    {
        printf(" %d", b);
        c=a+b;
        a=b;
        b=c;
    }*/
}

int fibbonacci(int n) {
   if(n == 0) {
      return 0;
   } else if(n == 1) {
      return 1;
   } else {
      return (fibbonacci(n-1) + fibbonacci(n-2));
   }
}
