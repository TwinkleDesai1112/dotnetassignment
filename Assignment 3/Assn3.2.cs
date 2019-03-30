using System;
namespace ConstructorOverloading{
	
	public class studentOverloading{
		String name,branch;
		int enrollment;
		public studentOverloading(String name){
			this.name=name;
		}
		public studentOverloading(String name,int enrollment){
			this.name=name;
			this.enrollment=enrollment;
		}
		public studentOverloading(String name,int enrollment,String branch){
			this.name=name;
			this.enrollment=enrollment;
			this.branch=branch;
		}
		
		
		public void Display(){
			Console.WriteLine(this.name);
			Console.WriteLine(this.enrollment);
			Console.WriteLine(this.branch);
		}
		
		public static void Main(){
			studentOverloading sObj1 = new studentOverloading("ABC");
			studentOverloading sObj2 = new studentOverloading("ABC",1);
			studentOverloading sObj3 = new studentOverloading("ABC",1,"CE");
			sObj1.Display();
			sObj2.Display();
			sObj3.Display();
		}
	}
}