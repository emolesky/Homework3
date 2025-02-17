using System;
//Wrtten by Emilynn Molesky
//2/11/2025
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasTest
{
    enum ChestState
    {
        Open,
        Closed,
        Locked
    }
    public class Chest
    {
        private ChestState State{ get; set; } = ChestState.Locked;

        public void Open()
        {
            if (State == ChestState.Closed)
            {
                State = ChestState.Open;
                Console.WriteLine(" You can open the chest.");
            }
            else
            {
                Console.WriteLine("You cant open the chest in its current state.");
            }
        }
        public void Close()
        {
            if (State == ChestState.Open)
            {
                State = ChestState.Closed;
                Console.WriteLine(" You closed the chest.");
            }
            else
            {
                Console.WriteLine(" you can only lock a closed chest.");
            }

        }
        public void Lock()
        {
            if (State == ChestState.Closed)
            {
                State = ChestState.Locked;
                Console.WriteLine("You locked the chest.");
            }
        }
        public void Unlock()
        {
            if (State == ChestState.Locked)
            {
                State = ChestState.Closed;
                Console.WriteLine("You unlocked the chest.");
            }
            else
            {
                Console.WriteLine(" The chest is not locked.");
            }
        }
    }
}
