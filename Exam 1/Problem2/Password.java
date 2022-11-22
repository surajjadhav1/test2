import java.util.Random;

class Password{
	
	public static void main(String[] args){
		System.out.println(generator(8));
	}

	private static char[] generator(int length){
		String letters = "abcdefghijklmnopqrstuvwxyz";
		String numbers = "0123456789";
		String Combined = letters + numbers;
		Random random = new Random();
		char[] password = new char[length];

		password[0] = letters.charAt(random.nextInt(letters.length()));
		password[1] = numbers.charAt(random.nextInt(numbers.length()));

		for(int i=2 ; i<length ; i++){
			password[i] = Combined.charAt(random.nextInt(Combined.length()));
		}
		return password;
	}
}
