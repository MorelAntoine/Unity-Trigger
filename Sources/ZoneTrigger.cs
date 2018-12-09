using UniCraft.Trigger.UnityEvent;
using UnityEngine;

namespace UniCraft.Trigger
{
	/// <inheritdoc/>
	/// <summary>
	/// Module to trigger events in relation to a zone
	/// </summary>
	[AddComponentMenu("UniCraft/Trigger/ZoneTrigger")]
	[RequireComponent(typeof(Collider))]
	public sealed class ZoneTrigger : MonoBehaviour
	{
		///////////////////////////////
		////////// Attribute //////////
		///////////////////////////////

		[SerializeField] private UnityEventCollider _onTriggerEnterEvents = null;
		[SerializeField] private UnityEventCollider _onTriggerStayEvents = null;
		[SerializeField] private UnityEventCollider _onTriggerExitEvents = null;

		////////////////////////////
		////////// Method //////////
		////////////////////////////

		private void OnTriggerEnter(Collider other)
		{
			_onTriggerEnterEvents.Invoke(other);
		}

		private void OnTriggerStay(Collider other)
		{
			_onTriggerStayEvents.Invoke(other);
		}

		private void OnTriggerExit(Collider other)
		{
			_onTriggerExitEvents.Invoke(other);
		}
	}
}
