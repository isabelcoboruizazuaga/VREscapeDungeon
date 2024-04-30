using System.Collections;
using UnityEngine;

public class BoxBreak : MonoBehaviour
{
    public ParticleSystem damageParticles;
    public ParticleSystem splintParticles;
    public ParticleSystem destroyedParticles;
    private int hitCount = 0;
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Break()
    {
        if (hitCount == 0)
        {
            damageParticles.Play();
            audioSource.Play();
        }

        hitCount++;

        StartCoroutine(MakeDamage());


        if (hitCount == 3)
        {
            var go = Instantiate(destroyedParticles.gameObject, transform.position, transform.rotation);
            
           

            //StartCoroutine(Explode());
            Destroy(go, 0.8f);
            Destroy(this.gameObject, 0.4f);
        }
    }
    private IEnumerator MakeDamage()
    {
        damageParticles.Play();
        splintParticles.Play();
        audioSource.Play();

        var em = splintParticles.emission;
        em.enabled = true;

        yield return new WaitForSeconds(0.5f);

        damageParticles.Pause();
        em.enabled = false;
    }

    private IEnumerator Explode()
    {
        var go = Instantiate(destroyedParticles, transform.position, transform.rotation);
        go.Play();
        audioSource.Play();

        yield return new WaitForSeconds(0.5f);

        destroyedParticles.Stop();
        Destroy(go);

    }
}
