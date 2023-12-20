namespace CodeAcademySpace
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext db = new AppDbContext();
            string spacename = "Code Academy";
            int capacity = 15;
            Space space = new Space
            {
                SpaceName = spacename,
                capacity = capacity
            };

            db.spaces.Add(space);
            db.SaveChanges();

            booking booking = new booking
            {
                SpaceID = 1,
                BookDate = DateTime.Now.Date,
                BookTime = DateTime.Now.TimeOfDay
            };

        }





    }
}
