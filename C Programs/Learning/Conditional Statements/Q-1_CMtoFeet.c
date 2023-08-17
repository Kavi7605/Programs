#include <stdio.h>

void main()
{
    //1st
    float h, f;
    printf("Enter your Height in centimeter: ");
    scanf("%f", &h);
    float n=30.48;
    f=h/n;
    printf("Feet value: %.3f", f);
}
