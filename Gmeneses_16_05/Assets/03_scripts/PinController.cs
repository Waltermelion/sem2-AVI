using UnityEngine;
using UnityEngine.SceneManagement;

public class PinController : MonoBehaviour
{
    public int ammountFallen = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IndividualPin>().isfallen != true)
        {
            ammountFallen += 1;
            other.GetComponent<IndividualPin>().isfallen = true;
            Debug.Log(ammountFallen);
        }
    }
    private void Update()
    {
        if(ammountFallen == 10)
        {
            SceneManager.LoadScene("victory");
        }
        else if(ammountFallen < 10 && GameObject.Find("bowlingball").GetComponent<Playercontroller>().tentativas == 0)
        {
            SceneManager.LoadScene("lose");
        }
    }
}