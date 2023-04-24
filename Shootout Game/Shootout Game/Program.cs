namespace Shootout_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of robbers: ");
            int R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the robber with whon sam will start shooting: ");
            int Start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the gap between robbers: ");
            int gap = Convert.ToInt32(Console.ReadLine());

            int[] robbers = new int[R];
            int CurrentIndex = Start - 1;
            int ShotsCompleted = 0;

            for (int i = 0; i < R; i++)
            {
                robbers[i] = i + 1;
                
            }


            while (R != 0)
            {
                if (CurrentIndex >= R)
                {
                    CurrentIndex = CurrentIndex % R;
                }

                Console.WriteLine($"Target = {robbers[CurrentIndex]} , {++ShotsCompleted} shots completed");

                
                for (int i = CurrentIndex; i < R - 1; i++)
                {
                    robbers[i] = robbers[i + 1];
                }
                R--;
                CurrentIndex += gap;
            }



            Console.WriteLine(ShotsCompleted + " shots taken");
        }
    }
}