using UnityEngine;

public class DontDestroy : MonoBehaviour
{
	public bool cleanup;
	public float time;

    void Start()
    {
	    if(cleanup)
	    {
		    foreach(var other in FindObjectsOfType<DontDestroy>())
		    {
			    if(other.time > 0)
			    {
					Debug.Log("I already exist!");
					Destroy(gameObject);
					return;
			    }
		    }
	    }

        Debug.Log("Don't Destroy On Load");
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
	    time += Time.deltaTime;
	    transform.position = new Vector3(Mathf.Sin(time), Mathf.Cos(time), 0);
    }
}
