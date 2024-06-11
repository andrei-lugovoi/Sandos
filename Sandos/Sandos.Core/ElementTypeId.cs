namespace Sandos.Core;

public class World
{
  private ElementTypeId[][] _world;
  
  public void Update()
  {
    
  }

  public void Swap(ref IElement one, ref IElement with)
  {
    
  }
}

public interface IUpdateStrategy
{
  ElementTypeId[][] Update(ElementTypeId[][] world);
}

public class UpsideDown : IUpdateStrategy
{
  public ElementTypeId[][] Update(ElementTypeId[][] world)
  {
    
  }
}

public class Water : IElement
{
  private readonly World world;

  public Water(World world)
  {
    this.world = world;
    var fallDownRule = new Rule();
  }

  private void FallDown(ref IElement element)
  {
    if (element.TypeId is ElementTypeId.None)
      element = this;
    
    world.Swap(ref me, ref element);
  }

  public ElementTypeId TypeId { get; }
}

public class Rule
{
  public Rule(
    Action<IElement>? down = null, 
    Action<IElement>? left = null, 
    Action<IElement>? right = null, 
    Action<IElement>? up = null)
  {
    
  }
}

public class Rules
{
  
}

public interface IElement 
{
  ElementTypeId TypeId { get; }
}

public enum ElementTypeId 
{
  None = 0,
  Water,
  Sand,
  Smoke,
  Fire,
}

public delegate void Action<TIn>(ref TIn arg);
