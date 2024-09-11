//N1
 class Product
{
    protected string name;
    protected string? nameplace;
    protected int price;
    public string Name { get; set; }

    public string Nameplace
    {
        get { return nameplace?? "Uknown nameplace"; }
        set { nameplace = value; }
    }
    public int Price
    {
        get { return price; }
        set { if (price <= 0)
            {
                Console.WriteLine("Error, the value can't be lower than 0");
            }
            else price = value;
        }
    }

    public Product(string name, string nameplace, int price)
    {
        this.name = name;
        this.nameplace = nameplace;
        this.price = price;
    }

}
class Toy  : Product
{
    int agerating;
    string creatingplace;

    public int Agerating { get; set; }
    public string Creatingplace { get; set; }

    public Toy(int agerating, string creatingplace, string name, string nameplace, int price) : base(name, nameplace, price) 
    {
        this.agerating = agerating;
        this.creatingplace = creatingplace;
       
    }
    public void Print()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("NamePlace: " + nameplace);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Age rating: " + agerating);
        Console.WriteLine("Creation Place: " + creatingplace);
    }
}
//N2
class Animal
{
    protected int age;
    protected double weight;
    protected double speed;
    protected double height;
    protected string place;
 
    
    public int Age { get; set; }
    public double Weight { get; set; }

    public double Speed {  get; set; }
    public Animal(int age, double weight, double speed, double height, string place)
    {
        this.age = age;
        this.weight = weight;
        this.speed = speed;
        this.height = height;
        this.place = place;
       
    }
    public virtual void Output(){ }
   

}
class Tiger : Animal
{
    string strenght;
    public string Strenght { get; set; }
    public Tiger(string strenght, int a, double w, double s, double h, string p) : base(a, w, s, h, p)
    {
        this.strenght = strenght;
    }
    public override void Output()
    {
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Place: " + place);
        Console.WriteLine("Strenght" + strenght);
    }
}

class Crocodile : Animal
{
    int countOfTeeth;
    public int CountofTeeth { get; set; }
    public Crocodile(int countOfTeeth, int a, double w, double s, double h, string p) : base(a, w, s, h, p)
    {
        this.countOfTeeth = countOfTeeth;
    }
    public override void Output()
    {
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Place: " + place);
        Console.WriteLine("countOfTeeth: " + countOfTeeth);
    }
}

class Kangaroo : Animal
{

    double jumpDistance;
    public int jumpdistance { get; set; }
    public Kangaroo(double jumpDistance, int a, double w, double s, double h, string p) : base(a, w, s, h, p)
    {
        this.jumpDistance = jumpDistance;
    }
    public override void Output()
    {
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Place: " + place);
        Console.WriteLine("Jump dictance in m =  " + jumpDistance);
    }


}
public abstract class Figure
{
    public abstract void Result();
}
//N3

class Rectangle : Figure
{
    int lenght;
    int width;
    public int Lenght { get; set; }
    public int Width { get; set; }
    public Rectangle(int lenght, int width)
    {
        this.lenght = lenght;
        this.width = width;
    }
    public override void Result()
    {
        int S = lenght * width;
        Console.WriteLine("Result of Rectangle: " + S);
    }
}
class Circle : Figure
{
    double pi;
    int r;
    
    public double PI { get; set; }
    public int R { get; set; }

    public Circle(double pi, int r)
    {
        this.pi = pi;
        this.r = r;
    }
    public override void Result()
    {
       double S = pi * Math.Pow(r,2);
        Console.WriteLine("Result of Circle: " + S);
    }
}

class Righttriangle : Figure
{
    int a;
    int b;
    public int A { get; set; }
    public int B { get; set; }

    public Righttriangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public override void Result()
    {
        double S = 0.5 * a * b;
        Console.WriteLine("Result of right triangle: " + S);
    }
}

class Trapezoid : Figure
{
    int a;
    int b;
    int h;
    public int A { get; set; }
    public int B { get; set; }

    public int H { get; set; }
    public Trapezoid(int a, int b, int h)
    {
        A = a;
        B = b;
        H = h;
        
    }

    public override void Result()
    {
        int S = ((A + B) * H) / 2;
        Console.WriteLine("Result of Trapezoid: " + S);
    }

}

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Toy obj = new Toy(6, "China", "Robot", "ToyStore", 150);
            obj.Print();
            //N2
            Tiger obj2 = new Tiger("6 bite", 13, 34, 67, 65, "America");
            obj2.Output();

            Crocodile obj3 = new Crocodile(86, 8, 34, 89, 56, "Africa");
            obj3.Output();

            Kangaroo obj4 = new Kangaroo(5, 23, 35, 65, 23, "Australia");
            obj4.Output();
            //N3
            Figure[] arr = new Figure []{ new Rectangle(4, 6), new Circle(3.14159, 6), new Righttriangle(1,2), new Trapezoid(1,2,3) };
           foreach(var val in arr)
            {
                val.Result();
            }
        }
    }
}
