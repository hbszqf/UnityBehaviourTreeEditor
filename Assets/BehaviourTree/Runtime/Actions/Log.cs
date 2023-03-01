using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheKiwiCoder {
    [System.Serializable]
    public class Log : ActionNode
    {
        [Tooltip("Message to log to the console")] public string message;

        public BlackboardProperty key;

        protected override void OnStart() {
        }

        protected override void OnStop() {
        }

        protected override State OnUpdate() {
            Debug.Log($"{message} : {key.reference}");
            
            return State.Success;
        }
    }
}
