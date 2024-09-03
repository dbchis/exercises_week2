public class Dice
{
    private int slides;
    public Dice(int slide){
        slides = slide;
    }
    public int Roll(){
        Random random = new Random();
        return random.Next(1,slides+1);
    }

    // public static void Main(string[] args)
    // {
    //     int slide=0;
    //     bool isValidInput = false;

    //     while (!isValidInput)
    //     {
    //         Console.Write("Enter slide: ");
    //         string input = Console.ReadLine();

    //         if (int.TryParse(input, out slide) && slide > 0)
    //         {
    //             isValidInput = true;
    //             Console.WriteLine("Slides: " + slide);
    //         }
    //         else
    //         {
    //             Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập lại một số nguyên dương.");
    //         }
    //     }
    //     Dice dice = new Dice(slide);
    //     Console.WriteLine("Result: "+ dice.Roll());

    // }
}