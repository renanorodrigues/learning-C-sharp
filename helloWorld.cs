using System;

namespace Call_Method {
	public class Apresentation {
		string name;

		public void apresentation(){
			Console.Write("\nEnter your name:\t");
			name = Console.ReadLine();

			Console.Write("\nHello," + name + "!");
		}

		public static void Main(string[] args){
			Apresentation hello = new Apresentation();
			hello.apresentation();
		}
	}
}