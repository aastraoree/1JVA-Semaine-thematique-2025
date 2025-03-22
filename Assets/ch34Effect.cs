using UnityEngine;

public class ch34Effect : MonoBehaviour
{
    public Collider animCollider;
    private Animator animator;
    private AudioSource audioSource;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animCollider = GetComponent<BoxCollider>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Activate", true);
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Activate", false);
    }

}
