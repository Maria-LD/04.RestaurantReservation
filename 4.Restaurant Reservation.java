import java.util.Scanner;

public class RestaurantReservation {
    public static void main(String args[]) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter number of people in the group: ");
            int groupSize = Integer.parseInt(scanner.nextLine());   //contains number of people in the group
            System.out.print("Enter the chosen package - \"Normal\", \"Gold\" or \"Platinum\": ");
            String pack = scanner.nextLine().toLowerCase();

            String hall = "";       //appropriate hall
            int price = 0;          //price of the appropriate hall

            //gives appropriate hall acoording to number of people
            if (groupSize <= 50) {
                hall = "Small Hall";
                price = 2500;

            } else if (groupSize > 50 && groupSize <= 100) {
                hall = "Terrace";
                price = 5000;

            } else if (groupSize > 100 && groupSize <= 120) {
                hall = "Great Hall";
                price = 7500;
            }

            //calculate discount
            double discount = 0;
            switch (pack) {
                case "normal":
                    price += 500;
                    discount = 0.05 * price;
                    break;

                case "gold":
                    price += 750;
                    discount = 0.1 * price;
                    break;

                case "platinum":
                    price += 1000;
                    discount = 0.15 * price;
                    break;

		default:
                    System.out.println("Your entry for the package is inappropriate! Please, start from the beginning!");
                    return;
            }

            double priceWithDiscount = price - discount;
            double pricePerPerson = priceWithDiscount / groupSize;

            if (groupSize > 120) {
                System.out.println("We do not have an appropriate hall.");
            } else {
                System.out.printf("We can offer you the \"%s.\"\nThe price per person is $%.2f.",
                        hall, pricePerPerson);
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Start filling the form from the beginning, please!");
        }
    }
}