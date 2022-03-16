namespace HelloWorld.Test
{
 public class Rectangle
 {

     public Rectangle(int width, int height)
     {
         Width = width;
         Height = height;
     }
   public virtual int Height { get; set; }
   public virtual int Width { get; set; }

   public virtual int Area{

       get
       {
           return Width * Height;
       }
   }
   
   
 }
 
}