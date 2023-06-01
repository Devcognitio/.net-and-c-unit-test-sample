namespace TestDevco.Exercises.F05
{
    public class BeerController
    {
        public ActionResult GetBeer(int id)
        {
            if (id == 0)
                return new NotFound();

            return new Ok();
        }

        public class ActionResult { }

        public class NotFound : ActionResult { }

        public class Ok : ActionResult { }
    }
}
