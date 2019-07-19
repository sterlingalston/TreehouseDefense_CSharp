namespace TreehouseDefense
{
    abstract class Invader :IInvader
    {
        private readonly Path _path;
        private int _pathStep = 0;
      
        protected virtual int StepSize {get; } = 1; //protected modifier allows for only access for only Invader class and its subclasses 
        
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        
        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        
        //public virtual int Health { get; protected set; } = 2;
        public abstract int Health { get; protected set; } // MUST be overriden in subclasses, cant have implementation -- same as virtual member,  no-implementation
        
        public bool IsNeutralized => Health <= 0;
        
        public bool IsActive => !(IsNeutralized || HasScored);
        
        public Invader(Path path)
        {
            _path = path;
        }
        
        public virtual void Move() => _pathStep += StepSize;
        
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!"); 
        }
    }
}