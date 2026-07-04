// note: unity's built-in particle system allows you to trigger dynamic visual effects
// like explosions and manipulating individual particles

using UnityEngine;

public class ParticleBurstEvent : TimelineEvent
{
    [SerializeField] private ParticleSystem targetParticleSystem; // reference to the target particle system

    public ParticleBurstEvent(ParticleSystem particleSystem)
    {
        targetParticleSystem = particleSystem;
    }

    public override void Execute()
    {
        if (targetParticleSystem != null)
        {
            targetParticleSystem.Play(); // trigger the particle burst
        }
        else
        {
            Debug.LogWarning("ParticleBurstEvent: Target particle system is null.");
        }
    }
}