using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] private string storyText;
    [SerializeField] private State[] nextState;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextState()
    {
        return nextState;
    }
}
