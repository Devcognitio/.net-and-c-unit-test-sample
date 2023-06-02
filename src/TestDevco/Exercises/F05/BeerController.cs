namespace TestDevco.Exercises.F05;

public static class BeerController
{
    public static ActionResult GetBeer(int id)
    {
        if (id == 0)
            return new NotFound();

        return new Ok();
    }

    public class ActionResult { }

    public class NotFound : ActionResult { }

    public class Ok : ActionResult { }
}