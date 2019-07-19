namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
      
        protected override int StepSize {get; } = 2; //protected modifier allows for only access for only Invader class and its subclasses 
      
        public FastInvader(Path path): base(path)
        {
            
        }  
    }
}