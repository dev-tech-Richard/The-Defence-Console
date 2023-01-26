Console.WriteLine("please choose a target row and column.");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("row " + row);
Console.WriteLine("column " + column);

int top = row;
int top2 = column - 1;

int left = row - 1;
int left2 = column;

int right = row;
int right2 = column + 1;

int bottom = row + 1;
int bottom2 = column;

Console.WriteLine(top+ " " + top2);
Console.WriteLine(left+ " " + left2);
Console.WriteLine(right+ " " + right2);
Console.WriteLine(bottom+ " " + bottom2);
