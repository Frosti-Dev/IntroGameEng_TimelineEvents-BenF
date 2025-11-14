using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
        //plays timeline
        director.Play();
        Destroy(trigger);
    }
}
