#include <stdio.h>

void main()
{
  //7th palindrome
    char str1[10], str2[10];
    int i, size=0;
    printf("Enter a String: ");
    scanf("%s", str1);

    while(str1[size] != '\0')
    {
        size++;
    }

    for(i=size-1;i>=0;i--)
    {
        str2[i] = str1[(size-1)-i];
    }
    str2[size]='\0';
    printf("rev: %s\n", str2);

    for(i=0;str1[i]==str2[i];i++){ }

    if(i==size+1)
    {
        printf("input string '%s' is palindrome.", str1);
    }
    else
    {
        printf("input string '%s' is not palindrome.", str1);
    }
}
