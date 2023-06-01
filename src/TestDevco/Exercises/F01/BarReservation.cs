namespace TestDevco.Exercises.F01
{
    public class BarReservation
    {
        public User MadeBy { get; set; }

        public bool CanUpdateReservation(User user)
        {
            if (user.IsAdmin) return true;
            if (MadeBy.Id == user.Id) return true;
            return false;
        }
    }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsAdmin { get; set; }
    }
}
