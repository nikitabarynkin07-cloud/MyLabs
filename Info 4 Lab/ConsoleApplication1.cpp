#include <stdio.h>
#include <stdlib.h>


//рекурсивная функция для 1 задания
int f(int n)
{
	if (n < 2)
	{
		return 1;
	}
	else if (n >= 2 && n % 3 == 0)
	{
		return f(n / 3) - 1;
	}
	else if (n >= 2 && n % 3 != 0)
	{
		return f(n - 1) + 17;
	}
	return 0;
}


//поиск максимального нечетного элемента числа
int max_digit_in_n(int x)
{
	if (x < 0)
	{
		x = -x;
	}
	int max_digit = -1;
	while (x > 0)
	{
		int result = x % 10;
		if (result % 2 != 0)
		{
			if (result > max_digit || max_digit == -1)
			{
				max_digit = result;
			}
		}
		x /= 10;
	}
	return max_digit;
}

//сумма ряда
double calculate(double x, int n)
{
	printf_s("a_n = 1; a_0 = -x: a=n+1 = a_n*(-x)/((2n+1)*2n)\n");
	double a = -x;
	double sum = a;
	for (int i = 1; i < n;i++)
	{
		a *= (-1) * (x) / ((2 * i + 1) * 2 * i);
		sum += a;
	}
	return sum;
}
void main()
{
	int choice;
	printf_s("Select the issue item:\n");
	printf_s("1. Minimum value n\n");
	printf_s("2. The maximum odd digit for a given number x\n");
	printf_s("3. The sum of the series S(x)\n");
	scanf_s("%d", &choice);


	if (choice == 1)
	{
		int min_n = -1;
		int founder = 0;
		for (int n = 10000; n <= 100000;n++)
		{
			int result = f(n);
			if (result == 110)
			{
				min_n = n;
				founder = 1;
				break;
			}
		}

		if (founder)
		{
			printf_s("The minimum value of n for which f(n) = 110 : %d\n", min_n);
		}
		else
		{
			printf_s("No minimum value found for 10000\n");
		}
	}


	else if (choice == 2)
	{
		printf_s("Enter a number x\n");
		int x;
		scanf_s("%d", &x);
		if (x < 0)
		{

			printf_s("Error! x must be a natural number\n");
		}
		int res = f(x);
		int max_digit = max_digit_in_n(res);

		printf_s("F(%d) = %d\n", x, res);
		if (max_digit == -1)
		{
			printf_s("No odd numbers found\n");
		}
		else
		{
			printf_s("The maximum odd number for F(%d) = %d\n", res, max_digit);
		}
	}


	else if (choice == 3)
	{
		double X;
		int N;

		printf_s("Enter X: \n");
		scanf_s("%lf", &X);

		printf_s("Enter N: \n");
		scanf_s("%d", &N);

		if (N < 0)
			printf_s("N must be >= 1\n");

		double result = calculate(X, N);
		printf("The sum of the series S(x) = %lf\n", result);
	}


	else
	{
		printf_s("There is no such point\n");
	}


}