public class Main {
    public static void main(String[] args) {
       //Задание 1
        int number = 0;
        while (number < 10){
            System.out.print( ++number + " " );
        }
        System.out.println();
        for (; number > 0; number--){
            System.out.print(number + " ");
        }
        System.out.println();
         // Задание 2
        int friday = 5;
        for (int firstFriday = friday;firstFriday <= 31; firstFriday += 7){
            System.out.println("Сегодня пятница,  " + firstFriday + " число. Необходимо подготовить отчет.");
        }
        // Задание 3
        int currentYear = 2022;
        int start = currentYear - 200;
        int end = currentYear + 100;

        for (int i = start; i <= end;i++){
            if (i % 79 == 0){
                System.out.println(i);
            }
        }
        }
    }
