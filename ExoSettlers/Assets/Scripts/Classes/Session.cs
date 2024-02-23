using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    internal class Session
    {
        private string sessionId;
        private DateTime createdAt;
        private DateTime updatedAt;

        public Entity playerData;

        public Session()
        {
            sessionId = System.Guid.NewGuid().ToString();
            createdAt = new DateTime();
            updatedAt = new DateTime();
        }

        public Session(string sessionId)
        {
            this.sessionId = sessionId;
            // Collect the session via id, from session manager.
        }

        public void saveSession()
        {
            string serializedSessionData = JsonUtility.ToJson(this);
            // Do some sort of saving with the session data here.
        }
    }
}
