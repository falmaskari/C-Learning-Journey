namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Rectangle1 rec1 = new Rectangle1(rec.GetArea);
            rec1 += rec.GetPerimeter;
            rec1 += rec.GetAddArea;
            rec1 += rec.GetSubtractArea;
            rec1 += rec.GetDivisionArea;
            rec1 -= rec.GetDivisionArea;
            rec1(10, 12);


            Rectangle rec = new Rectangle(2);
            Rectangle rec1 = new Rectangle(3);
            Rectangle rec2 = rec * rec1;
            Rectangle rec3 = rec / rec1;
            Rectangle rec4 = rec + rec1;
            Rectangle rec5 = rec - rec1;
            Console.WriteLine(rec2.number);
            Console.WriteLine(rec3.number);
            Console.WriteLine(rec4.number);
            Console.WriteLine(rec5.number);
        }
    }
}
