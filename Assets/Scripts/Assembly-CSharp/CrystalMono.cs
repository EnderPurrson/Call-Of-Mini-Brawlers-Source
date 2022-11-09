using UnityEngine;

public class CrystalMono : MonoBehaviour
{
	public float min;

	public float max;

	public new ITAudioEvent audio;

	private bool isUsed;

	private void OnTriggerEnter(Collider other)
	{
		if (!isUsed && other.tag == "Hero")
		{
			audio.Trigger();
			audio.transform.parent = null;
			other.GetComponent<Hero>().AddCrystal(Random.Range(min, max));
			isUsed = true;
			Object.Destroy(base.gameObject);
		}
	}
}
