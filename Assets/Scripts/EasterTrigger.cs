using UnityEngine;

public class EasterTrigger : MonoBehaviour
{
    public GameObject funnytext;

    private void OnTriggerEnter(Collider other)
    {
        funnytext.SetActive(true);
    }

}
