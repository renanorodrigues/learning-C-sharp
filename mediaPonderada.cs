using System;

namespace Student_Grade {
	public class Media {
		double grade1, grade2, media;
		string studentName;
		
		public void mediaGrade(){
			Console.Write("\nEnter your note 1:\t");
			grade1 = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("\nEnter your note 2:\t");
			grade2 = Convert.ToDouble(Console.ReadLine());
			
			media = ((grade1 * 3) + (grade2 * 7)) / 10;
			
			Console.Write("\n\n====================");
			Console.Write("\nMEDIA = {0}", media.ToString("0.00000"));
			Console.Write("\n\n====================");
		}
		
		public static void Main(string[] args){
			Media m = new Media();
			m.mediaGrade();
		}
	}
}