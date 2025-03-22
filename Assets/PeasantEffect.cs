using UnityEngine;

public class PeasantEffect : MonoBehaviour
{
    public Collider animCollider;
    private Animator animator;
    private AudioSource AudioSource;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animCollider = GetComponent<BoxCollider>();
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Activate", true);
        AudioSource.Play();

    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Activate", false);
    }

}
