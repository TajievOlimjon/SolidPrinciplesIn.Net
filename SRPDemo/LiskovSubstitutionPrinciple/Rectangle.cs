namespace SRPDemo.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        int x;
        public Rectangle(int x)
        {
            this.x = x;
        }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea()
        {
            int res = 0;
            return res = Width * Height;
        }
    }
    public class Square : Rectangle
    {
        public Square(int x):base(x)
        {
            x = Width + Height;
        }
        public override int Height
        { 
          get => base.Height;
          set
          {
              base.Height = value;
              base.Width = value;
          }
        }
        public override int Width
        { 
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public int GetSquare()
        {
            return GetArea();
        }
    }
}
