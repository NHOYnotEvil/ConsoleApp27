namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int durationDoctorAppointment = 10;
            int minutesInHour = 60;

            Console.WriteLine("Вы пришли в поликлинику и видите очередь из людей. Так как времени у вас не много, вы" +
                " можете расчитать: сколько времени у вас уйдёт на ожидание свой очереди.");
            Console.Write("Сколько людей в очереди:");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            int waitingTimeHours = peopleInLine * durationDoctorAppointment / minutesInHour;
            int waitingTimeMinutes = peopleInLine * durationDoctorAppointment % minutesInHour;

            Console.WriteLine("Время ожидания в очереди - " + waitingTimeHours + " часов и " + waitingTimeMinutes + " минут.");
        }
    }
}