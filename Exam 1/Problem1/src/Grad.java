package school;

public class Grad extends Student{

	public Grad(){
		super();
	}

	public Grad(String Name, int Id,double grade, int age, String address){
		super(Name,Id,grade,age,address);
	}

	public boolean isPassed(double grade){
		super.setGrade(grade);
		double marks = super.getGrade();
		if(marks > 80.0)
			return true;
		return false;
	}
}
