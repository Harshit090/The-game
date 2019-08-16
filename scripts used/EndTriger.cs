using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public gamemanager game;

    void OnTriggerEnter ()
    {
        game.CompleteLevel();
    }
}
