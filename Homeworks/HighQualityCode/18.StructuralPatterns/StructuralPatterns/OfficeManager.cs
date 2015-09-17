namespace CompositePattern
{
    public class OfficeManager
    {
        public static void Main()
        {
            var theBoss = new Manager("Joro");
            var teamLead = new Manager("Vankata");
            theBoss.Add(teamLead);

            var pesho1 = new Worker("Pesho 1");
            var pesho2 = new Worker("Pesho 2");
            var pesho3 = new Worker("Pesho 3");
            teamLead.Add(pesho1);
            teamLead.Add(pesho2);
            teamLead.Add(pesho3);

            theBoss.Display(1);
        }
    }
}
