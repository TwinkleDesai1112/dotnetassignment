using System;
using System.Reflection;
namespace ReflectionExample
{
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

        public static void Main()
        {
            Type T = Type.GetType("ReflectionExample.studentOverloading");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }

            PropertyInfo[] properties =  T.GetProperties();

            Console.WriteLine("\nProperties");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType+" "+ property.Name);        
            }

            Console.WriteLine("\nConstructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
	}
}