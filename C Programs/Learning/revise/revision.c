#include <stdio.h>

void main()
{

    float a, b, c, d, e, f;
    printf("Welcome to my revision.\n\n");

    //printf scanf example
    printf("1st: printf,scanf,float: \n\n");

    printf("Enter a value for A: ");
    scanf("%f", &a);
    printf("Enter a value for B: ");
    scanf("%f", &b);
    printf("Enter a value for C: ");
    scanf("%f", &c);
    printf("Enter a value for D: ");
    scanf("%f", &d);
    printf("Enter a value for E: ");
    scanf("%f", &e);
    f=a/b*c+d-e;
    printf("%0.1f/%0.1f*%0.1f+%0.1f-%0.1f=%f", a, b, c, d, e, f);

    //ifelse
    printf("\n\nIF-ELSE: \n");

    int k, l;
    printf("Enter a value for K: ");
    scanf("%d", &k);
    printf("Enter a value for L: ");
    scanf("%d", &l);
    if (k<l)
        printf("L is max\n\n");
    else if(k>l)
        printf("K is max\n\n");
    else
         printf("K=L\n");

    //char
    printf("Char:\n");

    char g = 65, h = 'B';
    printf("%c : %d\n\n",g+h, g+h);

    //For While
    printf("For-While:\n");
    int i;
    for(i=10; i>0; i--)
    {
        printf("%d\n", i);
    }
    printf("\n");
    i=0;
    while(1)
    {
        printf("%d\n", i);
        i++;
        if(i==10) break;
    }


    printf("\n\n\n");
}
