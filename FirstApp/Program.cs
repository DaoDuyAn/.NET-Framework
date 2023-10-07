// using FirstApp.oop;

/*
var p1 = new Point();
Console.WriteLine(p1.ToString());

var p2 = new Point
{
    x= 10, 
    y= 20
};
Console.WriteLine(p2.ToString());

var p3 = new Point
{
    x = 20,
    y = 50
};
Console.WriteLine(p3.ToString());

var d23 = p2.Distance(p3);
Console.WriteLine("KC P23: " + d23.ToString());

var d32 = p3.Distance(p2);
Console.WriteLine("KC P32: " + d32.ToString());

var dStatic23 = Point.Distance(p2, p3);
Console.WriteLine("KC Static P23: " + dStatic23.ToString());


if (p2.Equals(p3))
    Console.WriteLine("Hai diem trung nhau");
else
    Console.WriteLine("Hai diem khac biet nhau"); */


/*List<IShape> list = new List<IShape>();
list.Add(new Circle { Radius = 10 });
list.Add(new Rectangle{ Height = 10, Width = 20 });

foreach (IShape s in list)
{
    Console.WriteLine("Dien tich: " + s.Area());
    Console.WriteLine("Chu vi: " + s.Perimeter());
    Console.WriteLine("--------------");
}*/

using FirstApp.oop;
using System.Xml.Linq;


string[] names = new string[]
{
    "An", "Hieu", "Viet", "Thuong", "Hunglo", "School", "Tun", "Le", "Longa"
};

// Danh sách tên có 4 ký tự trở lên
// Truyền thống
List<string> lst4 = new List<string>();
for(int i = 0; i < names.Length; i++)
{
    if (names[i].Length > 4)
    {
        lst4.Add(names[i]);
    }
}

foreach (string name in lst4)
{
    Console.WriteLine(name);
}

Console.WriteLine("---------");

// LINQ

// 1. Danh sách tên có 4 ký tự trở lên
lst4 = names.Where(t => t.Length >= 4).ToList();
lst4.ForEach(x => Console.WriteLine(x));

Console.WriteLine("---------");

// 2. Danh sách có tên bắt đầu bằng "L"
lst4 = names.Where(t => t.StartsWith("L")).ToList();
lst4.ForEach(x => Console.WriteLine(x));

Console.WriteLine("---------");

// 3. Danh sách tên có 4 ký tự trở lên và bắt đầu bằng "L"
names
    .Where(t => t.Length >= 4 && t.StartsWith("L"))
    .ToList()
    .ForEach(x => Console.WriteLine(x));

Console.WriteLine("---------");
// -----

#region Khởi tạo dữ liệu
List<int> numbers = new List<int>();
Random rand = new Random();

for(int i = 0; i < 10; ++i)
{
    numbers.Add(rand.Next(20)); // 0-19
}

numbers.ForEach(x => Console.Write(x + " "));
#endregion

#region Thống kê max, min, average, sum, count của numbers
Console.WriteLine($"\nMax: {numbers.Max()}, Min: {numbers.Min()}, Ave: {numbers.Average()}, Sum: {numbers.Sum()}, Count: {numbers.Count()}");
#endregion


#region Thống kê max, min, average, sum, count của số chẳn
Console.WriteLine($"\nMax: {numbers.Where(n => n % 2 == 0).Max()}, Min: {numbers.Where(n => n % 2 == 0).Min()}, Ave: {numbers.Where(n => n % 2 == 0).Average()}, Sum: {numbers.Where(n => n % 2 == 0).Sum()}, Count: {numbers.Where(n => n % 2 == 0).Count()}");
#endregion




#region Tạo danh sách SinhVien. Thống kê có bao nhiêu Nam, Nữ
var lstStudent = Student.GetStudents();
var lstMale = lstStudent.Where(e => e.Gender == Student.EGENDER.Male).ToList();
lstMale.ForEach(x => Console.WriteLine(x));

Console.WriteLine("---------");

var lstFemale = lstStudent.Where(e => e.Gender == Student.EGENDER.Female).ToList();
lstFemale.ForEach(x => Console.WriteLine(x));

// Danh sách sinh nhật vào tháng 10
Console.WriteLine("\n----DOB Next Month-----");
int nextMonth = (DateTime.Now.Month + 1) == 13 ? 1 : (DateTime.Now.Month + 1);
var lstDOB10 = lstStudent.Where(e => e.DOB.Month == nextMonth).ToList();
lstDOB10.ForEach(x => Console.WriteLine(x));
#endregion