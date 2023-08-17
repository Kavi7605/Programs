#include <stdio.h>

void main()
{
    int E, Sc, M, S, H, F=40, D=60, C=70, B=80, A=90;
    float per;
    printf("Enter marks of English: ");
    scanf("%d",&E);
    printf("Enter marks of Science: ");
    scanf("%d",&Sc);
    printf("Enter marks of Maths: ");
    scanf("%d",&M);
    printf("Enter marks of Social: ");
    scanf("%d",&S);
    printf("Enter marks of Hindi: ");
    scanf("%d",&H);

    per = (E + Sc + M + S + H) / 5.0;
    printf("\nPercentage = %.2f\n\n", per);


    if (per >= A)
    {
        printf("You got A Grade\n\n\n");
    }
    else if (per >= B)
    {
        printf("You got B Grade\n\n\n");
    }
    else if (per >= C)
    {
        printf("You got C Grade\n\n\n");
    }
    else if (per >= D)
    {
        printf("You got D Grade\n\n\n");
    }
    else if (per >= E)
    {
        printf("You got E Grade\n\n\n");
    }
    else
    {
        printf("You got F Grade\n\n\n");
    }

/*
    SofS=E+Sc+M+S+H;
    printf("\n%d+%d+%d+%d+%d=%d\n",E, Sc, M, S, H, SofS);
    per=SofS/TS;
    printf("%d/%d=%d",SofS , TS, per);
    printf("\nAverage=%d\n\n", per);
*/

}
