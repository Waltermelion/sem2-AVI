using UnityEngine;
using UnityEngine.UI;

public class adeus : MonoBehaviour
{
    [SerializeField] private Text ola;
    public void changeText()
    {
        ola.GetComponent<Text>().text = "Adeus";
        ola.GetComponent<Text>().color = Color.blue; 
    }
}