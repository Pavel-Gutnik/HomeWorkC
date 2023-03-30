// Console.Write("Введите строку: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// int[,] arr = new int[4, 5];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//     arr[i, j] = random.Next(10, 90);
//     Console.Write("{0} ", arr[i, j]);
//   }
//   Console.WriteLine();
// }
// if (n >= arr.GetLength(0) || m >= arr.GetLength(1))
// {
//   Console.WriteLine("Элемент не существует ");
// }
// else
// {
//   Console.WriteLine("Значение элемента массива: {0}", arr[n-1, m-1]);//arr[n-1, m-1] для обывателя 
// }

Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[4, 5];

for (int i = 0; i < matrix.GetLength(0); i++) {
  for (int j = 0; j < matrix.GetLength(1); j++) {
    matrix[i, j] = random.Next(10, 90);
    Console.Write("{0} ", matrix[i, j]);
  }
  Console.WriteLine();
}
if (row > matrix.GetLength(0) || column > matrix.GetLength(1)) {
  Console.WriteLine("Элемент не существует ");
}
else {                                
  Console.WriteLine("Значение элемента массива: {0}", matrix[row-1, column-1]); 
}
