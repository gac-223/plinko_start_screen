using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
