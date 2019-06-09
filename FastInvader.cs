namespace TreehouseDefense
{
    class FastInvader : Invader
    {
        
        protected override int StepSize {get; } = 2; //protected modifier allows for only access for only Invader class and its subclasses 
      
        public FastInvader(Path path): base(path)
        {
            
        }  
    }
}