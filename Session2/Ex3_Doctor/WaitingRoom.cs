using System;
using System.Threading;

namespace Ex3_Doctor
{
    public class WaitingRoom
    {
        private int CurrentNumber;
        private int TicketCount;
        public Action<int> NumberChange;
        public WaitingRoom()
        {
            CurrentNumber = 0;
            TicketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (CurrentNumber < TicketCount)
            {
                NumberChange?.Invoke(CurrentNumber);
                CurrentNumber++;
                Console.WriteLine("Diiiing");
                Console.WriteLine("Patient number {0} can now enter",CurrentNumber);
                Thread.Sleep(1000);
                
            }
        }

        public int DrawNumber()
        {
            return ++TicketCount;
        }
        
    }
}