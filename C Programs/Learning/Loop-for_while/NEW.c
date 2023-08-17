#include <stdio.h>

int main()
{
   int i, j, rows;
   printf("Enter the number of rows: ");
   scanf("%d", &rows);
   for (i = 1; i <= rows; ++i)
    {
      for (j = 1; j <= i; ++j)
      {
         printf("* ");
      }
      printf("\n");
   }
   printf("Enter the number of rows: ");
   scanf("%d", &rows);
   for (i = 1; i <= rows; ++i)
    {
      for (j = 1; j <= i; ++j)
      {
         printf("%d ", j);
      }
      printf("\n");
    }

    int k, l;
    char input, alphabet = 'A';
    printf("enter smthin: ");
    scanf("%c", &input);
        for (k = 1; k <= (input - 'A' + 1); ++k)
        {
            for (l = 1; l <= k; ++l)
                {
                    printf("%c ", alphabet);
                    ++alphabet;
                }
            printf("\n\n\n");
        }
}
