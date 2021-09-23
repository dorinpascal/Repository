using System;

namespace Ex3_Doctor
{
    public class Patient
    {
        private int NumberInQueue;

        public Patient(WaitingRoom wr)
        {
            wr.NumberChange = ReactToNumber;
            wr.DrawNumber();

        }

        public  void ReactToNumber(int ticketNumber)
        {
            Console.WriteLine("Patients look up");
            if (ticketNumber==NumberInQueue)
            {
                Console.WriteLine("Patient {0} goes to the room",NumberInQueue);
            }
            else Console.WriteLine("Patient {0} goes back ",NumberInQueue); }
    }
}