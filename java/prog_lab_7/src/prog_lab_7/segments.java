package prog_lab_7;
import java.util.Scanner;

public class segments {
    final int MAX = 100;
    int n;
    line[] ptrline = new line[MAX];
	
	public void vvod() {
		Scanner in = new Scanner(System.in);
		do{
			n = in.nextInt();
		}
		while((n < 1)||(n > MAX));
        for(int i = 0; i < n; i++)
        {
            ptrline[i] = new line();
            ptrline[i].vvod();
        }
	}
	
	public void vivod() {
        for(int i = 0; i < n; i++)
        {
                ptrline[i].vivod();
        }
	}
	
    public double totallength()
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += ptrline[i].length();
        }
         return sum;
    }
}