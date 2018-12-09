using UniCraft.Trigger.UnityEvent;
using UnityEngine;

namespace UniCraft.Trigger
{
    /// <inheritdoc/>
    /// <summary>
    /// Module to trigger events in relation to a 2D zone
    /// </summary>
    [AddComponentMenu("UniCraft/Trigger/ZoneTrigger2D")]
    [RequireComponent(typeof(Collider2D))]
    public sealed class ZoneTrigger2D : MonoBehaviour
    {
        ///////////////////////////////
        ////////// Attribute //////////
        ///////////////////////////////

        [SerializeField] private UnityEventCollider2D _onTriggerEnterEvents = null;
        [SerializeField] private UnityEventCollider2D _onTriggerStayEvents = null;
        [SerializeField] private UnityEventCollider2D _onTriggerExitEvents = null;

        ////////////////////////////
        ////////// Method //////////
        ////////////////////////////

        private void OnTriggerEnter2D(Collider2D other)
        {
            _onTriggerEnterEvents.Invoke(other);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            _onTriggerStayEvents.Invoke(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            _onTriggerExitEvents.Invoke(other);
        }
    }
}
