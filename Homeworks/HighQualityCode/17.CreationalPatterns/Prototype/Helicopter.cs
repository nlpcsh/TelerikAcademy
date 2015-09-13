namespace Prototype
{
    using System.Threading;

    public class Helicopter : HelicopterPrototype
    {
        public Helicopter(string type, int speed, int weight)
        {
            Thread.Sleep(2000); // Doing something slow
            this.Type = type;
            this.Speed = speed;
            this.Weight = weight;
        }

        public string Type { get; set; }

        public int Speed { get; set; }

        public int Weight { get; set; }

        public override Helicopter Clone()
        {
            // Options of cloning in .NET (http://stackoverflow.com/a/966534/1862812)
            // Clone Manually - Tedious, but high level of control
            // Clone with MemberwiseClone - Fastest but only creates a shallow copy, i.e. for reference-type fields the original object and it's clone refer to the same object.
            // Clone with Reflection - Shallow copy by default, can be re-written to do deep copy. Advantage: automated. Disadvantage: reflection is slow.
            // Clone with Serialization - Easy, automated. Give up some control and serialization is slowest of all.
            return this.MemberwiseClone() as Helicopter;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Speed: {1}, Weight: {2}", this.Type, this.Speed, this.Weight);
        }
    }
}
