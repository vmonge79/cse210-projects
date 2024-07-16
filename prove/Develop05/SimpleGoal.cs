public class SimpleGoal: Goal
{
 private bool _isComplete;
 
 public bool GetIsComplete()
 {
    return _isComplete;
 }

 public void SetIsComplete(bool isComplete)
 {
    _isComplete = isComplete;
 }

public SimpleGoal(string shortName, string description, int points) : base (shortName, description, points)
{
    
}

}