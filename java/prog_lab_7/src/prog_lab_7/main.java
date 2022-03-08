package prog_lab_7;

public class main {
	public static void main(String args[]) {
		point[] ptmas = new point[2];//массив объектов
		for(int i = 0; i < 2; i++) {
			ptmas[i] = new point();
		}
		ptmas[0].init(1, 2);
		System.out.printf("Input description\n");
		ptmas[0].descrin();//обработка строк
		ptmas[0].vivod();
		ptmas[0].descrout();
		int a = ptmas[0].sum();//возврат целого числа из метода
		System.out.printf("Sum x, y of point = (%d)\n", a);	
   }
}