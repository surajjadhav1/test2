package school;

public class Undergrad extends Student{

	public Undergrad(){
		super();
	}

	public Undergrad(String Name, int Id,double grade, int age, String address){
		super(Name,Id,grade,age,address);
	}

	public boolean isPassed(double grade){
		super.setGrade(grade);
		double marks = super.getGrade();
		if(marks > 70.0)
			return true;
		return false;
	}
}
