#include <stdio.h>

void main()
{
  //8th to sort elements of array in ascending order.
    int arr1[100];
    int n, i, j, tmp;
    printf("Input the size of array : ");
    scanf("%d", &n);
    printf("Input %d elements in the array :\n",n);
    for(i=0;i<n;i++)
    {
        printf("element - %d : ",i);
        scanf("%d",&arr1[i]);
    }
    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[j] <arr1[i])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }
    printf("\nElements of array in sorted ascending order:\n");
    for(i=0; i<n; i++)
    {
        printf("%d  ", arr1[i]);
    }
    printf("\n\n");
}
