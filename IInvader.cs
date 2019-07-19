namespace TreehouseDefense
{
  
    interface IMappable
    {
        MapLocation Location {get; }
    }
  
    interface IMovable
    {
        void Move();// => _pathStep += StepSize; they also dont have implementation
    }
    interface IInvader : IMappable, IMovable
    {
       // MapLocation Location {get; }
        
        // True if the invader has reached the end of the path
        bool HasScored { get; }// { return _pathStep >= _path.Length; } }
        
        //public virtual int Health { get; protected set; } = 2;
        int Health { get;}// protected set; }; // MUST be overriden in subclasses, cant have implementation -- same as virtual member,  no-implementation
        
        bool IsNeutralized {get; }
        
        bool IsActive {get; }
        
      //interfaces don't have constructors
        /*public Invader(Path path)
        {
            _path = path;
        }*/
        
        
        
        void DecreaseHealth(int factor);

    }
}