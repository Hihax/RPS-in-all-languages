// Important: This program is not tested yet, however it should work!
public class Main {
	
	private static String user;
	private static String bot;
	
	public static void main(String[] args) {
		System.out.println("Rock, Paper, Scissors!");
		Scanner scan = new Scanner(System.in);
		user = scan.nextLine();
		System.out.println("User -> " + user);
		verify();
	}
	
	public static String bot() {
		Random rnd = new Random();
		String[] str = new String[] {
			"Rock",
			"Paper",
			"Scissors"
		};
		return str[rnd.nextInt(str.length)];
	}
	
	public static void verify() {
		bot = bot();
		
		System.out.println("Bot -> " + bot);
		System.out.println();
		
		if (bot == user)
			System.out.println("Equality !");
		else if (bot == "Rock" && user == "Paper")
			System.out.println("You win ! :)");
		else if (bot == "Rock" && user == "Scissors")
			System.out.println("You lost ! :(");
		else if (bot == "Paper" && user == "Rock")
			System.out.println("You lost ! :(");
		else if (bot == "Paper" && user == "Scissors")
			System.out.println("You win ! :)");
		else if (bot == "Scissors" && user == "Rock")
			System.out.println("You win ! :)");
		else if (bot == "Scissors" && user == "Paper")
			System.out.println("You lost ! :(");
	}
	
}