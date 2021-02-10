using System;

namespace Project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Elevator elevatorA = new Elevator();
            Elevator elevatorB = new Elevator();           
        }
    }

    public class Elevator
    {
        #region Fields
        private int currentFloor_;
        private int timer_;
        private int destinationFloor_;
        private Occupant occupant_;
        private bool isEmergencyPressed_;
        private bool isOpen_;

        #endregion

        public Elevator()
        {

        }
        #region Properties
        public int CurrentFloor
        {
            get
            {
                return currentFloor_;
            }
            set
            {
                currentFloor_ = value;
            }
        }

        public int Timer
        {
            get
            {
                return timer_;
            }
            set
            {
                timer_ = value;
            }
        }

        public int DestinationFloor
        {
            get
            {
                return destinationFloor_;
            }
            set
            {
                destinationFloor_ = value;
            }
        }

        public Occupant Occupant
        {
            get
            {
                return occupant_;
            }
            set
            {
                occupant_ = value;
            }
        }

        public bool IsPressed
        {
            get
            {
                return isEmergencyPressed_;
            }
            set
            {
                isEmergencyPressed_ = value;
            }
        }

        public bool IsOpen
        {
            get
            {
                return isOpen_;
            }
            set
            {
                isOpen_ = value;
            }
        }

        #endregion

        #region Methods
        public void GoingUp()
        {

        }

        public void GoingDown()
        {

        }

        public void Reset()
        {

        }

        public void PressesUp()
        {

        }

        public void PressesDown()
        {
            // Check floor
        }

        public void PressesFloor(int destination)
        {

        }

        public bool PressesEmergency(bool pressed)
        {
            return true;
        }

        #endregion

    }
    public struct Occupant
    {        
        public bool pressEmergency;        
        public int currentFloor;
        public int destinationFloor;
        public int occupantStatus;

    }

    [Flags]
    enum occupantStatus
    {        
        GOING_UP,
        GOING_DOWN,
        ON_ELEVATOR,
        OFF_ELEVATOR,
        WAITING
    }

}
