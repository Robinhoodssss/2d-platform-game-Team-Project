using UnityEngine;

public sealed class PassageTide : MonoBehaviour
{
    [Min(0)] public float rise = 4;
    [Min(0.1f)] public float cycleSeconds = 10;
    Vector3 low;
    void Awake() { low = transform.localPosition; }
    void Update()
    {
        float phase = Time.timeSinceLevelLoad * 2 * Mathf.PI / Mathf.Max(.1f, cycleSeconds);
        transform.localPosition = low + Vector3.up * (rise * .5f * (1 - Mathf.Cos(phase)));
    }
}
