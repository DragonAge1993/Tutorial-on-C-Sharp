using System;
namespace Chislo_Fibonachi
{
	class MainClass
	{
		//Начало метода Un 
		public static int Un (uint n) {
			double b = (1 + Math.Sqrt (5)) / 2;
			double un = (Math.Pow (b, n) - Math.Pow (-b, -n)) / (2 * b - 1);
			return (int)(un + 0.5);
		}//Завершение метода
		public static void Main (string[] args)
		{
			uint n; //Номер члена ряда
			int res; //Целочисленное значение члена
			string line;//Строка для приема данных
			do {
				Console.WriteLine ("Введите номер члена ряда: ");
				line = Console.ReadLine ();
			} while (!uint.TryParse (line, out n));
			res = Un (n);//вызов метода
			Console.WriteLine ("Последовательность числа Фибоначи: " + res);
			Console.WriteLine ("Для выхода из программы нажмите ENTER!");
			Console.ReadLine ();
		}
	}
}
