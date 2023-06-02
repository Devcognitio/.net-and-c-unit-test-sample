namespace TestDevco.Exercises.F01
{
    public class BarReservation
    {
        public User MadeBy { get; set; }

        public BarReservation(User creator)
        {
            MadeBy = creator;
        }

        public bool CanUpdateReservation(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            bool isTheCreator = MadeBy.Id == user.Id;
            return user.IsAdmin || isTheCreator;
        }
    }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsAdmin { get; set; }
    }
}
