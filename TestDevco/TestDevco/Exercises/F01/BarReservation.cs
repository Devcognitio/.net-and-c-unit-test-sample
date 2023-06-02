namespace TestDevco.Exercises.F01
{
    public class BarReservation
    {
        public User MadeBy { get; set; } = new User();

        public bool CanUpdateReservation(User user)
        {
            return user.IsAdmin || MadeBy.Id == user.Id;

            /*var result = false;
            if(user.IsAdmin || MadeBy.Id == user.Id) result = true;
            return result;*/

            /*if (user.IsAdmin) return true;
            if (MadeBy.Id == user.Id) return true;
            return false;*/
        }
    }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsAdmin { get; set; }
    }
}
