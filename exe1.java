import java.util.Scanner;
public class exe1 {
    public static void main(String[] args) {
       Scanner leia = new Scanner(System.in);
        float soma, sub, mult, div, n1, n2;
        System.out.println("Digite o primeiro número: ");
        n1 = leia.nextFloat();
        System.out.println("Digite o segundo número: ");
        n2 = leia.nextFloat();

        soma = n1 + n2;
        sub = n1 - n2;
        mult = n1 * n2;
        div = n1 / n2;

        System.out.println("A soma é de "+ soma);
        System.out.println("A subtração é de "+ sub);
        System.out.println("A multiplicação é de "+ mult);
        System.out.println("A divisão é de "+ div);
        


    }
}