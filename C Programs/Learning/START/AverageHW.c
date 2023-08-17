#include <stdio.h>

int main()
{
    int phy, chem, bio, math, comp;
    float per;

    /* Input marks of five subjects from user */
    printf("Enter marks of English: ");
    scanf("%d",&phy);
    printf("Enter marks of Science: ");
    scanf("%d",&chem);
    printf("Enter marks of Maths: ");
    scanf("%d",&bio);
    printf("Enter marks of Social: ");
    scanf("%d",&math);
    printf("Enter marks of Hindi: ");
    scanf("%d",&comp);


    /* Calculate percentage */
    per = (phy + chem + bio + math + comp) / 5.0;

    printf("Percentage = %.2f\n", per);


    /* Find grade according to the percentage */
    if(per >= 90)
    {
        printf("Grade A");
    }
    else if(per >= 80)
    {
        printf("Grade B");
    }
    else if(per >= 70)
    {
        printf("Grade C");
    }
    else if(per >= 60)
    {
        printf("Grade D");
    }
    else if(per >= 40)
    {
        printf("Grade E");
    }
    else
    {
        printf("Grade F");

    }
}
