
public class Crate
{
  private string Id;
  public double Price;
      
  public Crate()
  {
    //this still needs to be worked on. I thought Random had a NextDouble, but 
    //I dont think NextDouble can take in integers?
      Price = new Random.NextDouble(50,501);
  }
  
  
}
