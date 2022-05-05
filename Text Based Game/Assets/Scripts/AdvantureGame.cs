using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AdvantureGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private State startingState;

    private State state;

    private void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextState = state.GetNextState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
        }

        textComponent.text = state.GetStateStory();
    }
}
