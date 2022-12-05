namespace SimpleGame.Model
{
  public class Game
  {
    private string _name;
    private int _pointTotal;
    private string _stateOfMind;

    //constructor
    public Game(string name)
    {
      _name = name;
      _pointTotal = 0;
      _stateOfMind = "neutral";
    }

    //getter and setter methods
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public int GetPointTotal()
    {
      return _pointTotal;
    }
    public void SetPointTotal(int pointTotal)
    {
      _pointTotal = pointTotal;
    }
    public string GetStateOfMind()
    {
      return _stateOfMind;
    }
    public void SetStateOfMind(string stateOfMind)
    {
      _stateOfMind = stateOfMind;
    }

    //public methods
    public void DetermineNextSteps()
    {
      IncreasePoints();
      UpdateStateOfMind();
      IsGameOver();
    }

    // private methods
    private void IncreasePoints()
    {
      _pointTotal++;
    }
    private void UpdateStateOfMind()
    {
      if (_pointTotal < 3)
      {
        _stateOfMind = "neutral";
      }
      else if (_pointTotal < 6)
      {
        _stateOfMind = "happy";
      }
      else
      {
        _stateOfMind = "thrilled";
      }
    }
    private bool IsGameOver()
    {
      if (_stateOfMind == "thrilled")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}