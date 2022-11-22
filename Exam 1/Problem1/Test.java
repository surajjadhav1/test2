import school.*;

class Test{
	/*
	private static Compute(Student S){
		if(S instanceof Undergrad U){
			Undergrad Ugd = (Undergrad) S;
			Ugd
		}
		if(S instanceof Grad G){
			Grad Gd = (Grad) S;
		}
	}
	*/

	public static void main(String[] args){
		var Ugd = new Undergrad("Virat",102,75,19,"Pune");
		if(Ugd.isPassed(75))	
			System.out.println("The student has passed the Undergrad");
		else		
			System.out.println("The student has failed the Undergrad");

		var Gd = new Grad("Virat",102,75,19,"Pune");
		if(Gd.isPassed(75))	
			System.out.println("The student has passed the Grad");
		else		
			System.out.println("The student has failed the Grad");
	}
}

