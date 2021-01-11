namespace CreateClass
{
    public class Room
    {
        private int roomNumber;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public int RoomNumber
        {
            get => roomNumber;
            set => roomNumber = value;
        }
    }
}