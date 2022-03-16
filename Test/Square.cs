namespace HelloWorld.Test
{
    public class Square : Rectangle
    {
        private int m_Width;
        private int m_Height;

        public Square(int width, int height) : base(width, height)
        {
        }

        public override int Width
        {
            get
            {
                return m_Width;
            }
            set
            {
                m_Width = value;
                //m_Height = value;
            }
        }


        public override int Height
        {
            get
            {
                return m_Height;
            }
            set
            {
               // m_Width = value;
                m_Height = value;
            }
        }

        public override int Area
        {
            get
            {
                return (2* Width) + ( 2* Height);
            }
        }
    }
}