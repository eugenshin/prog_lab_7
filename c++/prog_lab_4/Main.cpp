#include <Windows.h>
#include <iostream>
#include "line.h"
#include "angle.h"
#include "triangle.h"
#include "circle.h"
#include "segments.h"

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	point point1, point2, point3;
	point1.init(1, 0);
	point2.init(0, 2);
	point3 = point1 + point2;
	printf("�������� �������� �����: ");
	point3.descrin();
	printf("���������� �����: ");
	point3.vivod();
	printf("\n���������� �����: ");
	point3++;
	point3.vivod();
	++point3;
	printf("\n���������� �����: ");
	point3.vivod();
	printf("\n�������� �����: ");
	point3.descrout();
	/*line line1;
	printf("\n������� ���������� ������ � ������ ����� �����: ");
	line1.vvod();
	line1.vivod();
	printf("\n������ ����� = %f", line1.length());
	angle angle1;
	printf("\n������� ���������� ������: �� ������ ������� ����, �������, �� ������ ������� ����: ");
	angle1.vvod();
	angle1.vivod();
	printf("\n�������� ���� = %f ��������.", angle1.value());
	triangle tri1;
	printf("\n������� ���������� ����� ������������: ");
	tri1.vvod();
	tri1.vivod();
	printf("\n������� ������������ = %f, �������� ������������ = %f", tri1.square(), tri1.per());
	circle circle1;
	printf("\n������� ���������� ����� ����� � ��� ������: ");
	circle1.vvod();
	circle1.vivod();
	printf("\n������� ����� = %f, �������� ����� = %f", circle1.square(), circle1.per());
	segments sm1;
	sm1.vvod();
	sm1.totalvivod();
	sm1.vivod(0);
	printf("����� 1 �������� = %f\n", sm1.length(0));
	sm1.vivod(1);
	printf("����� ������� �������� = %f\n", sm1.length(1));
	printf("����� ����� = %f", sm1.totallength());*/
	return 0;
}